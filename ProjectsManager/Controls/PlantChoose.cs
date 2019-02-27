using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProjectsManager
{
    public partial class PlantChoose : UserControl
    {
        public PlantChoose()
        {
            InitializeComponent();
        }

        Dictionary<int, string> CustomersDic = new Dictionary<int, string>();
        Dictionary<int, string> InstitutesDic = new Dictionary<int, string>();
        Dictionary<int, string> PlantsDic = new Dictionary<int, string>();

        public int CustomerID;
        public int InstituteID;
        public int PlantID;

        public string CustomerName;
        public string InstituteName;
        public string PlantName;

        public bool SuccessChoose = false;

        private void PlantChoose_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                pictureBox1.Visible = false;

                //Load Customers
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand(@"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[customers] where [del]=0", Connection);
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                            CustomersDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                        Reader.Close();
                        CustomersComboBox.DisplayMember = "Value";
                        CustomersComboBox.ValueMember = "key";
                        CustomersComboBox.DataSource = new BindingSource(CustomersDic, null);

                        CustomersComboBox.SelectedValue = 0;

                        CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
                        CustomersComboBox.Leave += CustomersComboBox_Leave;
                    }
                }

                LoadInstitutes();
            }
        }

        private void LoadInstitutes()
        {
            //Load institutes
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[institutes] where [del]=0", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        InstitutesDic.Add(Reader.GetInt32(0), Reader.GetString(1));

                    InstituteComboBox.DisplayMember = "Value";
                    InstituteComboBox.ValueMember = "Key";
                    InstituteComboBox.DataSource = new BindingSource(InstitutesDic, null);
                    InstituteComboBox.SelectedValue = 0;

                    InstituteComboBox.SelectedIndexChanged += InstituteComboBox_SelectedIndexChanged;
                    InstituteComboBox.Leave += InstituteComboBox_Leave;
                }
            }
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyCustomer();
        }

        private void CustomersComboBox_Leave(object sender, EventArgs e)
        {
            VerifyCustomer();
        }

        private void VerifyCustomer()
        {
            InstituteComboBox.SelectedIndexChanged -= InstituteComboBox_SelectedIndexChanged;
            InstituteComboBox.Leave -= InstituteComboBox_Leave;

            InstitutesDic.Clear();
            InstituteComboBox.DataSource = null;
            PlantsDic.Clear();
            PlantComboBox.DataSource = null;

            Plantlabel.Visible = false;
            PlantComboBox.Visible = false;

            if (CustomersComboBox.Text != "")
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand(@"SELECT [name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[customers] where [del]=0 and [name]='" + CustomersComboBox.Text + "'", Connection);
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)              //Customer is Found
                    {
                        Reader.Close();

                        Command.CommandText = @"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName +
                        "].[dbo].[institutes] where [del]=0 and [customer]=" + CustomersComboBox.SelectedValue;
                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)         //Institutes Found
                        {
                            while (Reader.Read())
                                InstitutesDic.Add(Reader.GetInt32(0), Reader.GetString(1));

                            InstituteComboBox.DisplayMember = "Value";
                            InstituteComboBox.ValueMember = "Key";
                            InstituteComboBox.DataSource = new BindingSource(InstitutesDic, null);
                            InstituteComboBox.SelectedValue = 0;

                            InstituteComboBox.SelectedIndexChanged += InstituteComboBox_SelectedIndexChanged;
                            InstituteComboBox.Leave += InstituteComboBox_Leave;

                            InstituteLabel.Visible = true;
                            InstituteComboBox.Visible = true;
                        }
                    }
                    else                            //No Customer Found
                    {
                        CustomersComboBox.Text = "";
                        pictureBox1.Show();
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Properties.Resources.warning;

                        LoadInstitutes();
                    }
                }
            else if (CustomersComboBox.Text == "")
            {
                LoadInstitutes();
            }
        }

        private void InstituteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyInstitute();
        }

        private void InstituteComboBox_Leave(object sender, EventArgs e)
        {
            VerifyInstitute();
        }

        private void VerifyInstitute()
        {
            PlantComboBox.SelectedIndexChanged -= PlantComboBox_SelectedIndexChanged;
            PlantComboBox.Leave -= PlantComboBox_Leave;

            PlantsDic.Clear();
            PlantComboBox.DataSource = null;
            PlantComboBox.SelectedValue = 0;

            if (Convert.ToInt32(InstituteComboBox.SelectedValue) > 0)
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand(@"select [id],[name] from [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] where [name] = '" + InstituteComboBox.Text + "'", Connection);
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)                 //Institute Found
                    {
                        Reader.Close();

                        if (CustomersComboBox.Text == "")
                        {
                            CustomersComboBox.SelectedIndexChanged -= CustomersComboBox_SelectedIndexChanged;
                            CustomersComboBox.Leave -= CustomersComboBox_Leave;

                            Command.CommandText = @"SELECT [customer_id] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes_view] where [id] =" + InstituteComboBox.SelectedValue;
                            Reader = Command.ExecuteReader();
                            if (Reader.HasRows)
                                while (Reader.Read())
                                    CustomersComboBox.SelectedValue = Reader.GetInt32(0);
                            Reader.Close();

                            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
                            CustomersComboBox.Leave += CustomersComboBox_Leave;
                        }

                        Command.CommandText = @"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[plants] where [del]=0 and [institute]=" + InstituteComboBox.SelectedValue;
                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)             //Plants Found
                        {
                            while (Reader.Read())
                                PlantsDic.Add(Reader.GetInt32(0), Reader.GetString(1));

                            PlantComboBox.DisplayMember = "Value";
                            PlantComboBox.ValueMember = "Key";
                            PlantComboBox.DataSource = new BindingSource(PlantsDic, null);
                            PlantComboBox.SelectedValue = 0;

                            Plantlabel.Visible = true;
                            PlantComboBox.Visible = true;

                            PlantComboBox.SelectedIndexChanged += PlantComboBox_SelectedIndexChanged;
                            PlantComboBox.Leave += PlantComboBox_Leave;
                            toolTip1.Active = false;
                        }
                        else
                            toolTip1.Active = true;
                    }
                    else                                // No Institute Found
                    {
                        InstituteComboBox.Text = "";
                    }
                }
        }

        private void PlantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerifyPlant();
        }

        private void PlantComboBox_Leave(object sender, EventArgs e)
        {
            VerifyPlant();
        }

        private void PlantChoose_Leave(object sender, EventArgs e)
        {
            VerifyPlant();
        }

        private void VerifyPlant()
        {
            if (Convert.ToInt32(PlantComboBox.SelectedValue) > 0 && PlantComboBox.Visible == true)
            {
                CustomerID = Convert.ToInt32(CustomersComboBox.SelectedValue);
                InstituteID = Convert.ToInt32(InstituteComboBox.SelectedValue);
                PlantID = Convert.ToInt32(PlantComboBox.SelectedValue);

                CustomerName = CustomersComboBox.Text;
                InstituteName = InstituteComboBox.Text;
                PlantName = PlantComboBox.Text;

                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.success;
                SuccessChoose = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.warning;
                SuccessChoose = false;
                
                CustomerID = 0;
                InstituteID = 0;
                PlantID = 0;

                CustomerName = "";
                InstituteName = "";
                PlantName = "";
            }
        }

        public void ClearDataFromBoxes()
        {
            InstituteComboBox.SelectedIndexChanged -= InstituteComboBox_SelectedIndexChanged;
            InstituteComboBox.Leave -= InstituteComboBox_Leave;

            PlantComboBox.SelectedIndexChanged -= PlantComboBox_SelectedIndexChanged;
            PlantComboBox.Leave -= PlantComboBox_Leave;

            
            InstitutesDic.Clear();
            InstituteComboBox.DataSource = null;
            PlantsDic.Clear();
            PlantComboBox.DataSource = null;

            CustomersComboBox.SelectedValue = 0;
            InstituteComboBox.SelectedValue = 0;
            PlantComboBox.SelectedValue = 0;
            pictureBox1.Hide();

            CustomerID = 0;
            InstituteID = 0;
            PlantID = 0;

            CustomerName = "";
            InstituteName = "";
            PlantName = "";
        }

        public bool IsDataOK()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[institute_id],[CustomerID] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants_view] where [del]=0", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (Reader.GetInt32(0) == Convert.ToInt32(PlantComboBox.SelectedValue) &&
                            Reader.GetInt32(1) == Convert.ToInt32(InstituteComboBox.SelectedValue) &&
                            Reader.GetInt32(2) == Convert.ToInt32(CustomersComboBox.SelectedValue))
                        {
                            Reader.Close();
                            return true;
                        }
                    }
            }
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.warning;
            return false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("لا يوجد وحدات معالجة تابعة للمنشأة المحددة", pictureBox1, 0, 0, 2000);
        }


    }
}
