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
    public partial class CallsSearchPanel : Form, INotifyPropertyChanged
    {
        public CallsSearchPanel()
        {
            InitializeComponent();
        }

        bool FormIsHidden;

        Dictionary<int, string> CustomersDic = new Dictionary<int, string>();
        Dictionary<int, string> InstitutesDic = new Dictionary<int, string>();
        Dictionary<int, string> PlantsDic = new Dictionary<int, string>();

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

                using (SqlCommand Command = new SqlCommand(@"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[customers] where [del]=0", Connection))
                {
                    SqlDataReader reader = Command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                            CustomersDic.Add(reader.GetInt32(0), reader.GetString(1));
                        reader.Close();
                        CustomersComboBox.DisplayMember = "Value";
                        CustomersComboBox.ValueMember = "key";
                        CustomersComboBox.DataSource = new BindingSource(CustomersDic, null);
                    }
                }
                CustomersComboBox.SelectedValue = 0;
            }

            PlantComboBox.Enabled = false;
            InstituteComboBox.Enabled = false;
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
                CallTextBox.Focus();
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

            if (CallTextBox.Text != "")
                _QueryFilter += @" and [Text] like '%" + CallTextBox.Text + @"%'";

            if (Convert.ToInt32(CustomersComboBox.SelectedValue) != 0)
                _QueryFilter += @" and [CustomerID]=" + CustomersComboBox.SelectedValue;

            if (Convert.ToInt32(InstituteComboBox.SelectedValue) != 0)
                _QueryFilter += @" and [InstituteID]=" + InstituteComboBox.SelectedValue;

            if (Convert.ToInt32(PlantComboBox.SelectedValue) != 0)
                _QueryFilter += @" and [PlantID]=" + PlantComboBox.SelectedValue;

            if (checkBox1.Checked)
                _QueryFilter += @" and ((datediff(day,'" + dateTimePicker1.Value.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + @"',[TimeStamp])>=0 and datediff(day,[TimeStamp],'" + dateTimePicker2.Value.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + @"')>=0))";

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
            //Clear parameters

            IDTextBox.Text = "";
            CallTextBox.Text = "";
            CustomersComboBox.SelectedValue = 0;
            InstituteComboBox.SelectedValue = 0;
            PlantComboBox.SelectedValue = 0;
            
            checkBox1.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            
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

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex > 0)
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();

                    SqlCommand Command = new SqlCommand(@"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[institutes] where [customer]=" + CustomersComboBox.SelectedValue, Connection);
                    SqlDataReader reader = Command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        InstitutesDic.Clear();

                        while (reader.Read())
                            InstitutesDic.Add(reader.GetInt32(0), reader.GetString(1));
                        reader.Close();

                        InstituteComboBox.DisplayMember = "Value";
                        InstituteComboBox.ValueMember = "key";
                        InstituteComboBox.DataSource = new BindingSource(InstitutesDic, null);

                        InstituteComboBox.Enabled = true;
                        InstituteComboBox.SelectedValue = 0;
                    }
                }
            else
            {
                InstituteComboBox.Enabled = false;
                InstituteComboBox.SelectedValue = 0;
            }
        }

        private void InstituteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex > 0 && InstituteComboBox.SelectedIndex > 0)
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();

                    SqlCommand Command = new SqlCommand(@"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[plants] where [institute]=" + InstituteComboBox.SelectedValue, Connection);
                    SqlDataReader reader = Command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        PlantsDic.Clear();

                        while (reader.Read())
                            PlantsDic.Add(reader.GetInt32(0), reader.GetString(1));
                        reader.Close();

                        PlantComboBox.DisplayMember = "Value";
                        PlantComboBox.ValueMember = "key";

                        PlantComboBox.DataSource = new BindingSource(PlantsDic, null);
                        PlantComboBox.Enabled = true;
                        PlantComboBox.SelectedValue = 0;
                    }
                }
            else
            {
                PlantComboBox.Enabled = false;
            }
        }

        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
                SendPropertyChanged("Query");
            }
        }

        private void dateTimePicker2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
                SendPropertyChanged("Query");
            }
        }
    }
}
