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
    public partial class PlantSearchPanel : Form, INotifyPropertyChanged
    {
        public PlantSearchPanel()
        {
            InitializeComponent();
        }

        bool FormIsHidden;

        Dictionary<int, string> InstitutesDic = new Dictionary<int, string>();
        Dictionary<int, string> CustomersDic = new Dictionary<int, string>();
        Dictionary<int, string> ContractorsDic = new Dictionary<int, string>();

        string _QueryFilter = "";
        
        public string QueryFilter
        {
            set { _QueryFilter = QueryFilter;  }
            get { return GetQueryFilter(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void SendPropertyChanged(string Property)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(Property));
        }

        private void Form_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = @"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[institutes] where [del]=0";
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        InstitutesDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                    Reader.Close();
                    InstituteComboBox.DataSource = new BindingSource(InstitutesDic, null);
                    InstituteComboBox.DisplayMember = "Value";
                    InstituteComboBox.ValueMember = "key";
                }
                Reader.Close();

                Command.CommandText = @"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[contractors]";
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        ContractorsDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                    Reader.Close();
                    ContractorComboBox.DataSource = new BindingSource(ContractorsDic, null);
                    ContractorComboBox.DisplayMember = "Value";
                    ContractorComboBox.ValueMember = "key";
                }
                Reader.Close();

                Command.CommandText = @"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[customers] where [del]=0";
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        CustomersDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                    Reader.Close();
                    CustomersComboBox.DataSource = new BindingSource(CustomersDic, null);
                    CustomersComboBox.DisplayMember = "Value";
                    CustomersComboBox.ValueMember = "key";
                }
                Reader.Close();

            }
            
            ContractorComboBox.SelectedValue = 0;
            CustomersComboBox.SelectedValue = 0;
            InstituteComboBox.SelectedValue = 0;
        }

        private void InstituteSearch_Shown(object sender, EventArgs e)
        {
            ShowForm();
        }

        public void ShowForm()
        {
            this.Height = 2;
            FormIsHidden = false;
            this.Show();
            ShowTimer.Enabled = true;
        }
        
        private void ShowTimer_Tick(object sender, EventArgs e)
        {
            this.Height += 15;
            if (this.Height == 302)
            {
                ShowTimer.Enabled = false;
                NameTextBox.Focus();
            }
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if (!ShowTimer.Enabled)
            {
                this.Height -= 15;
                if (this.Height == 2)
                {
                    CloseTimer.Enabled = false;
                    this.TopMost = false;
                    FormIsHidden = true;
                    this.Hide();
                }
            }
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
            if (!FormIsHidden)
            {
                Close();
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.TopMost = true;
            CloseTimer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            SendPropertyChanged("Query");
        }

        private string GetQueryFilter()
        {
            _QueryFilter = "";
            if (IDTextBox.Text != "")
                _QueryFilter += @" and [id]=" + IDTextBox.Text;

            if (NameTextBox.Text != "")
                _QueryFilter += @" and [plant] like '%" + ReplaceChar.ReplaceAChar(NameTextBox.Text) + "%'";

            if (PlantTechPersonTextBox.Text != "")
                _QueryFilter += @" and [technician] like '%" + ReplaceChar.ReplaceAChar(PlantTechPersonTextBox.Text) + "%'";

            if (ContractTypeTextBox.Text != "")
                _QueryFilter += @" and [contract_type] = '" + ReplaceChar.ReplaceAChar(ContractTypeTextBox.Text) + "'";

            if (Convert.ToInt32(CustomersComboBox.SelectedValue) != 0)
                _QueryFilter += @" and [CustomerID]=" + CustomersComboBox.SelectedValue;

            if (Convert.ToInt32(InstituteComboBox.SelectedValue) != 0)
                _QueryFilter += @" and [institute_id]=" + InstituteComboBox.SelectedValue;

            if (Convert.ToInt32(ContractorComboBox.SelectedValue) != 0)
                _QueryFilter += @" and [contractor_id]=" + ContractorComboBox.SelectedValue;

            if (PlantDescTextBox.Text != "")
                _QueryFilter += @" and [PlantDetails] LIKE '%" + ReplaceChar.ReplaceAChar(PlantDescTextBox.Text) + "%'";

            if (checkBox1.Checked)
                _QueryFilter += @"and datediff(day,[start_time],getdate())>=0 and datediff(day,getdate(),[end_time])>=0";

            return _QueryFilter;
        }

        private void IDTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
                SendPropertyChanged("Query");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            PlantTechPersonTextBox.Text = "";
            ContractTypeTextBox.Text = "";
            PlantDescTextBox.Text = "";
            ContractorComboBox.SelectedValue = 0;
            CustomersComboBox.SelectedValue = 0;
            InstituteComboBox.SelectedValue = 0;
            checkBox1.Checked = false;
        }

        private void NameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
                SendPropertyChanged("Query");
            }
        }

        private void Phone1TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
                SendPropertyChanged("Query");
            }
        }

        private void Phone2TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
                SendPropertyChanged("Query");
            }
        }

        private void MobileTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
                SendPropertyChanged("Query");
            }
        }

        private void AddressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
                SendPropertyChanged("Query");
            }
        }



                


    }
}
