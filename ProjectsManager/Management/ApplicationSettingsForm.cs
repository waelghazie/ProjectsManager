using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Win32;

namespace ProjectsManager
{
    public partial class ApplicationSettingsForm : Form
    {
        public ApplicationSettingsForm()
        {
            InitializeComponent();
        }

        public bool SuccessConnect = false;

        DataTable DatabasesTable;
        List<string> ServersList;
        bool AreServersListed = false;
        bool AreDatabasesListed = false;
        
        private void ApplicationSettingsForm_Load(object sender, EventArgs e)
        {
            ServersList = new List<string>();

            ServerComboBox.Text = Settings1.Default.SQLServer;
            DatabaseComboBox.Text = Settings1.Default.DatabaseName;
            UserNameTextBox.Text = Settings1.Default.ServerUser;
            PassTextBox.Text = Settings1.Default.SqlPassword;
            TimeoutTextBox.Text = Convert.ToString(Settings1.Default.ServerConnectTimeout);
            BackupTimerTextBox.Text = Convert.ToString(Settings1.Default.BackupTimer);
            ReminderTimerTextBox.Text = Convert.ToString(Settings1.Default.ReminderTimer);
            
            if (Settings1.Default.LoginAsADUser)
                DomainAuthRadioButton.Checked = true;
            else
                ApplicationRadioButton.Checked = true;
            
            DatabasesTable = new DataTable();

            ProgressBar1.Style = ProgressBarStyle.Marquee;
            ProgressBar1.MarqueeAnimationSpeed = 30;
            ProgressBar1.Visible = false;
            label11.ForeColor = Color.White;
            DeveloperOptionsGroupBox.Visible = false;
        }

        private bool TryToConnectToDatabase()
        {
            if (ServerComboBox.Text != "" && DatabaseComboBox.Text != "" && UserNameTextBox.Text != "" && PassTextBox.Text != "")
            {
                try
                {
                    using (SqlConnection Connection = new SqlConnection(@"Data Source=" + ServerComboBox.Text + ";Initial Catalog=" + DatabaseComboBox.Text + ";User ID=" + UserNameTextBox.Text + ";Password=" + PassTextBox.Text + ";Connect Timeout=" + TimeoutTextBox.Text))
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TryToConnectToDatabase())
            {
                Settings1.Default.SQLServer = ServerComboBox.Text;
                Settings1.Default.DatabaseName = DatabaseComboBox.Text;
                Settings1.Default.ServerUser = UserNameTextBox.Text;
                Settings1.Default.SqlPassword = PassTextBox.Text;
                Settings1.Default.ServerConnectTimeout = Convert.ToInt32(TimeoutTextBox.Text);
                Settings1.Default.LoginAsADUser = DomainAuthRadioButton.Checked;
                Settings1.Default.BackupTimer = Convert.ToInt32(BackupTimerTextBox.Text);
                Settings1.Default.ReminderTimer = Convert.ToInt32(ReminderTimerTextBox.Text);

                if (DeveloperOptionsGroupBox.Visible)
                {
                    Settings1.Default.AutoLogin = checkBox2.Checked;

                    if (CheckOS32or64.IsOS64Bit())
                    {
                        using (RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\" + Settings1.Default.ApplicationManufacturer + "\\Settings", true))
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

                Settings1.Default.Save();
                SuccessConnect = true;
                this.Close();
            }
        }

        private void TryButton_Click(object sender, EventArgs e)
        {
            TryToConnectToDatabase();
        }

        private void TimeoutTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Get a list of Databases
        /// </summary>
        private void DatabaseComboBox_DropDown(object sender, EventArgs e)
        {
            if (!AreDatabasesListed)
            {
                using (SqlConnection Connection = new SqlConnection(@"Data Source=" + ServerComboBox.Text + ";User ID=" + UserNameTextBox.Text + ";Password=" + PassTextBox.Text + ";Connect Timeout=" + TimeoutTextBox.Text))
                {
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("SELECT name FROM master.sys.databases", Connection);
                        Adapter.Fill(DatabasesTable);
                        DatabaseComboBox.DisplayMember = "name";
                        DatabaseComboBox.DataSource = DatabasesTable;
                        AreDatabasesListed = true;

                    }
                    catch (Exception exp)
                    { MessageBox.Show(exp.Message); }
                }
            }
        }

        /// <summary>
        //   Get list of servers
        /// </summary>
        private void ServerComboBox_DropDown(object sender, EventArgs e)
        {
            if (!AreServersListed)
            {
                ProgressBar1.Visible = true;
                if (!ListServersBGW.IsBusy)
                {
                    ListServersBGW.RunWorkerAsync();
                    SaveButton.Visible = false;
                    TryConnectButton.Visible = false;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListServersBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable DT = instance.GetDataSources();

            foreach (DataRow server in DT.Rows)
            {
                ServersList.Add(server[DT.Columns["ServerName"]].ToString());
            }
            AreServersListed = true;
        }

        private void ListServersBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ServerComboBox.DataSource = ServersList;
            ProgressBar1.Visible = false;
            SaveButton.Visible = true;
            TryConnectButton.Visible = true;
        }

        private void DeveloperOptionsLabel_DoubleClick(object sender, EventArgs e)
        {
            DeveloperOptionsGroupBox.Visible = true;
        }

        private void ResetSettingsButton_Click(object sender, EventArgs e)
        {
            Settings1.Default.Reset();
            Settings1.Default.Save();
            MessageBox.Show("Settings Reset is done");

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
}
