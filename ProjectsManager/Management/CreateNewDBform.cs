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
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Diagnostics;

namespace ProjectsManager
{
    public partial class CreateNewDBform : Form
    {
        public CreateNewDBform()
        {
            InitializeComponent();
        }

        Server Server;
        SqlConnection SqlConnection;
        SqlCommand command;
        string script;
        bool AreServersListed = false;
        bool SuccessDBCreation = false;
        string SelectedServer, SelectedDB;

        SqlDataSourceEnumerator instance;
        DataTable DT;

        private void CreateDB_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "جاهز";

            ProgressBar1.Visible = false;
            ProgressBar1.Style = ProgressBarStyle.Marquee;
            ProgressBar1.MarqueeAnimationSpeed = 30;

            instance = SqlDataSourceEnumerator.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create new database
            if (DatabaseTextBox.Text == "" || ServerComboBox.Text == "" || UsernameTextBox.Text == "" || PasswordTextBox.Text == "" || TimeOutTextBox.Text == "" || PathTextBox.Text == "")
                MessageBox.Show("الرجاء تحديد كافة البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                toolStripStatusLabel1.Text = "يرجى الانتظار";
                StartButton.Enabled = false;
                ExitButton.Enabled = false;

                ProgressBar1.Visible = true;
                SelectedServer = ServerComboBox.Text;
                SelectedDB = DatabaseTextBox.Text;

                //create Database in another thread
                backgroundWorker1.RunWorkerAsync();
            }
        }
        

        private void  comboBox1_DropDown(object sender, EventArgs e)
        {
            if (!AreServersListed)
            {
                
                ProgressBar1.Visible = true;
                toolStripStatusLabel1.Text = "جاري احضار قائمة المخدمات";
                backgroundWorker2.RunWorkerAsync();
            }
            AreServersListed = true;
        }

        private void DatabaseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = false;
            else
            { e.Handled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SqlConnection = new SqlConnection();
                SqlConnection.ConnectionString = @"Data Source=" + SelectedServer + ";Initial Catalog=master;User ID=" + UsernameTextBox.Text + ";Password=" + PasswordTextBox.Text + ";Connect Timeout=" + Convert.ToInt32(TimeOutTextBox.Text);
                SqlConnection.Open();

                Server = new Server(new ServerConnection(SqlConnection));
                
                script = Properties.Resources.DB_script.ToString();
                script = script.Replace("Param1", SelectedDB);
                script = script.Replace("Param2", PathTextBox.Text);
                Server.ConnectionContext.ExecuteNonQuery(script);
                //toolStripStatusLabel1.Text = "تم إنشاء قاعدة البيانات";

                script = Properties.Resources.Tables_script.ToString();
                script = script.Replace("Param1", SelectedDB);
                Server.ConnectionContext.ExecuteNonQuery(script);
                //toolStripStatusLabel1.Text = "تم إنشاء الجداول";

                script = Properties.Resources.Views_script.ToString();
                script = script.Replace("Param1", SelectedDB);
                Server.ConnectionContext.ExecuteNonQuery(script);
                //toolStripStatusLabel1.Text = "تم إنشاء  views";

                command = new SqlCommand(@"INSERT INTO [" + SelectedDB + @"].[dbo].[users]
                    ([displayname],[username],[password],[read],[modify],[create]
                    ,[delete],[ManageUsers],[isdomainuser])
                    VALUES ('System Administrator','admin','" + Encryption.Encrypt("0000") + "',1,1,1,1,1,0)", SqlConnection);
                command.ExecuteNonQuery();
                //toolStripStatusLabel1.Text = "تم إنشاء حساب المدير ";

                command.CommandText = @"INSERT INTO [" + SelectedDB + @"].[dbo].[appsettings] ([DatabaseName],[BackupInterval]) VALUES ('" + DatabaseTextBox.Text + "',2)";
                command.ExecuteNonQuery();
                //toolStripStatusLabel1.Text = "تم إنشاء سجل اعدادات البرنامج";

                Settings1.Default.SQLServer = SelectedServer;
                Settings1.Default.ServerUser = UsernameTextBox.Text;
                Settings1.Default.ServerPassword = Encryption.Encrypt(PasswordTextBox.Text);
                Settings1.Default.ReportsFolder = "";
                Settings1.Default.BackupFolder = "";
                Settings1.Default.DatabaseName = SelectedDB;
                Settings1.Default.ApplicationUsername = "";
                Settings1.Default.ApplicationPassword = "";
                Settings1.Default.PhotosPath = "";
                Settings1.Default.Save();

                SuccessDBCreation = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "\n" + exp.InnerException, "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar1.Visible = false;
            if (SqlConnection.State == ConnectionState.Open)
                SqlConnection.Close();
            toolStripStatusLabel1.Text = "تم";

            StartButton.Enabled = true;
            ExitButton.Enabled = true;

            if (SuccessDBCreation)
            {
                StartButton.Enabled = true; 
                ExitButton.Enabled = true;
                MessageBox.Show("تم إنشاء قاعدة البيانات بنجاح " + DatabaseTextBox.Text + "\n يرجى تعيين الاعدادات الخاصة", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Restart Application
                ProcessStartInfo Info = new ProcessStartInfo();
                Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                Info.WindowStyle = ProcessWindowStyle.Hidden;
                Info.CreateNoWindow = true;
                Info.FileName = "cmd.exe";
                Process.Start(Info);
                Application.Exit();
            }

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            DT = instance.GetDataSources();

            AreServersListed = true;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            foreach (DataRow server in DT.Rows)
            {
                ServerComboBox.Items.Add(server[DT.Columns["ServerName"]].ToString());
            }

            ProgressBar1.Visible = false;
            toolStripStatusLabel1.Text = "جاهز";
        }


    }
}
