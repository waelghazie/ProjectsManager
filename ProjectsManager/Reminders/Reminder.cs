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
using System.Diagnostics;

namespace ProjectsManager
{
    [DebuggerStepThrough]
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
        }

        public Reminder(int ReminderID)
        {
            this.ReminderID = ReminderID;
            InitializeComponent();
        }
        
        SqlDataReader Reader;

        int ReminderID;
        DateTime TimeStamp;
        DateTime TargetTime;

        bool Dismiss = false;
        private int YLocation = 0;
        private int XLocation = 0;

        private void Reminder_Load(object sender, EventArgs e)
        {
            XLocation = Screen.FromControl(this).Bounds.Width - this.Width - 10;
            YLocation = Screen.FromControl(this).Bounds.Height;
            SetDesktopLocation(XLocation, YLocation);
            this.Opacity = 0;

            using (SqlConnection Connection = AppConnection.GetConnection())
            {

                Connection.Open();
                //جلب معلومات التنبيه حسب رقم التنبيه المرسل من النافذة الرئيسية
                SqlCommand Command = new SqlCommand(@"SELECT [Title],[Text],[TimeStamp],[TargetTime],[Importance],[FromUserName] 
                ,[InstituteName],[PlantName] 
                FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[RemindersView] WHERE [id]=" + ReminderID, Connection);
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            Title.Text = Reader.GetString(0);
                        if (!Reader.IsDBNull(1))
                            ReminderText.Text = Reader.GetString(1);
                        if (!Reader.IsDBNull(2))
                            TimeStamp = Reader.GetDateTime(2);
                        if (!Reader.IsDBNull(3))
                            TargetTime = Reader.GetDateTime(3);
                        if (!Reader.IsDBNull(4))
                        {
                            switch (Reader.GetInt32(4))
                            {
                                case 1: Priority.Text = "أهمية عادية"; break;
                                case 2: Priority.Text = "أهمية متوسطة"; break;
                                case 3: Priority.Text = "أهمية عالية"; break;
                            }
                        }
                        if (!Reader.IsDBNull(5))
                            FromUser.Text = Reader.GetString(5);
                        if (!Reader.IsDBNull(6))
                            RegardingPlant.Text = " بخصوص " + Reader.GetString(6);
                        else RegardingPlant.Text = "";
                        if (!Reader.IsDBNull(7))
                            RegardingPlant.Text += " " + Reader.GetString(7);
                        RegardingPlant.Text = ReplaceChar.ReplaceAChar(RegardingPlant.Text);
                    }
                Reader.Close();

                Dictionary<int, string> Dic = new Dictionary<int, string>();
                //Dic.Add(10000, "seconds");
                Dic.Add(120000, "2 دقيقة");
                Dic.Add(300000, "5 دقائق");
                Dic.Add(900000, "15 دقيقة");
                Dic.Add(1800000, "30 دقيقة");
                Dic.Add(3600000, "60 دقيقة");

                comboBox1.DataSource = new BindingSource(Dic, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dismiss button زر انهاء التذكير بوضع علامة انهاء عليه
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[reminders] SET [Dismiss]='True' where [id]=" + ReminderID, Connection);
                Command.ExecuteNonQuery();
                Dismiss = true;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Snooze button
            SnoozeTimer.Interval = Convert.ToInt32(comboBox1.SelectedValue);
            SnoozeTimer.Enabled = true;

            Close();
        }

        private void SnoozeTimer_Tick(object sender, EventArgs e)
        {
            //انتهاء الغفوة بمجرد عمل دورة التايمر
            
            SnoozeTimer.Enabled = false;
            ShowTimer.Enabled = true;
        }

        private void Reminder_Shown(object sender, EventArgs e)
        {
            ShowTimer.Enabled = true;
        }

        private void ShowTimer_Tick(object sender, EventArgs e)
        {
            YLocation -= 5;
            SetDesktopLocation(XLocation, YLocation);

            if (this.Opacity <= 0.8)
                this.Opacity += 0.07;
            if (YLocation <= Screen.PrimaryScreen.WorkingArea.Height - this.Height -10)
            {
                ShowTimer.Enabled = false;
            }
        }

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            YLocation += 5;
            SetDesktopLocation(XLocation, YLocation);
            

            if (YLocation >= Screen.FromControl(this).Bounds.Height)
            {
                this.Opacity = 0;
                HideTimer.Enabled = false;
            }
        }

        private void Reminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Dismiss)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
                HideTimer.Enabled = true;

            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }


    }
}
