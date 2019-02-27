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
    public partial class AddPlantToProgram : Form
    {
        public AddPlantToProgram(int CustomerID,int InstituteID, int PlantID,User user)
        {
            this.CustomerID = CustomerID;
            this.InstituteID = InstituteID;
            this.PlantID = PlantID;
            this.user = user;
            InitializeComponent();
        }

        User user;
        SqlDataReader Reader;
        Dictionary<int, string> ProgramsDic = new Dictionary<int, string>();
        int CustomerID, InstituteID, PlantID;

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProgramForm NewProgram = new ProgramForm(user);
            NewProgram.FormClosed += new FormClosedEventHandler(NewProgram_FormClosed);
            NewProgram.Show();
        }

        void NewProgram_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetPrograms();
        }

        private void AddPlantToProgram_Load(object sender, EventArgs e)
        {
            GetPrograms();
        }

        private void GetPrograms()
        {

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                ProgramsDic.Clear();
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[ProgramDate] from [" + Settings1.Default.DatabaseName + @"].[dbo].[Programs]", Connection);
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        if (!Reader.IsDBNull(0))
                            ProgramsDic.Add(Reader.GetInt32(0), Convert.ToString(Reader.GetDateTime(1).ToString("yyyy-MM-dd")));
                    comboBox1.DataSource = new BindingSource(ProgramsDic, null);
                    comboBox1.DisplayMember = "Value";
                    comboBox1.ValueMember = "Key";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VisitTextBox.Text != "" && comboBox1.SelectedValue != null)
            {
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();

                    SqlCommand Command = new SqlCommand(@"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantService]
                    ([CustomerID],[InstituteID],[PlantID],[VisitText],[VisitNote],[ProgramID]) VALUES
                    (@CustomerID,@InstituteID,@PlantID,@VisitText,@VisitNote,@ProgramID)", Connection);

                    Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID;
                    Command.Parameters.Add("@InstituteID", SqlDbType.Int).Value = InstituteID;
                    Command.Parameters.Add("@PlantID", SqlDbType.Int).Value = PlantID;
                    Command.Parameters.Add("@VisitText", SqlDbType.NVarChar).Value = VisitTextBox.Text;
                    Command.Parameters.Add("@VisitNote", SqlDbType.NVarChar).Value = VisitNoteTextBox.Text;
                    Command.Parameters.Add("@ProgramID", SqlDbType.Int).Value = comboBox1.SelectedValue;
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                    
                    NotifyMessage nw = new NotifyMessage("تمت اضافة الوحدة إلى برنامج خدمة\n" + Convert.ToString(comboBox1.Text),NotifyMessage.NotifyMessageIcon.Info);
                    nw.Show();
                    Close();
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
