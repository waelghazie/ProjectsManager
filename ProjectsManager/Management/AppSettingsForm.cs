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
    public partial class AppSettingsForm : Form
    {
        public AppSettingsForm()
        {
            InitializeComponent();
        }

        DataTable DatabasesTable;
        List<string> ServersList;

        bool ServersListed = false;
        bool DatabasesListed = false;

        public bool SuccessConnect = false;

        private void Form2_Load(object sender, EventArgs e)
        {
            ServersList = new List<string>();

            ServerComboBox.Text = Settings1.Default.SQLServer;
            DatabaseComboBox.Text = Settings1.Default.DatabaseName;
            UserNameTextBox.Text = Settings1.Default.ServerUser;
            PassTextBox.Text = Encryption.Decrypt(Settings1.Default.ServerPassword);
            TimeoutTextBox.Text = Convert.ToString(Settings1.Default.ServerConnectTimeout);
            textBox4.Text = Convert.ToString(Settings1.Default.BackupTimer);
            textBox3.Text = Convert.ToString(Settings1.Default.ReminderTimer);
            
            if (Settings1.Default.LoginAsADUser)
                LoginAsADuserRadioButton.Checked = true;
            else
                radioButton4.Checked = true;

            
            DatabasesTable = new DataTable();

            ProgressBar1.Style = ProgressBarStyle.Marquee;
            ProgressBar1.MarqueeAnimationSpeed = 30;
            ProgressBar1.Visible = false;
            label11.ForeColor = Color.White;
            groupBox3.Visible = false;
        }

        private bool TryToConnectToDB()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (TryToConnectToDB())
            {
                Settings1.Default.SQLServer = ServerComboBox.Text;
                Settings1.Default.DatabaseName = DatabaseComboBox.Text;
                Settings1.Default.ServerUser = UserNameTextBox.Text;
                Settings1.Default.ServerPassword = Encryption.Encrypt(PassTextBox.Text);
                Settings1.Default.ServerConnectTimeout = Convert.ToInt32(TimeoutTextBox.Text);
                Settings1.Default.LoginAsADUser = LoginAsADuserRadioButton.Checked;
                Settings1.Default.BackupTimer = Convert.ToInt32(textBox4.Text);
                Settings1.Default.ReminderTimer = Convert.ToInt32(textBox3.Text);

                if (groupBox3.Visible)
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

        private void button2_Click(object sender, EventArgs e)
        {
            //try connection button
            TryToConnectToDB();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DatabaseComboBox_DropDown(object sender, EventArgs e)
        {
            //get a list of Databases

            if (!DatabasesListed)
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
                        DatabasesListed = true;

                    }
                    catch (Exception exp)
                    { MessageBox.Show(exp.Message); }
                }
            }

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            //get list of servers

            if (!ServersListed)
            {
                ProgressBar1.Visible = true;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                    button1.Visible = false;
                    button2.Visible = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable DT = instance.GetDataSources();

            foreach (DataRow server in DT.Rows)
            {
                ServersList.Add(server[DT.Columns["ServerName"]].ToString());
            }
            ServersListed = true;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ServerComboBox.DataSource = ServersList;
            ProgressBar1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void label11_DoubleClick(object sender, EventArgs e)
        {
            groupBox3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
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
