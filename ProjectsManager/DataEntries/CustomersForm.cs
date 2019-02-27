using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectsManager
{
    public partial class CustomersForm : Form
    {
        public CustomersForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        User user;
        DataTable Data;

        bool NewCustomer = false;


        private void Form5_Load(object sender, EventArgs e)
        {
            Data = new DataTable();
        }

        private void CustomersForm_Shown(object sender, EventArgs e)
        {
            RefreshDGV("");
            VerifyUserPermissions();
            LoadDataIntoBoxes();
        }

        private void VerifyUserPermissions()
        {
            if (user.ReadPermission)
            { }
            else
            { dataGridView1.Visible = false; NewCustomerButton.Visible = false; ModifyButton.Visible = false; SaveButton.Visible = false; CancelChangesButton.Visible = false; }

            if (user.ModifyPermission)
            { }
            else { ModifyButton.Visible = false; SaveButton.Visible = false; CancelChangesButton.Visible = false; }

            if (user.CreatePermission)
            { }
            else
            { NewCustomerButton.Visible = false; }

            if (user.DeletePermission)
            { }
            else
            { DeleteButton.Visible = false; }
        }

        private void RefreshDGV(string QueryFilter)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                Data.Clear();

                Data.Clear();
                dataGridView1.DataSource = null;

                SqlCommand Command = new SqlCommand(@"select [id] as [#],[name] as [اسم الزبون],[mobile],[manager],[CustomerPhone1],[CustomerPhone2],[CustomerFAX],[CustomerMail],[CustomerAddress]  as [العنوان]
                from [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] where [del]=0 " + QueryFilter, Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);

                Adapter.Fill(Data);
                dataGridView1.DataSource = Data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
                dataGridView1.Columns[0].Width = 10;
                
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
        }

        private void LoadDataIntoBoxes()
        {
            try
            {
                ClearBoxes();

                if (dataGridView1.Rows[0].Index >= 0)
                {
                    CustomerNoTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                    CustomerNameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                    MobileTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                    CustomerManagerTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                    Phone1TextBox.Text = dataGridView1.SelectedCells[4].Value.ToString();
                    Phone2TextBox.Text = dataGridView1.SelectedCells[5].Value.ToString();
                    FaxTextBox.Text = dataGridView1.SelectedCells[6].Value.ToString();
                    EmailTextBox.Text = dataGridView1.SelectedCells[7].Value.ToString();
                    AddressTextBox.Text = dataGridView1.SelectedCells[8].Value.ToString();
                }
            }
            catch (Exception exp)
            { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //save changes button
            if (SaveChanges())
                DisableEditing();
            VerifyUserPermissions();
        }

        private bool SaveChanges()
        {
            if (CustomerNameTextBox.Text == "")
            {

                NotifyMessage nm = new NotifyMessage("يرجى إدخال الاسم", NotifyMessage.NotifyMessageIcon.Error);
                nm.Show();
                return false;
            }
            else
            {
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    SqlCommand Command = new SqlCommand();
                    Command.Connection = Connection;
                    Connection.Open();

                    if (NewCustomer)
                    {
                        Command.CommandText = @"insert into [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] 
                        ([name],[mobile],[manager],[del],[CustomerPhone1],[CustomerPhone2],[CustomerFAX],[CustomerMail],[CustomerAddress]) values 
                        (@name,@mobile,@manager,0,@CustomerPhone1,@CustomerPhone2,@CustomerFAX,@CustomerMail,@CustomerAddress)";
                        Command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(CustomerNameTextBox.Text);
                        Command.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(MobileTextBox.Text);
                        Command.Parameters.Add("@manager", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(CustomerManagerTextBox.Text);
                        Command.Parameters.Add("@CustomerPhone1", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone1TextBox.Text);
                        Command.Parameters.Add("@CustomerPhone2", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone2TextBox.Text);
                        Command.Parameters.Add("@CustomerFAX", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(FaxTextBox.Text);
                        Command.Parameters.Add("@CustomerMail", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(EmailTextBox.Text);
                        Command.Parameters.Add("@CustomerAddress", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(AddressTextBox.Text);
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();

                        NewCustomer = false;
                    }
                    else if (!NewCustomer)
                    {
                        Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] 
                        SET [name]=@name,[mobile]=@mobile,[manager]=@manager,[CustomerPhone1]=@CustomerPhone1,[CustomerPhone2]=@CustomerPhone2,
                        [CustomerFAX]=@CustomerFAX,[CustomerMail]=@CustomerMail,[CustomerAddress]=@CustomerAddress,[del]=0 
                        WHERE [id]=@id";
                        Command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(CustomerNameTextBox.Text);
                        Command.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(MobileTextBox.Text);
                        Command.Parameters.Add("@manager", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(CustomerManagerTextBox.Text);
                        Command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(CustomerNoTextBox.Text);
                        Command.Parameters.Add("@CustomerPhone1", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone1TextBox.Text);
                        Command.Parameters.Add("@CustomerPhone2", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone2TextBox.Text);
                        Command.Parameters.Add("@CustomerFAX", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(FaxTextBox.Text);
                        Command.Parameters.Add("@CustomerMail", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(EmailTextBox.Text);
                        Command.Parameters.Add("@CustomerAddress", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(AddressTextBox.Text);
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                    }
                    NotifyMessage nm = new NotifyMessage("تم الحفظ", NotifyMessage.NotifyMessageIcon.Saved);
                    nm.Show();
                    DisableEditing();
                    RefreshDGV("");
                    return true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cancel changes made to current customer
            DisableEditing();
            VerifyUserPermissions();
            LoadDataIntoBoxes();
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            Close(); 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            RefreshDGV(@" and [name] like '%" + ReplaceChar.ReplaceAChar(SearchTextBox.Text) + @"%'");
            LoadDataIntoBoxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //new customer
            EnableEditing();
            NewCustomer = true;
            ClearBoxes();
            CustomerNoTextBox.Text = "*";
            CustomerNameTextBox.Focus();
        }

        private void ClearBoxes()
        {
            CustomerNoTextBox.Text = "";
            CustomerNameTextBox.Text = "";
            AddressTextBox.Text = "";
            MobileTextBox.Text = "";
            Phone1TextBox.Text = "";
            Phone2TextBox.Text = "";
            FaxTextBox.Text = "";
            EmailTextBox.Text = "";
            MobileTextBox.Text = "";
            CustomerManagerTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //modify button
            EnableEditing();
            VerifyUserPermissions();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //delete

            if (dataGridView1.Rows.Count > 0)
                if (dataGridView1.CurrentRow.Index > 0)
                    if (DeleteItem.DeleteCustomer(Convert.ToInt32(dataGridView1.SelectedCells[0].Value)))
                        RefreshDGV("");
        }

        private void dataGridView1_CellMouseClick(object sender, MouseEventArgs e)
        {
            LoadDataIntoBoxes();
        }

        private void EnableEditing()
        {
            CustomerNameTextBox.ReadOnly = false;
            MobileTextBox.ReadOnly = false;
            CustomerManagerTextBox.ReadOnly = false;
            AddressTextBox.ReadOnly = false;
            Phone1TextBox.ReadOnly = false;
            Phone2TextBox.ReadOnly = false;
            FaxTextBox.ReadOnly = false;
            EmailTextBox.ReadOnly = false;

            SearchTextBox.Enabled = false;

            SaveButton.Visible = true;
            CancelChangesButton.Visible = true;

            ModifyButton.Visible = false;
            NewCustomerButton.Visible = false;
            DeleteButton.Visible= false;
            
            dataGridView1.Enabled = false;
        }

        private void DisableEditing()
        {
            CustomerNameTextBox.ReadOnly = true;
            MobileTextBox.ReadOnly = true;
            CustomerManagerTextBox.ReadOnly = true;
            AddressTextBox.ReadOnly = true;
            Phone1TextBox.ReadOnly = true;
            Phone2TextBox.ReadOnly = true;
            FaxTextBox.ReadOnly = true;
            EmailTextBox.ReadOnly = true;

            SearchTextBox.Enabled = true;

            SaveButton.Visible = false;
            CancelChangesButton.Visible = false;

            NewCustomerButton.Visible = true;
            ModifyButton.Visible = true;
            DeleteButton.Visible = true;

            dataGridView1.Enabled = true;
        }



    }
}
