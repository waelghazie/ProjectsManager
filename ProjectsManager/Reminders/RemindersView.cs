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
    public partial class RemindersViewForm : Form
    {
        DataTable Data;
        User user;

        public RemindersViewForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void RemindersView_Load(object sender, EventArgs e)
        {
            Data = new DataTable();
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id] as [#],[Title] as [العنوان],[Text],[TimeStamp] as [وقت الارسال],[TargetTime] as [الوقت الهدف],[Importance] as [الأهمية],[Dismiss]  as [تم إنهائه؟]
                ,[FromUserName] as [أرسل من قبل المستخدم],[CustomerName],[InstituteName],[PlantName]
                FROM [" + Settings1.Default.DatabaseName + "].[dbo].[RemindersView] where [ToUserID]=" + user.UserID, Connection);
                
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(Data);
                dataGridView1.DataSource = Data;

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex > 0)
            {
                TitleTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                ReminderTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                SendTimeTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                TargetTimeTextBox.Text = dataGridView1.SelectedCells[4].Value.ToString();
                switch (dataGridView1.SelectedCells[5].Value.ToString())
                {
                    case "1": PriorityLabel.Text = "أهمية عادية"; break;
                    case "2": PriorityLabel.Text = "أهمية متوسطة"; break;
                    case "3": PriorityLabel.Text = "أهمية عالية"; break;
                }
                SendByUserTextBox.Text = dataGridView1.SelectedCells[4].Value.ToString();
                CustomerTextBox.Text = dataGridView1.SelectedCells[8].Value.ToString() + " - " + dataGridView1.SelectedCells[9].Value.ToString() + " - " + dataGridView1.SelectedCells[10].Value.ToString();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
