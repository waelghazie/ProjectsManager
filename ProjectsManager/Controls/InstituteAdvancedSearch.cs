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
    public partial class InstituteSearchPanel : Form, INotifyPropertyChanged
    {
        public InstituteSearchPanel()
        {
            InitializeComponent();
        }

        bool FormIsHidden;

        Dictionary<int, string> InstituteProfessionsDic = new Dictionary<int, string>();
        Dictionary<int, string> CustomersDic = new Dictionary<int, string>();
        

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

        private void InstituteSearch_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = @"SELECT [id],[Profession] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[InstituteProfessions]";
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        InstituteProfessionsDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                    Reader.Close();
                    ProfessionComboBox.DataSource = new BindingSource(InstituteProfessionsDic, null);
                    ProfessionComboBox.DisplayMember = "Value";
                    ProfessionComboBox.ValueMember = "key";
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
            
            ProfessionComboBox.SelectedValue = 0;
            CustomersComboBox.SelectedValue = 0;
            SectorComboBox.Text = "";
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

        private void InstituteSearch_Deactivate(object sender, EventArgs e)
        {
            if (!FormIsHidden)
            {
                Close();
            }
        }

        private void InstituteSearch_FormClosing(object sender, FormClosingEventArgs e)
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
                _QueryFilter += @" and [name] like '%" + ReplaceChar.ReplaceAChar(NameTextBox.Text) + "%'";
            if (Phone1TextBox.Text != "")
                _QueryFilter += @" and [phone1]='" + ReplaceChar.ReplaceAChar(Phone1TextBox.Text) + "'";
            if (Phone2TextBox.Text != "")
                _QueryFilter += @" and [phone2]='" + ReplaceChar.ReplaceAChar(Phone2TextBox.Text) + "'";
            if (MobileTextBox.Text != "")
                _QueryFilter += @" and [Mobile]='" + ReplaceChar.ReplaceAChar(MobileTextBox.Text) + "'";
            if (Convert.ToInt32(CustomersComboBox.SelectedValue) != 0)
                _QueryFilter += @" and [customer_id]=" + CustomersComboBox.SelectedValue;
            if (SectorComboBox.SelectedIndex >= 0)
                if (SectorComboBox.SelectedItem.ToString() != "" || SectorComboBox.SelectedItem.ToString() != " ")
                    _QueryFilter += @" and [Sector]='" + SectorComboBox.SelectedItem.ToString() + "'";
            if (Convert.ToInt32(ProfessionComboBox.SelectedValue) != 0)
                _QueryFilter += @" and [ProfessionID]=" + ProfessionComboBox.SelectedValue;
            if (AddressTextBox.Text != "")
                _QueryFilter += @" and [address] LIKE '%" + ReplaceChar.ReplaceAChar(AddressTextBox.Text) + "%'";

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
            Phone1TextBox.Text = "";
            Phone2TextBox.Text = "";
            MobileTextBox.Text = "";
            AddressTextBox.Text = "";
            ProfessionComboBox.SelectedValue = 0;
            CustomersComboBox.SelectedValue = 0;
            SectorComboBox.SelectedIndex = -1;
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
