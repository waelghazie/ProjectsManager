using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace ProjectsManager
{
    public partial class RestoreDBBackupForm : Form
    {
        public RestoreDBBackupForm()
        {
            InitializeComponent();
        }

        bool flag = false;
        bool SuccessRestore = false;
        bool SuccessFileListing = false;
        DataTable DT;

        private void RestoreDBBackupForm_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            DT = new DataTable();
            DT.Columns.Add("اسم الملف");
            DT.Columns.Add("تاريخ الإنشاء");

            DatabaseTextBox.Text = Settings1.Default.DatabaseName;
            BackupFolderTextBox.Text = Settings1.Default.BackupFolder;

            label5.Visible = false;
            ConfirmTextBox.Visible = false;

            GetFileBGW.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("هل أنت متأكد من استرجاع نسخة احتياطية بواسطة الملف \n" + FileNameTextBox.Text, "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes && flag == false)
            {
                MessageBox.Show("يرجى التأكيد على العملية بكتابة النص في المربع");
                label5.Visible = true;
                ConfirmTextBox.Visible = true;
                flag = true;
                ConfirmTextBox.Focus();
            }
            if (DR == DialogResult.Yes && flag == true && ConfirmTextBox.Text == label5.Text)
            {
                progressBar1.Visible = true;
                RestoreBGW.RunWorkerAsync();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null && dataGridView1.SelectedCells.Count > 0)
                FileNameTextBox.Text = Convert.ToString(dataGridView1.SelectedCells[0].Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RestoreBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (SqlConnection Connection = AppConnection.GetConnectionUsingMaster())
                {
                    string MdfName = "", LdfName = "";
                    string MdfPath = "", LdfPath = "";
                    string SqlVersion = "";

                    Connection.Open();
                    SqlCommand Command = new SqlCommand(@"Use [master] ALTER DATABASE [" + DatabaseTextBox.Text + @"] SET OFFLINE WITH ROLLBACK IMMEDIATE", Connection);
                    Command.ExecuteNonQuery();

                    Command.CommandText = @"SELECT SERVERPROPERTY('productversion')";
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                            SqlVersion = Reader.GetString(0);
                    Reader.Close();

                    if (SqlVersion.StartsWith("9"))
                    {
                        Command.CommandText = @"DECLARE @FileList TABLE (
                          LogicalName nvarchar(128) NOT NULL,PhysicalName nvarchar(260) NOT NULL,Type char(1) NOT NULL,FileGroupName nvarchar(120) NULL,Size numeric(20, 0) NOT NULL,MaxSize numeric(20, 0) NOT NULL,
                          FileID bigint NULL,CreateLSN numeric(25,0) NULL,DropLSN numeric(25,0) NULL,UniqueID uniqueidentifier NULL,ReadOnlyLSN numeric(25,0) NULL ,ReadWriteLSN numeric(25,0) NULL,
                          BackupSizeInBytes bigint NULL,SourceBlockSize int NULL,FileGroupID int NULL,LogGroupGUID uniqueidentifier NULL,DifferentialBaseLSN numeric(25,0)NULL,DifferentialBaseGUID uniqueidentifier NULL,
                          IsReadOnly bit NULL,IsPresent bit NULL
                          )
                          INSERT INTO @FileList EXEC('RESTORE FILELISTONLY FROM DISK = ''" + Settings1.Default.BackupFolder + "\\" + FileNameTextBox.Text + @"''')
                          Select LogicalName from @filelist ";
                    }
                    else if (SqlVersion.StartsWith("11"))
                    {
                        Command.CommandText = @"DECLARE @FileList TABLE (
                          LogicalName nvarchar(128) NOT NULL,PhysicalName nvarchar(260) NOT NULL,Type char(1) NOT NULL,FileGroupName nvarchar(120) NULL,Size numeric(20, 0) NOT NULL,
                          MaxSize numeric(20, 0) NOT NULL,FileID bigint NULL,CreateLSN numeric(25,0) NULL,DropLSN numeric(25,0) NULL,UniqueID uniqueidentifier NULL,ReadOnlyLSN numeric(25,0) NULL ,
                          ReadWriteLSN numeric(25,0) NULL,BackupSizeInBytes bigint NULL,SourceBlockSize int NULL,FileGroupID int NULL,LogGroupGUID uniqueidentifier NULL,
                          DifferentialBaseLSN numeric(25,0)NULL,DifferentialBaseGUID uniqueidentifier NULL,IsReadOnly bit NULL,IsPresent bit NULL,
                          TDEThumbprint varbinary(32) 
                          )
                          INSERT INTO @FileList EXEC('RESTORE FILELISTONLY FROM DISK = ''" + Settings1.Default.BackupFolder + "\\" + FileNameTextBox.Text + @"''')
                          Select LogicalName from @filelist ";
                    }
                    Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        Reader.Read();
                        MdfName = Reader.GetString(0);
                        Reader.Read();
                        LdfName = Reader.GetString(0);
                    }
                    Reader.Close();

                    Command.CommandText = @"SELECT physical_name FROM sys.master_files where physical_name like '%" + Settings1.Default.DatabaseName + @"%mdf' ";
                    Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                            MdfPath = Reader.GetString(0);
                    Reader.Close();

                    Command.CommandText = @"SELECT physical_name FROM sys.master_files where physical_name like '%" + Settings1.Default.DatabaseName + @"%ldf' ";
                    Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                            LdfPath = Reader.GetString(0);
                    Reader.Close();

                    if (MdfName != "" && MdfPath != "" && LdfName != "" && LdfPath != "")
                    {
                        Command.CommandText = @"RESTORE DATABASE @Databasename FROM  DISK = @path WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10,
                        move @MdfName to @MdfPath, move @LdfName to @LdfPath";
                        Command.Parameters.Add("@Databasename", SqlDbType.NVarChar).Value = Settings1.Default.DatabaseName;
                        Command.Parameters.Add("@path", SqlDbType.NVarChar).Value = Settings1.Default.BackupFolder + "\\" + FileNameTextBox.Text;
                        Command.Parameters.Add("@MdfName", SqlDbType.NVarChar).Value = MdfName;
                        Command.Parameters.Add("@MdfPath", SqlDbType.NVarChar).Value = MdfPath;
                        Command.Parameters.Add("@LdfName", SqlDbType.NVarChar).Value = LdfName;
                        Command.Parameters.Add("@LdfPath", SqlDbType.NVarChar).Value = LdfPath;
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();

                        SuccessRestore = true;
                    }
                }
            }
            catch (Exception exp)
            { MessageBox.Show(exp.Message + exp.InnerException, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void RestoreBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            using (SqlConnection Connection = AppConnection.GetConnectionUsingMaster())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand("Use [master] ALTER DATABASE [" + DatabaseTextBox.Text + @"] SET ONLINE", Connection);
                Command.ExecuteNonQuery();
            }

            progressBar1.Visible = false;

            if (SuccessRestore)
            {
                MessageBox.Show(" تم استرجاع النسخة الاحتياطية بنجاح \n ستتم اعادة تشغيل البرنامج", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ProcessStartInfo Info = new ProcessStartInfo();
                Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                Info.WindowStyle = ProcessWindowStyle.Hidden;
                Info.CreateNoWindow = true;
                Info.FileName = "cmd.exe";
                Process.Start(Info);
                Application.Exit();
            }
        }

        private void GetFileBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DirectoryInfo DI = new DirectoryInfo(Settings1.Default.BackupFolder);
                
                foreach (FileInfo FI in DI.GetFiles(@"*.bak"))
                {
                    DataRow DR = DT.NewRow();
                    DR["اسم الملف"] = FI.Name;
                    DR["تاريخ الإنشاء"] = FI.CreationTimeUtc;
                    DT.Rows.Add(DR);
                }
                SuccessFileListing = true;
            }
            catch
            {  }
        }

        private void GetFileBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (SuccessFileListing)
            {
                dataGridView1.DataSource = DT;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
                StartButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("لا يمكن الوصول إلى مجلد النسخ الاحتياطي\n", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            progressBar1.Visible = false;
        }



    }
}
