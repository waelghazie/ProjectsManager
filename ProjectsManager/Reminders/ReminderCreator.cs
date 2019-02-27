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
    public partial class ReminderCreator : Form
    {
        public ReminderCreator(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        public ReminderCreator(int CustomerID, int InstituteID, int PlantID, User user)
        {
            this.CustomerID = CustomerID;
            this.InstituteID = InstituteID;
            this.PlantID = PlantID;
            this.user = user;
            InitializeComponent();
            RegardingPlantCheckBox.Checked = true;
        }

        User user;
        int CustomerID, InstituteID, PlantID;

        Dictionary<int, string> UsersDic = new Dictionary<int, string>();
        Dictionary<int, string> ImportanceDic = new Dictionary<int, string>();
        Dictionary<int, string> InstitutesDic = new Dictionary<int, string>();
        Dictionary<int, string> PlantsDic = new Dictionary<int, string>();

        private void ReminderCreator_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[displayname] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[users]", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        UsersDic.Add(Reader.GetInt32(0), Reader.GetString(1));

                    Reader.Close();
                    ToUserComboBox.DataSource = new BindingSource(UsersDic, null);
                    ToUserComboBox.DisplayMember = "Value";
                    ToUserComboBox.ValueMember = "Key";
                }

                ImportanceDic.Add(1, "عادية");
                ImportanceDic.Add(2, "متوسطة");
                ImportanceDic.Add(3, "عالية");
                PriorityComboBox.DataSource = new BindingSource(ImportanceDic, null);
                PriorityComboBox.DisplayMember = "Value";
                PriorityComboBox.ValueMember = "Key";
            }

            if (RegardingPlantCheckBox.Checked)
            {
                plantChoose1.Visible = true;
                plantChoose1.CustomersComboBox.SelectedValue = CustomerID;
                plantChoose1.InstituteComboBox.SelectedValue = InstituteID;
                plantChoose1.PlantComboBox.SelectedValue = PlantID;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save حفظ

            if (SaveData())
                Close();
        }

        private bool SaveData() //true: data is saved and its OK - false: Data not saved
        {
            if (TitleTextBox.Text == "" || ToUserComboBox.Text == "")
            {
                NotifyMessage nm = new NotifyMessage("لا يمكن الحفظ ، الرجاء التأكد من إدخال الحقول الناقصة", NotifyMessage.NotifyMessageIcon.Error);
                nm.Show();
                Asterisk1.Visible = true;
                Asterisk2.Visible = true;
                if (RegardingPlantCheckBox.Checked) Asterisk3.Visible = true;
                return false;
            }
            else
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand();
                    Command.Connection = Connection;

                    if (!RegardingPlantCheckBox.Checked)
                    {
                        Command.CommandText = @"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[reminders]
                        ([Title],[Text],[TimeStamp],[TargetTime],[FromUserID],[ToUserID],[Importance],[Dismiss]) VALUES
                        (@Title,@Text,convert(datetime,@TimeStamp,102),convert(datetime,@TargetTime,102),@FromUserID,@ToUserID,@Importance,0)";
                        Command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = TitleTextBox.Text;
                        Command.Parameters.Add("@Text", SqlDbType.NVarChar).Value = textBox2.Text;
                        Command.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt", new System.Globalization.CultureInfo("en-US"));
                        Command.Parameters.Add("@TargetTime", SqlDbType.DateTime).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm tt", new System.Globalization.CultureInfo("en-US"));
                        Command.Parameters.Add("@FromUserID", SqlDbType.Int).Value = user.UserID;
                        Command.Parameters.Add("@ToUserID", SqlDbType.Int).Value = ToUserComboBox.SelectedValue;
                        Command.Parameters.Add("@Importance", SqlDbType.Int).Value = PriorityComboBox.SelectedValue;
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();

                        NotifyMessage nm = new NotifyMessage("تم حفظ التذكير", NotifyMessage.NotifyMessageIcon.Saved);
                        nm.Show();
                        return true;
                    }
                    else if (RegardingPlantCheckBox.Checked)
                    {
                        if (plantChoose1.IsDataOK())
                        {
                            Command.CommandText = @"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[reminders]
                            ([Title],[Text],[TimeStamp],[TargetTime],[FromUserID],[ToUserID],[PlantId],[Importance],[Dismiss]) VALUES
                            (@Title,@Text,convert(datetime,@TimeStamp,102),convert(datetime,@TargetTime,102),@FromUserID,@ToUserID,@PlantID,@Importance,0)";
                            Command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = TitleTextBox.Text;
                            Command.Parameters.Add("@Text", SqlDbType.NVarChar).Value = textBox2.Text;
                            Command.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt", new System.Globalization.CultureInfo("en-US"));
                            Command.Parameters.Add("@TargetTime", SqlDbType.DateTime).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm tt", new System.Globalization.CultureInfo("en-US"));
                            Command.Parameters.Add("@FromUserID", SqlDbType.Int).Value = user.UserID;
                            Command.Parameters.Add("@ToUserID", SqlDbType.Int).Value = ToUserComboBox.SelectedValue;
                            Command.Parameters.Add("@PlantID", SqlDbType.Int).Value = plantChoose1.PlantID;
                            Command.Parameters.Add("@Importance", SqlDbType.Int).Value = PriorityComboBox.SelectedValue;
                            Command.ExecuteNonQuery();
                            Command.Parameters.Clear();

                            NotifyMessage nm = new NotifyMessage("تم حفظ التذكير", NotifyMessage.NotifyMessageIcon.Saved);
                            nm.Show();
                            return true;
                        }
                        else
                            return false;
                    }
                }
            return false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (RegardingPlantCheckBox.Checked)
                plantChoose1.Visible = true;
            else
                plantChoose1.Visible = false;
        }

    }
}
