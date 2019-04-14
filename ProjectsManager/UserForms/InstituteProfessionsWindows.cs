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
    public partial class InstituteProfessionsWindow : Form
    {

        public InstituteProfessionsWindow(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        DataTable Data;
        User user;

        bool NewProfession = false;

        private void CarsWindows_Load(object sender, EventArgs e)
        {
            VerifyUserPermissions();

            Data = new DataTable();

            button5.Visible = false;
            button6.Visible = false;
            
            RefreshDGV();
            LoadDatafromDGV();
        }

        private void VerifyUserPermissions()
        {
            if (user.ReadPermission)
            { }
            else
            { dataGridView1.Visible = false; button1.Visible = false; button2.Visible = false; button3.Visible = false; }
            if (user.ModifyPermission)
            { }
            else { button1.Visible = false; button2.Visible = false; button3.Visible = false; }
            if (user.DeletePermission)
            { }
            else
            { button3.Visible = false; }
        }

        private void EnableEditing()
        {
            button5.Visible = true;
            button6.Visible = true;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            textBox2.ReadOnly = false;
            textBox2.Focus();

            VerifyUserPermissions();
        }

        private void DisableEditing()
        {
            button5.Visible = false;
            button6.Visible = false;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            textBox2.ReadOnly = true;

            VerifyUserPermissions();
        }

        private void RefreshDGV()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Data.Clear();
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id] as [#],[Profession] as [الاسم]
                FROM [" + Settings1.Default.DatabaseName + "].[dbo].[InstituteProfessions]", Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(Data);
                dataGridView1.DataSource = Data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LoadDatafromDGV()
        {
            try
            {
                if (dataGridView1.Rows[0].Index >= 0)
                {
                    textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
                    textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
                }
            }
            catch (Exception exp)
            { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDatafromDGV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //تعديل
            EnableEditing();

            NewProfession = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //جديد
            EnableEditing();

            textBox2.Text = "";
            textBox1.Text = "*";
            NewProfession = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //cancel save
            DisableEditing();
            LoadDatafromDGV();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // save button
            if (textBox2.Text == "")
            { MessageBox.Show("الرجاء ادخال اسم", "لا يمكن الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    if (NewProfession)
                    {
                        SqlCommand Command=new SqlCommand(@"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[InstituteProfessions]
                        ([Profession]) VALUES (@Profession) ",Connection);
                        Command.Parameters.Add("@Profession", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(textBox2.Text);
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                        NewProfession = false;
                    }
                    else if (!NewProfession)
                    {
                        SqlCommand Command=new SqlCommand( @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[InstituteProfessions]
                        SET [Profession]=@Profession WHERE [id]=@id",Connection);
                        Command.Parameters.Add("@Profession", SqlDbType.NVarChar).Value =  ReplaceChar.ReplaceAChar(textBox2.Text);
                        Command.Parameters.Add("@id", SqlDbType.Int).Value = textBox1.Text;
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                    }
                    
                    RefreshDGV();
                }
            }

            DisableEditing();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // حذف
            DialogResult DR = MessageBox.Show("هل أنت متأكد من حذف الاسم؟ \n" + textBox2.Text, "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();

                    SqlCommand Command = new SqlCommand(@"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[InstituteProfessions]
                    WHERE [id]=@id", Connection);
                    Command.Parameters.Add("@id", SqlDbType.Int).Value = textBox1.Text;
                    Command.ExecuteNonQuery();

                    Command.Parameters.Clear();
                    RefreshDGV();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            LoadDatafromDGV();
        }





    }
}
