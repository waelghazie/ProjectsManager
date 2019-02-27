using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectsManager
{
    public partial class EnterServiceTextForVisit : Form
    {

        public EnterServiceTextForVisit(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        User user;

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
                if (FindVisit())
                    Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool FindVisit()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                int VisitID = 0;
                int PlantID =0 ;
                Connection.Open();

                SqlCommand Command = new SqlCommand(@"SELECT [VisitID],[PlantID] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PlantServiceView] where [VisitID]=" + Convert.ToInt32(maskedTextBox1.Text), Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        VisitID = Reader.GetInt32(0);
                        PlantID = Reader.GetInt32(1);
                    }

                    PlantForm OpenPlantForm = new PlantForm(PlantID, user, 2, VisitID);
                    OpenPlantForm.Show();

                    return true;
                }
                else if (!Reader.HasRows)
                {
                    NotifyMessage nm = new NotifyMessage("لم يتم العثور على وحدة المعالجة المرتبطة", NotifyMessage.NotifyMessageIcon.Error);
                    nm.Show();
                    return false;
                }
            }
            return false;
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (maskedTextBox1.Text != "")
                    if (FindVisit())
                        Close();
        }

        private void EnterServiceTextForVisit_Shown(object sender, EventArgs e)
        {
            maskedTextBox1.Focus();
        }


    }
}
