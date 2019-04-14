using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Diagnostics;

namespace ProjectsManager
{
    public partial class CreateDatabaseForm : Form
    {
        public CreateDatabaseForm()
        {
            InitializeComponent();
        }

        Server Server;
        SqlConnection SqlConnection;
        SqlCommand Command;
        string Script;
        bool AreServersListed = false;
        bool IsDatabaseCreatedSuccessfully = false;
        string SelectedServer, SelectedDatabase;

        SqlDataSourceEnumerator Instance;
        DataTable dataTable;

        private void CreateDatabaseForm_Load(object sender, EventArgs e)
        {
            StatusLabel.Text = "جاهز";

            ProgressBar.Visible = false;
            ProgressBar.Style = ProgressBarStyle.Marquee;
            ProgressBar.MarqueeAnimationSpeed = 30;

            Instance = SqlDataSourceEnumerator.Instance;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (DatabaseTextBox.Text == "" || ServerComboBox.Text == "" || UsernameTextBox.Text == "" || PasswordTextBox.Text == "" || TimeOutTextBox.Text == "" || PathTextBox.Text == "")
                MessageBox.Show("الرجاء تحديد كافة البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                StatusLabel.Text = "يرجى الانتظار";
                StartButton.Enabled = false;
                CloseButton.Enabled = false;
                ProgressBar.Visible = true;
                SelectedServer = ServerComboBox.Text;
                SelectedDatabase = DatabaseTextBox.Text;

                CreateNewDatabase();
            }   
        }

        private void CreateNewDatabase()
        {
              CreateDatabaseBGW.RunWorkerAsync();
        }

        private void  ServerComboBox_DropDown(object sender, EventArgs e)
        {
            if (!AreServersListed)
            { 
                ProgressBar.Visible = true;
                StatusLabel.Text = "جاري احضار قائمة المخدمات";
                GetServerBGW.RunWorkerAsync();
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateDatabaseBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SqlConnection = new SqlConnection();
                SqlConnection.ConnectionString = @"Data Source=" + SelectedServer + ";Initial Catalog=master;User ID=" + UsernameTextBox.Text + ";Password=" + PasswordTextBox.Text + ";Connect Timeout=" + Convert.ToInt32(TimeOutTextBox.Text);
                SqlConnection.Open();

                Server = new Server(new ServerConnection(SqlConnection));
                
                Script = Properties.Resources.DB_script.ToString();
                Script = Script.Replace("Param1", SelectedDatabase);
                Script = Script.Replace("Param2", PathTextBox.Text);
                Server.ConnectionContext.ExecuteNonQuery(Script);

                Script = Properties.Resources.Tables_script.ToString();
                Script = Script.Replace("Param1", SelectedDatabase);
                Server.ConnectionContext.ExecuteNonQuery(Script);

                Script = Properties.Resources.Views_script.ToString();
                Script = Script.Replace("Param1", SelectedDatabase);
                Server.ConnectionContext.ExecuteNonQuery(Script);

                Command = new SqlCommand(@"INSERT INTO [" + SelectedDatabase + @"].[dbo].[users]
                    ([displayname],[username],[password],[read],[modify],[create]
                    ,[delete],[ManageUsers],[isdomainuser])
                    VALUES ('System Administrator','admin','" + Encryption.Encrypt("0000") + "',1,1,1,1,1,0)", SqlConnection);
                Command.ExecuteNonQuery();

                Command.CommandText = @"INSERT INTO [" + SelectedDatabase + @"].[dbo].[appsettings] ([DatabaseName],[BackupInterval]) VALUES ('" + DatabaseTextBox.Text + "',2)";
                Command.ExecuteNonQuery();

                Settings1.Default.SQLServer = SelectedServer;
                Settings1.Default.ServerUser = UsernameTextBox.Text;
                Settings1.Default.SqlPassword = PasswordTextBox.Text;
                Settings1.Default.ReportsFolder = "";
                Settings1.Default.BackupFolder = "";
                Settings1.Default.DatabaseName = SelectedDatabase;
                Settings1.Default.ApplicationUsername = "";
                Settings1.Default.ApplicationPassword = "";
                Settings1.Default.PhotosPath = "";
                Settings1.Default.Save();

                IsDatabaseCreatedSuccessfully = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "\n" + exp.InnerException, "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateDatabaseBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Visible = false;
            if (SqlConnection.State == ConnectionState.Open)
                SqlConnection.Close();
            StatusLabel.Text = "تم";

            StartButton.Enabled = true;
            CloseButton.Enabled = true;

            if (IsDatabaseCreatedSuccessfully)
            {
                StartButton.Enabled = true; 
                CloseButton.Enabled = true;
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

        private void GetServersBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            dataTable = Instance.GetDataSources();
            AreServersListed = true;
        }

        private void GetServersBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (DataRow server in dataTable.Rows)
                ServerComboBox.Items.Add(server[dataTable.Columns["ServerName"]].ToString());
            
            ProgressBar.Visible = false;
            StatusLabel.Text = "جاهز";
        }


    }
}
