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

namespace ProjectsManager
{
    public partial class DBSettingsForm : Form
    {

        public DBSettingsForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        User user;

        private void AppSettings_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [PhotosPath],[BackupPath],[BackupInterval] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[appsettings]", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            PhotosPathTextBox.Text = Reader.GetString(0);
                        if (!Reader.IsDBNull(1))
                            BackupPathTextBox.Text = Reader.GetString(1);
                        if (!Reader.IsDBNull(2))
                            comboBox1.Text = Convert.ToString(Reader.GetInt32(2));
                    }
            }

            if (!user.ManageUsers)
            {
                PhotosPathTextBox.Enabled = false;
                BackupPathTextBox.Enabled = false;

                SaveButton.Visible = false;
                BrowseButton1.Visible = false;
                BroseButton2.Visible = false;
                comboBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[appsettings] SET 
                [PhotosPath]=@PhotosPath ,[BackupPath]=@BackupPath ,[BackupInterval]=@BackupInterval Where [DatabaseName]='" + Settings1.Default.DatabaseName + "'", Connection);
                
                Command.Parameters.Add("@PhotosPath", SqlDbType.NVarChar).Value = PhotosPathTextBox.Text;
                Command.Parameters.Add("@BackupPath", SqlDbType.NVarChar).Value = BackupPathTextBox.Text;
                Command.Parameters.Add("@BackupInterval", SqlDbType.Int).Value = Convert.ToInt32(comboBox1.Text);

                Command.ExecuteNonQuery();
                Command.Parameters.Clear();
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowNewFolderButton = true;
            fd.Description = " الرجاء تحديد مجلد الصور :";
            fd.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult resualt = fd.ShowDialog();
            if (resualt == System.Windows.Forms.DialogResult.OK)
                PhotosPathTextBox.Text = fd.SelectedPath;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowNewFolderButton = true;
            fd.Description = " الرجاء تحديد مجلد النسخ الاحتياطي :";
            fd.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult resualt = fd.ShowDialog();
            if (resualt == System.Windows.Forms.DialogResult.OK)
                BackupPathTextBox.Text = fd.SelectedPath;
        }



    }
}
