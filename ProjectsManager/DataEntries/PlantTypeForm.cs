﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectsManager
{
    public partial class PlantTypeForm : Form
    {
        /// <summary>
        /// New VehiclesWindow
        /// </summary>
        /// <param name="user"></param>
        public PlantTypeForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        DataTable Data;
        User user;

        bool NewCar = false;

        private void PlantType_Load(object sender, EventArgs e)
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
                Connection.Open();
                Data.Clear();
                SqlCommand Command = new SqlCommand(@"SELECT [id] as [#],[PlantType] as [نوع وحدة المعالجة]
                FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PlantType]", Connection);
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

            NewCar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //جديد
            EnableEditing();

            textBox2.Text = "";
            textBox1.Text = "*";
            NewCar = true;
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
                    if (NewCar)
                    {
                        SqlCommand Command = new SqlCommand(@"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantType]
                        ([PlantType]) VALUES (@PlantType)", Connection);
                        Command.Parameters.Add("@PlantType", SqlDbType.NVarChar).Value =  ReplaceChar.ReplaceAChar(textBox2.Text);
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                        NewCar = false;
                    }
                    else if (!NewCar)
                    {
                        SqlCommand Command = new SqlCommand(@"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantType]
                        SET [PlantType]=@PlantType WHERE [id]=@id", Connection);
                        Command.Parameters.Add("@PlantType", SqlDbType.NVarChar).Value =  ReplaceChar.ReplaceAChar(textBox2.Text);
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
                    SqlCommand Command = new SqlCommand(@"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantType]
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
