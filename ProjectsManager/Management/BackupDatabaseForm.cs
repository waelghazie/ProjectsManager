using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjectsManager
{
    public partial class BackupDatabaseForm : Form
    {
        public BackupDatabaseForm()
        {
            InitializeComponent();
        }
        
        bool BackupIsDone = false;

        private void BackupDatabaseForm_Load(object sender, EventArgs e)
        {
            ServerTextBox.Text = Settings1.Default.SQLServer;
            DatabaseTextBox.Text = Settings1.Default.DatabaseName;
            PathTextBox.Text = Settings1.Default.BackupFolder;
            
            ProgressBar1.Style = ProgressBarStyle.Marquee;
            ProgressBar1.MarqueeAnimationSpeed = 30;
            ProgressBar1.Visible = false;

            StatusLabel.Visible = false;

            if (Settings1.Default.BackupFolder == "")
            {
                StatusLabel.Visible = true;
                StatusLabel.Text = "يرجى تعيين مسار النسخ الاحتياطي ضمن الاعدادات!";
                StartButton.Enabled = false;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (FileNameTextBox.Text == "" || PathTextBox.Text =="")
                MessageBox.Show("الرجاء إدخال اسم الملف ومسار النسخ الاحتياطي", "تنبيه", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                ProgressBar1.Visible = true;
                StartButton.Enabled = false;
                CreateBackupBGW.RunWorkerAsync();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateBackupBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                try
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand(@"BACKUP DATABASE [" + Settings1.Default.DatabaseName + "] " +
                        "TO  DISK = N'" + PathTextBox.Text + "\\" + FileNameTextBox.Text + 
                        ".bak' WITH NOFORMAT, NOINIT,  NAME = N'myBackup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10, CHECKSUM"
                        , Connection);
                    Command.ExecuteNonQuery();
                    BackupIsDone = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message + "\n" + exp.InnerException, "حدث خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateBackupBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (BackupIsDone)
            {
                MessageBox.Show("تمت العملية بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProgressBar1.Visible = false;
            }
            StartButton.Enabled = true;
        }

    }
}
