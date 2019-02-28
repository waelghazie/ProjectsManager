using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Diagnostics;
using Microsoft.Win32;


namespace ProjectsManager
{
    public partial class ApplicationWizardForm : Form
    {
        public ApplicationWizardForm()
        {
            InitializeComponent();
        }

        Server Server;
        
        string script;
        bool AreServersListed = false;
        public bool SuccessDBCreation = false;
        public bool SuccessDBConnect = false;
        bool DatabasesListed = false;
        string SelectedServer, SelectedDB;

        SqlDataSourceEnumerator instance;
        DataTable ServersDatatable, DatabasesDatatable;

        private void ApplicationWizardForm_Load(object sender, EventArgs e)
        {
            ServersDatatable = new DataTable();
            DatabasesDatatable = new DataTable();

            PreviousButton.Visible = false;

            ProgressBar1.Visible = false;
            ProgressBar1.Style = ProgressBarStyle.Marquee;
            ProgressBar1.MarqueeAnimationSpeed = 30;

            instance = SqlDataSourceEnumerator.Instance;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = false;
            else
            { e.Handled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DontShowAgainCheckBox.Checked)
                ModifyRegistry();
            Close();
        }

        private void CreateDatabaseBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            using (SqlConnection Connection = new SqlConnection(@"Data Source=" + SelectedServer + ";Initial Catalog=master;User ID=" + UsernameCreateTextBox.Text + ";Password=" + PasswordCreateTextBox.Text + ";Connect Timeout=" + Convert.ToInt32(TimeOutTextBox.Text)))
            {
                try
                {
                    Connection.Open();
                    Server = new Server(new ServerConnection(Connection));

                    script = Properties.Resources.DB_script.ToString();
                    script = script.Replace("Param1", SelectedDB);
                    script = script.Replace("Param2", PathCreateTextBox.Text);

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

                    SqlCommand Command = new SqlCommand(@"INSERT INTO [" + SelectedDB + @"].[dbo].[users]
                    ([displayname],[username],[password],[read],[modify],[create]
                    ,[delete],[ManageUsers],[isdomainuser])
                    VALUES ('System Administrator','admin','" + Encryption.Encrypt("0000") + "',1,1,1,1,1,0)", Connection);
                    Command.ExecuteNonQuery();
                    //toolStripStatusLabel1.Text = "تم إنشاء حساب المدير ";

                    Command.CommandText = @"INSERT INTO [" + SelectedDB + @"].[dbo].[appsettings] ([DatabaseName],[BackupInterval]) VALUES ('" + DatabaseCreateTextBox.Text + "',2)";
                    Command.ExecuteNonQuery();
                    //toolStripStatusLabel1.Text = "تم إنشاء سجل اعدادات البرنامج";

                    SuccessDBCreation = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message + "\n" + exp.InnerException, "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateDatabaseBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar1.Visible = false;
            NextButton.Visible = true;

            if (SuccessDBCreation)
            {
                PreviousButton.Visible = false;
                tablessControl.SelectedIndex = 4;
            }
            else
            {
                ExitButton.Enabled = true;
            }
        }

        private void GetServersBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            ServersDatatable = instance.GetDataSources();
            AreServersListed = true;
        }

        private void GetServersBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (DataRow server in ServersDatatable.Rows)
            {
                ServerCreateComboBox.Items.Add(server[ServersDatatable.Columns["ServerName"]].ToString());
                ServerConnectComboBox.Items.Add(server[ServersDatatable.Columns["ServerName"]].ToString());
            }
            ProgressBar1.Visible = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            switch (tablessControl.SelectedIndex)
            {
                case 0: //welcome
                    PreviousButton.Visible = true;
                    tablessControl.SelectedIndex = 1;
                    break;
                case 1: //choose
                    if (CreateRadioButton.Checked)
                        tablessControl.SelectedIndex = 2;
                    else if (ConnectRadioButton.Checked)
                        tablessControl.SelectedIndex = 5;
                    break;
                case 2:         //create1
                    if (SQLexprRadioButton.Checked)
                    {
                        
                        ServerCreateComboBox.Text = SystemInformation.ComputerName + @"\SQLEXPRESS2012";
                        if (!CheckOS32or64.IsOS64Bit())
                            PathCreateTextBox.Text = @"C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\DATA";
                        else if (CheckOS32or64.IsOS64Bit())
                            PathCreateTextBox.Text = @"C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\DATA";
                        UsernameCreateTextBox.Text = @"sa";
                        PasswordCreateTextBox.Text = Settings1.Default.SqlPassword;
                        tablessControl.SelectedIndex = 3;
                        DatabaseCreateTextBox.Focus();
                    }
                    else if (SQLRadioButton.Checked)
                    {

                        ServerCreateComboBox.Text = @"";
                        PathCreateTextBox.Text = @"";
                        UsernameCreateTextBox.Text = @"";
                        PasswordCreateTextBox.Text = @"";
                        tablessControl.SelectedIndex = 3;
                    }
                    break;
                case 3:         //Create database
                    if (DatabaseCreateTextBox.Text == "" || ServerCreateComboBox.Text == "" || UsernameCreateTextBox.Text == "" || PasswordCreateTextBox.Text == "" || TimeOutTextBox.Text == "" || PathCreateTextBox.Text == "")
                        MessageBox.Show("الرجاء تحديد كافة البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NextButton.Visible = false;
                        PreviousButton.Visible = false;
                        ExitButton.Enabled = false;

                        ProgressBar1.Visible = true;
                        SelectedServer = ServerCreateComboBox.Text;
                        SelectedDB = DatabaseCreateTextBox.Text;

                        CreateDatabaseBGW.RunWorkerAsync();   //create Database in another thread
                    }
                    break;
                case 4:         //Choose backup folder
                    if (System.IO.Directory.Exists(BackupPathTextBox.Text))
                        tablessControl.SelectedIndex = 7;

                    break;
                case 5:          //Conenct to existing Database
                    if (TryToConnectToDB())
                    {
                        SuccessDBConnect = true;
                        tablessControl.SelectedIndex = 6;
                        PreviousButton.Visible = false;
                    }
                    break;

                case 6: //option 
                    if (LoginAsADuserRadioButton.Checked || AppLoginRadioButton.Checked)
                    {
                        tablessControl.SelectedIndex = 7;
                        NextButton.Text = "إنهاء";
                        if (SuccessDBCreation)
                            SuccessLabel.Text = "تم إنشاء قاعدة البيانات بنجاح " + DatabaseCreateTextBox.Text + "\n يرجى تعيين الاعدادات الخاصة" + "\n" + "ستتم اعادة تشغيل البرنامج";
                        if (SuccessDBConnect)
                            SuccessLabel.Text = "تم الاتصال بنجاح مع قاعدة البيانات";
                    }
                    break;

                case 7: //success
                    if (SuccessDBCreation)    //Restart Application
                    {
                        Settings1.Default.SQLServer = ServerCreateComboBox.Text;
                        Settings1.Default.DatabaseName = DatabaseCreateTextBox.Text;
                        Settings1.Default.ServerUser = UsernameCreateTextBox.Text;
                        Settings1.Default.SqlPassword = PasswordCreateTextBox.Text;
                        Settings1.Default.ServerConnectTimeout = 15;
                        Settings1.Default.LoginAsADUser = LoginAsADuserRadioButton.Checked;
                        
                        Settings1.Default.Save();

                        using (SqlConnection Connection = AppConnection.GetConnection())
                        {
                            Connection.Open();
                            SqlCommand Command = new SqlCommand(@"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[appsettings] SET 
                            [BackupPath]=@BackupPath where [DatabaseName]='" + Settings1.Default.DatabaseName + "'", Connection);
                            Command.Parameters.Add("@BackupPath", SqlDbType.NVarChar).Value = BackupPathTextBox.Text;

                            Command.ExecuteNonQuery();
                            Command.Parameters.Clear();
                        }

                        ModifyRegistry();

                        ProcessStartInfo Info = new ProcessStartInfo();
                        Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                        Info.WindowStyle = ProcessWindowStyle.Hidden;
                        Info.CreateNoWindow = true;
                        Info.FileName = "cmd.exe";
                        Process.Start(Info);
                        Application.Exit();
                    }
                    else if (SuccessDBConnect)
                    {
                        Settings1.Default.SQLServer = ServerConnectComboBox.Text;
                        Settings1.Default.DatabaseName = DatabaseConnectComboBox.Text;
                        Settings1.Default.ServerUser = UsernameConnectTextBox.Text;
                        Settings1.Default.SqlPassword = PasswordConnectTextBox.Text;
                        Settings1.Default.ServerConnectTimeout = 15;
                        Settings1.Default.LoginAsADUser = LoginAsADuserRadioButton.Checked;
                        Settings1.Default.Save();

                        ModifyRegistry();

                        Close();
                    }
                    break;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            switch (tablessControl.SelectedIndex)
            {
                case 0: break;
                case 1: tablessControl.SelectedIndex = 0; PreviousButton.Visible = false; break;
                case 2: tablessControl.SelectedIndex = 1; break;
                case 3: tablessControl.SelectedIndex = 2; break;
                case 5: tablessControl.SelectedIndex = 1; break;
            }
        }

        private void ModifyRegistry()       //Write "1" in \HKEY_LOCAL_MACHINE\SOFTWARE\ApplicationManufacturer\Settings\FirstRun 
        {
            if (CheckOS32or64.IsOS64Bit())
            {
                using (RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\" + Settings1.Default.ApplicationManufacturer + "\\Settings", true))
                    if (myKey != null)
                        myKey.SetValue("FirstRun", "0", RegistryValueKind.String);
            }
            else if (!CheckOS32or64.IsOS64Bit())
            {
                using (RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\" + Settings1.Default.ApplicationManufacturer + "\\Settings", true))
                    if (myKey != null)
                        myKey.SetValue("FirstRun", "0", RegistryValueKind.String);
            }
        }


        private bool TryToConnectToDB()
        {
            if (ServerConnectComboBox.Text != "" && DatabaseConnectComboBox.Text != "" && UsernameConnectTextBox.Text != "" && PasswordConnectTextBox.Text != "")
            {
                try
                {
                    using (SqlConnection Connection = new SqlConnection(@"Data Source=" + ServerConnectComboBox.Text + ";Initial Catalog=" + DatabaseConnectComboBox.Text + ";User ID=" + UsernameConnectTextBox.Text + ";Password=" + PasswordConnectTextBox.Text + ";Connect Timeout=15"))
                    {
                        Connection.Open();
                        if (Connection.State == ConnectionState.Open)
                            MessageBox.Show("تم الاتصال مع قاعدة البيانات بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message + "\n يرجى التأكد من صحة الاعدادات وأيضا التأكد من عمل مخدم قاعدة البيانات", "لم يتم الاتصال بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TryToConnectToDB();
        }

        private void ServerConnectComboBox_DropDown(object sender, EventArgs e)            //get list of servers
        {
            if (!AreServersListed)
            {
                ProgressBar1.Visible = true;
                if (!GetServersBGW.IsBusy)
                    GetServersBGW.RunWorkerAsync();
            }
        }

        private void ServerCreateComboBox_DropDown(object sender, EventArgs e)            //get list of servers
        {
            if (!AreServersListed)
            {
                ProgressBar1.Visible = true;
                if (!GetServersBGW.IsBusy)
                    GetServersBGW.RunWorkerAsync();
            }
        }

        private void DatabaseConnectComboBox_DropDown(object sender, EventArgs e)
        {
            if (!DatabasesListed)
            {
                using (SqlConnection Connection = new SqlConnection(@"Data Source=" + ServerConnectComboBox.Text + ";User ID=" + UsernameConnectTextBox.Text + ";Password=" + PasswordConnectTextBox.Text + ";Connect Timeout=15"))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("SELECT name FROM master.sys.databases", Connection);
                        Adapter.Fill(DatabasesDatatable);
                        DatabaseConnectComboBox.DisplayMember = "name";
                        DatabaseConnectComboBox.DataSource = DatabasesDatatable;
                        DatabasesListed = true;

                    }
                    catch (Exception exp)
                    { MessageBox.Show(exp.Message); }
                }
            }
        }

        private void BackupPathButton_Click(object sender, EventArgs e)
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
