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
    public partial class CallWindow : Form
    {

        /// <summary>
        /// New Call Window
        /// </summary>
        /// <param name="user"></param>
        public CallWindow(User user)
        {
            this.user = user;
            this.NewCallWindow = true;
            InitializeComponent();
        }
        /// <summary>
        /// Open Saved Call record
        /// </summary>
        /// <param name="user"></param>
        /// <param name="CallID"></param>
        public CallWindow(User user, int CallID)
        {
            this.user = user;
            this.CallID = CallID;
            NewCallWindow = false;
            InitializeComponent();
        }

        bool NewCallWindow;
        int CallID;
        User user;
        bool ChangesSaved = false;

        Dictionary<int, string> CustomersDic = new Dictionary<int, string>();
        Dictionary<int, string> InstitutesDic = new Dictionary<int, string>();
        Dictionary<int, string> PlantsDic = new Dictionary<int, string>();

        private void CallWindow_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand("", Connection);

                if (NewCallWindow)
                {
                    dateTimePicker1.Value = DateTime.Now;
                    this.Text = "تسجيل اتصال جديد";
                    ByUserLabel.Text = user.DisplayName;
                    label3.Visible = false;
                    dateTimePicker2.Visible = false;
                }
                else if (!NewCallWindow)
                {
                    Command.CommandText = @"SELECT [TimeStamp],[CustomerID],[InstituteID],[PlantID],[Text],[ByUserName],[AddTime]
                    FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PhoneCallsLogView] where [id]=" + CallID;
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                        {
                            if (!Reader.IsDBNull(0))
                                dateTimePicker1.Value = Reader.GetDateTime(0);
                            if (!Reader.IsDBNull(1))
                                plantChoose1.CustomersComboBox.SelectedValue = Reader.GetInt32(1);
                            if (!Reader.IsDBNull(2))
                                plantChoose1.InstituteComboBox.SelectedValue = Reader.GetInt32(2);
                            if (!Reader.IsDBNull(3))
                                plantChoose1.PlantComboBox.SelectedValue = Reader.GetInt32(3);
                            if (!Reader.IsDBNull(4))
                                CallTextBox.Text = Reader.GetString(4);
                            if (!Reader.IsDBNull(5))
                                ByUserLabel.Text = Reader.GetString(5);
                            if (!Reader.IsDBNull(6))
                                dateTimePicker1.Value = Reader.GetDateTime(6);
                        }
                    Reader.Close();

                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;

                    plantChoose1.Enabled = false;
                    CallTextBox.ReadOnly = true;
                    this.Text = "اتصال";
                    SaveButton.Visible = false;
                }
            }
            VerifyUserPermissions();
        }

        private void VerifyUserPermissions()
        {
            if (user.ReadPermission)
            { CallTextBox.ReadOnly = false; }
            else
            { CallTextBox.ReadOnly = true;  }
            if (user.ModifyPermission)
            { ScheduleLinkLabel.Visible = true; }
            else
            { ScheduleLinkLabel.Visible = false; plantChoose1.Enabled = false; }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (SaveChanges())
                Close();
        }

        private bool SaveChanges()
        {
            if (!plantChoose1.SuccessChoose || CallTextBox.Text == "")
            {
                NotifyMessage nm = new NotifyMessage("يرجى تعبئة الحقول الناقصة", NotifyMessage.NotifyMessageIcon.Error);
                nm.Show();

                Asterisk3.Visible = true;
                Asterisk4.Visible = true;
                return false;
            }
            else
            {
                if (plantChoose1.IsDataOK())
                    using (SqlConnection Connection = AppConnection.GetConnection())
                    {
                        Connection.Open();
                        SqlCommand Command = new SqlCommand(@"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[PhoneCallsLog] 
                        ([TimeStamp],[CustomerID],[InstituteID],[PlantID],[Text],[ByUser],[AddTime]) VALUES 
                        (@TimeStamp,@CustomerID,@InstituteID,@PlantID,@Text,@ByUser,convert(datetime,getdate(),102))", Connection);

                        Command.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"));
                        Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = plantChoose1.CustomerID;
                        Command.Parameters.Add("@InstituteID", SqlDbType.Int).Value = plantChoose1.InstituteID;
                        Command.Parameters.Add("@PlantID", SqlDbType.Int).Value = plantChoose1.PlantID;
                        Command.Parameters.Add("@Text", SqlDbType.NVarChar).Value = CallTextBox.Text;
                        Command.Parameters.Add("@ByUser", SqlDbType.Int).Value = user.UserID;

                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                        ChangesSaved = true;

                        return true;
                    }
                else
                    return false;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (NewCallWindow)
            {
                if (!ChangesSaved)
                {
                    DialogResult DR = MessageBox.Show("هل ترغب بحفظ المعلومات في هذه النافذة؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        SaveChanges();
                        if (ChangesSaved)
                        { groupBox1.Visible = true; }
                    }
                }
                else if (ChangesSaved)
                { groupBox1.Visible = true; }
            }
            else if (!NewCallWindow)
            { groupBox1.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Set plant into active appointments
            if (plantChoose1.IsDataOK())
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand(@"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] SET 
                    [start_time]=convert(datetime,getdate(),102),[end_time]=@end_time where [id]=" + plantChoose1.PlantID, Connection);

                    Command.Parameters.Add("@end_time", SqlDbType.DateTime).Value = DateTime.Now.AddDays(Convert.ToDouble(DaysComboBox.Text));
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();

                    NotifyMessage nw = new NotifyMessage("تم التعيين ضمن المواعيد المجدولة", NotifyMessage.NotifyMessageIcon.Info);
                    nw.Show();
                }
        }



    }
}
