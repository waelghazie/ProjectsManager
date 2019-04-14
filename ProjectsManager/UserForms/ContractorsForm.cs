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
    public partial class ContractorsForm : Form
    {
        public ContractorsForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        User user;
        DataTable Data;

        bool NewContractor = false;

        private void ContractorsForm_Load(object sender, EventArgs e)
        {
            Data = new DataTable();
        }

        private void ContractorsForm_Shown(object sender, EventArgs e)
        {
            RefreshDGV("");
            VerifyUserPermissions();
            LoadDataIntoBoxes();
        }

        private void RefreshDGV(string QueryFilter)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                Data.Clear();
                dataGridView1.DataSource = null;

                SqlCommand Command = new SqlCommand(@"Select [id] as [#],[name] as [اسم المتعهد],[phone1],[phone2],[ContractorMobile]
                ,[ContractorFax],[ContractorMail],[ContractorAddress] as [العنوان],[ContractorManager] from [" + Settings1.Default.DatabaseName + @"].[dbo].[contractors] " + QueryFilter, Connection);
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
                dataGridView1.Columns[8].Visible = false;
            }
        }

        private void LoadDataIntoBoxes()
        {
            ClearBoxes();

            try
            {
                if (dataGridView1.Rows[0].Index >= 0)
                {
                    ContractorNOtextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                    ContractorNameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                    Phone1TextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                    Phone2TextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                    MobileTextBox.Text = dataGridView1.SelectedCells[4].Value.ToString();
                    FaxTextBox.Text = dataGridView1.SelectedCells[5].Value.ToString();
                    EmailTextBox.Text = dataGridView1.SelectedCells[6].Value.ToString();
                    AddressTextBox.Text = dataGridView1.SelectedCells[7].Value.ToString();
                    ManagerTextBox.Text = dataGridView1.SelectedCells[8].Value.ToString();
                }
            }
            catch (Exception exp)
            { }
        }

        private void ClearBoxes()
        {
            ContractorNOtextBox.Text = "";
            ContractorNameTextBox.Text = "";
            Phone1TextBox.Text = "";
            Phone2TextBox.Text = "";
            MobileTextBox.Text = "";
            FaxTextBox.Text = "";
            EmailTextBox.Text = "";
            AddressTextBox.Text = "";
            ManagerTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save changes
            if (SaveChanges())
                DisableEditing();
            VerifyUserPermissions();
        }

        private bool SaveChanges()
        {
            if (ContractorNameTextBox.Text == "")
            {
                NotifyMessage nm = new NotifyMessage("يرجى إدخال الاسم", NotifyMessage.NotifyMessageIcon.Error);
                nm.Show();
                return false;
            }
            else
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    SqlCommand Command = new SqlCommand();
                    Command.Connection = Connection;
                    Connection.Open();

                    if (NewContractor)
                    {
                        Command.CommandText = @"insert into [" + Settings1.Default.DatabaseName + @"].[dbo].[contractors] 
                        ([name],[phone1],[phone2],[del],[ContractorMobile],[ContractorFax],[ContractorMail],[ContractorAddress],[ContractorManager]) values 
                        (@name,@phone1,@phone2,0,@ContractorMobile,@ContractorFax,@ContractorMail,@ContractorAddress,@ContractorManager)";
                        Command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(ContractorNameTextBox.Text);
                        Command.Parameters.Add("@phone1", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone1TextBox.Text);
                        Command.Parameters.Add("@phone2", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone2TextBox.Text);
                        Command.Parameters.Add("@ContractorMobile", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(MobileTextBox.Text);
                        Command.Parameters.Add("@ContractorFax", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(FaxTextBox.Text);
                        Command.Parameters.Add("@ContractorMail", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(EmailTextBox.Text);
                        Command.Parameters.Add("@ContractorAddress", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(AddressTextBox.Text);
                        Command.Parameters.Add("@ContractorManager", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(ManagerTextBox.Text);
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();

                        NewContractor = false;
                    }
                    else
                    {
                        Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[contractors] 
                        SET [name]=@name ,[phone1]=@phone1 ,[phone2]=@phone2 ,[ContractorMobile]=@ContractorMobile
                        ,[ContractorFax]=@ContractorFax,[ContractorMail]=@ContractorMail,[ContractorAddress]=@ContractorAddress
                        ,[ContractorManager]=@ContractorManager WHERE [id]=@id";
                        Command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(ContractorNameTextBox.Text);
                        Command.Parameters.Add("@phone1", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone1TextBox.Text);
                        Command.Parameters.Add("@phone2", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone2TextBox.Text);
                        Command.Parameters.Add("@ContractorMobile", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(MobileTextBox.Text);
                        Command.Parameters.Add("@ContractorFax", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(FaxTextBox.Text);
                        Command.Parameters.Add("@ContractorMail", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(EmailTextBox.Text);
                        Command.Parameters.Add("@ContractorAddress", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(AddressTextBox.Text);
                        Command.Parameters.Add("@ContractorManager", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(ManagerTextBox.Text);
                        Command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(ContractorNOtextBox.Text);
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                    }
                    NotifyMessage nm = new NotifyMessage("تم الحفظ", NotifyMessage.NotifyMessageIcon.Saved);
                    nm.Show();
                    RefreshDGV("");
                    return true;
                }
        }
            
    
        private void button2_Click(object sender, EventArgs e)
        {
            //Cancel Changes
            DisableEditing();
            VerifyUserPermissions();
            LoadDataIntoBoxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //new contactor
            EnableEditing();
            ClearBoxes();
            ContractorNOtextBox.Text = "*";
            NewContractor = true;
            ContractorNameTextBox.Focus();
            VerifyUserPermissions();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            RefreshDGV(@"where [name] like '%" + ReplaceChar.ReplaceAChar(SearchTextBox.Text) + @"%'");
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            //modify current contractor
            EnableEditing();
            VerifyUserPermissions();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
                if (dataGridView1.CurrentRow.Index >= 0)
                {
                    DialogResult DR = MessageBox.Show("هل تريد حذف هذه المتعهد نهائياً ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DR == DialogResult.Yes)
                    {
                        using (SqlConnection Connection = AppConnection.GetConnection())
                        {
                            string DeletedContractor = dataGridView1.SelectedCells[1].Value.ToString();
                            Connection.Open();
                            SqlCommand Command = new SqlCommand(@"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[contractors] WHERE [id]=" + dataGridView1.SelectedCells[0].Value, Connection);
                            Command.ExecuteNonQuery();

                            NotifyMessage nm = new NotifyMessage("تم حذف المتعهد " + DeletedContractor, NotifyMessage.NotifyMessageIcon.Deleted);
                            nm.Show();

                        }
                        RefreshDGV("");
                    }
                }
        }

        private void EnableEditing()
        {
            ContractorNameTextBox.ReadOnly = false;
            Phone1TextBox.ReadOnly = false;
            Phone2TextBox.ReadOnly = false;
            MobileTextBox.ReadOnly = false;
            FaxTextBox.ReadOnly = false;
            EmailTextBox.ReadOnly = false;
            AddressTextBox.ReadOnly = false;
            ManagerTextBox.ReadOnly = false;

            SaveButton.Visible = true;
            CancelChangesButton.Visible = true;

            NewButton.Visible = false;
            ModifyButton.Visible = false;
            DeleteButton.Visible = false;

            dataGridView1.Enabled = false;
            SearchTextBox.Enabled = false;
        }

        private void DisableEditing()
        {
            ContractorNameTextBox.ReadOnly = true;
            Phone1TextBox.ReadOnly = true;
            Phone2TextBox.ReadOnly = true;
            MobileTextBox.ReadOnly = true;
            FaxTextBox.ReadOnly = true;
            EmailTextBox.ReadOnly = true;
            AddressTextBox.ReadOnly = true;
            ManagerTextBox.ReadOnly = true;

            SaveButton.Visible = false;
            CancelChangesButton.Visible = false;

            NewButton.Visible = true;
            ModifyButton.Visible = true;
            DeleteButton.Visible = true;

            dataGridView1.Enabled = true;
            SearchTextBox.Enabled = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataIntoBoxes();
        }

        private void VerifyUserPermissions()
        {
            if (user.ReadPermission)
            { }
            else
            { dataGridView1.Visible = false; NewButton.Visible = false; ModifyButton.Visible = false; SaveButton.Visible = false; CancelChangesButton.Visible = false; }
            
            if (user.ModifyPermission)
            { }
            else { ModifyButton.Visible = false; SaveButton.Visible = false; CancelChangesButton.Visible = false; }

            if (user.CreatePermission)
            { }
            else
            { NewButton.Visible = false; }

            if (user.DeletePermission)
            { }
            else
            { DeleteButton.Visible = false; }
        }

    }
}
