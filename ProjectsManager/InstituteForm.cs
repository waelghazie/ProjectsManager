using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class InstituteForm : Form
    {
        /// <summary>
        /// New Institute Object
        /// </summary>
        public InstituteForm(User user)
        {
            this.user = user;
            this.NewInstitute = true;
            InitializeComponent();
        }

        /// <summary>
        /// Old Institute Object
        /// </summary>
        public InstituteForm(int InstituteID, User user)
        {
            this.InstituteID = InstituteID;
            this.user = user;
            this.NewInstitute = false;
            InitializeComponent();
        }

        int InstituteID, CustomerID;
        bool ChangesMade = false;
        //bool SafeToExitWindow = true;
        bool NewInstitute = false;

        User user;

        DataTable Data;

        Dictionary<int, string> InstituteProfessionsDic = new Dictionary<int, string>();
        Dictionary<int, string> CustomersDic = new Dictionary<int, string>();

        private void InstituteForm_Load(object sender, EventArgs e)
        {
            GetUserPermissions();
            Data = new DataTable();

            //Load InstituteProfessions Data in Combobox
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[Profession] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[InstituteProfessions]", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        InstituteProfessionsDic.Add(Reader.GetInt32(0), Reader.GetString(1));

                    InstituteProfessionsComboBox.DisplayMember = "Value";
                    InstituteProfessionsComboBox.ValueMember = "key";
                    InstituteProfessionsComboBox.DataSource = new BindingSource(InstituteProfessionsDic, null);
                    InstituteProfessionsComboBox.SelectedValue = 0;
                }
            }

            //Load customers Data in Combobox
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"select [id],[name] from [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] where [del]=0", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        CustomersDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                    
                    CustomerComboBox.DisplayMember = "Value";
                    CustomerComboBox.ValueMember = "Key";
                    CustomerComboBox.DataSource = new BindingSource(CustomersDic, null);
                    CustomerComboBox.SelectedValue = 0;
                }
            }

            //Load Institute Data
            if (NewInstitute)
            {
                Text = "منشأة جديدة";
                InstituteNOTextBox.Text = "*";
                
                DeleteButton.Visible = false; 
                RestoreButton.Visible = false;
                CustomerComboBox.Text = "";
                
            }
            else if (!NewInstitute)
            {
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand(@"SELECT [name],[customer_id],[customer],[customer_mobile],[customer_manager]
                    ,[phone1],[phone2],[fax],[email],[manager],[address],[workingdays],[del],[InstituteMobile],[Sector],[ProfessionID]  
                    FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes_view] where [id]=" + InstituteID, Connection);

                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                        {
                            if (!Reader.IsDBNull(0))
                            {
                                InstituteNameTextBox.Text = Reader.GetString(0);
                                this.Text = "منشاة" + " [" + Reader.GetString(0) + "]";
                            }
                            if (!Reader.IsDBNull(1))
                                CustomerNOTextBox.Text = Convert.ToString(Reader.GetInt32(1));
                            if (!Reader.IsDBNull(2))
                            {
                                CustomerComboBox.SelectedIndex = CustomerComboBox.FindStringExact(Reader.GetString(2));
                                CustomerNameTextBox.Text = Reader.GetString(2);
                            }
                            if (!Reader.IsDBNull(3))
                                CustomerMobileTextBox.Text = Reader.GetString(3);
                            if (!Reader.IsDBNull(4))
                                CustomerManagerTextBox.Text = Reader.GetString(4);
                            if (!Reader.IsDBNull(5))
                                Phone1TextBox.Text = Reader.GetString(5);
                            if (!Reader.IsDBNull(6))
                                Phone2TextBox.Text = Reader.GetString(6);
                            if (!Reader.IsDBNull(7))
                                FaxTextBox.Text = Reader.GetString(7);
                            if (!Reader.IsDBNull(8))
                                EmailTextBox.Text = Reader.GetString(8);
                            if (!Reader.IsDBNull(9))
                                InstituteManagerTextBox.Text = Reader.GetString(9);
                            if (!Reader.IsDBNull(10))
                                AddressTextBox.Text = Reader.GetString(10);
                            if (!Reader.IsDBNull(11))
                                ReadWorkingDays(Reader.GetString(11));
                            if (!Reader.IsDBNull(12))
                                if (Reader.GetBoolean(12) == true) //Deleted Institute
                                {
                                    RestoreButton.Visible = true; NewPlantButton.Visible = false; SaveButton.Visible = false;
                                    groupBox1.Enabled = false; groupBox2.Enabled = false; groupBox4.Enabled = false; groupBox3.Enabled = false;
                                    PlantsDGV.Enabled = false; 
                                    PlantsToolBar.Enabled = false;
                                }
                                else
                                { RestoreButton.Visible = false; }
                            if (!Reader.IsDBNull(13))
                                MobileTextBox.Text = Reader.GetString(13);
                            if (!Reader.IsDBNull(14))
                                SectorComboBox.SelectedIndex = SectorComboBox.FindStringExact(Reader.GetString(14));
                            if (!Reader.IsDBNull(15))
                                InstituteProfessionsComboBox.SelectedValue = Reader.GetInt32(15);
                        }
                    InstituteNOTextBox.Text = Convert.ToString(InstituteID); //institute id
                    
                }
            }
        }

        private void GetUserPermissions()
        {
            if (user.ReadPermission)
            { }
            else
            { tableLayoutPanel1.Visible = false; }

            if (user.ModifyPermission)
            { }
            else
            {
                groupBox1.Enabled = false; groupBox2.Enabled = false; groupBox3.Enabled = false; groupBox4.Enabled = false;

                DeleteButton.Visible = false; RestoreButton.Visible = false;  SaveButton.Visible = false;
                NewPlantButton.Visible = false; EditPlantButton.Visible = false; DeletePlantButton.Visible = false;
            }

            if (user.CreatePermission)
            { }
            else
            { NewPlantButton.Visible = false; }

            if (user.DeletePermission)
            { }
            else
            { DeleteButton.Visible = false; RestoreButton.Visible = false; DeletePlantButton.Visible = false; }
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            InstituteNameTextBox.Focus();
        }

        void plant_FormClosed(object sender, FormClosedEventArgs e)
        {
            //refresh datagridview after plant window is closed
            RefreshPlantDGV();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (InstituteNameTextBox.Focused)
                ChangesMade = true;
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (InstituteManagerTextBox.Focused)
                ChangesMade = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Phone2TextBox.Focused)
                ChangesMade = true;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (FaxTextBox.Focused)
                ChangesMade = true;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextBox.Focused)
                ChangesMade = true;
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (AddressTextBox.Focused)
                ChangesMade = true;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Phone1TextBox.Focused)
                ChangesMade = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Focused)
                ChangesMade = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Focused)
                ChangesMade = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Focused)
                ChangesMade = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Focused)
                ChangesMade = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Focused)
                ChangesMade = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Focused)
                ChangesMade = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Focused)
                ChangesMade = true;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (MobileTextBox.Focused)
                ChangesMade = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectorComboBox.Focused)
                ChangesMade = true;
        }

        private void CreateNewPlant()
        {
            if (ChangesMade || NewInstitute)
            {
                DialogResult DR = MessageBox.Show("يجب حفظ المنشأة الحالية، هل ترغب بالمتابعة؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                    if (SaveChanges())
                    {
                        PlantForm NewPlant = new PlantForm(InstituteID, user);
                        NewPlant.FormClosed += new FormClosedEventHandler(plant_FormClosed);
                        NewPlant.Show();
                    }
            }
            else
            {
                PlantForm NewPlant = new PlantForm(InstituteID, user);
                NewPlant.FormClosed += new FormClosedEventHandler(plant_FormClosed);
                NewPlant.Show();
            }
        }

        private void DeletePlant()
        {
            if (PlantsDGV.Rows.Count > 0)
                if (DeleteItem.DeletePlant(Convert.ToInt32(PlantsDGV.SelectedCells[0].Value)))
                    RefreshPlantDGV();
        }
        
        private void ReadWorkingDays(string WorkingDays)
        {
            char[] c = new char[7];
            c = WorkingDays.ToCharArray();
            
            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                    if (c[i] == '1')
                        checkBox1.Checked = true;
                if (i == 1)
                    if (c[i] == '1')
                        checkBox2.Checked = true; 
                if (i == 2)
                    if (c[i] == '1')
                        checkBox3.Checked = true; 
                if (i == 3)
                    if (c[i] == '1')
                        checkBox4.Checked = true; 
                if (i == 4)
                    if (c[i] == '1')
                        checkBox5.Checked = true; 
                if (i == 5)
                    if (c[i] == '1')
                        checkBox6.Checked = true; 
                if (i == 6)
                    if (c[i] == '1')
                        checkBox7.Checked = true; 
            }
        }
        private string CalcWorkingDays()
        {
            char[] c = new char[7];
            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                    if (checkBox1.Checked == true)
                        c[i] = '1';
                    else
                        c[i] = '0';
                if (i == 1)
                    if (checkBox2.Checked == true)
                        c[i] = '1';
                    else
                        c[i] = '0';
                if (i == 2)
                    if (checkBox3.Checked == true)
                        c[i] = '1';
                    else
                        c[i] = '0';
                if (i == 3)
                    if (checkBox4.Checked == true)
                        c[i] = '1';
                    else
                        c[i] = '0';
                if (i == 4)
                    if (checkBox5.Checked == true)
                        c[i] = '1';
                    else
                        c[i] = '0';
                if (i == 5)
                    if (checkBox6.Checked == true)
                        c[i] = '1';
                    else
                        c[i] = '0';
                if (i == 6)
                    if (checkBox7.Checked == true)
                        c[i] = '1';
                    else
                        c[i] = '0';
            }
            return new string(c);
        }

        private void button4_Click(object sender, MouseEventArgs e)
        {
            //new plant
            PlantForm NewPlant = new PlantForm(InstituteID,user);
            NewPlant.FormClosed += new FormClosedEventHandler(plant_FormClosed);
            NewPlant.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //exit button ( without save prompt  )
            ChangesMade = false;
            Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //save and close
            if (SaveChanges())
                Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Delete 
            if (DeleteItem.DeleteInstitute(InstituteID))
            {
                ChangesMade = false;
                Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //restore
            if (RestoreItem.RestoreInstitute(InstituteID))
                Close();
        }

        private void InstituteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangesMade && user.ModifyPermission)
            {
                DialogResult resualt = MessageBox.Show("تم عمل تغييرات في البيانات ، هل تريد الحفظ قبل الخروج؟", "تنبيه", MessageBoxButtons.YesNoCancel);
                if (resualt == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!SaveChanges())
                        e.Cancel = true;
                }
                else if (resualt == System.Windows.Forms.DialogResult.Cancel)
                    e.Cancel = true;
                else if (resualt == System.Windows.Forms.DialogResult.No)
                    e.Cancel = false;
            }
        }

        private bool SaveChanges()             //Save DATA
        {
            if (InstituteNameTextBox.Text == "" )
            {
                NotifyMessage NW = new NotifyMessage("لا يمكن الحفظ ، الرجاء التأكد من إدخال الحقول الناقصة",NotifyMessage.NotifyMessageIcon.Error);
                NW.Show();
                Asterisk1.Visible = true;
                tabControl1.SelectedTab = tabPage1;
                InstituteNameTextBox.Focus();
                return false;
            }
            else
            {
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand() { Connection = Connection };
                    SqlDataReader Reader;

                    CustomerID = Convert.ToInt32(CustomerComboBox.SelectedValue);
                    if (CustomerComboBox.Text == "")
                    {
                        Command.CommandText = @"insert into [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] ([name],[del]) output INSERTED.[id]  values (@name,0)";
                        Command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(InstituteNameTextBox.Text);
                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                CustomerID = Reader.GetInt32(0);
                        Reader.Close();
                        Command.Parameters.Clear();
                    }

                    if (NewInstitute)
                    {
                        Command.CommandText = @"insert into [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] 
                        ([name],[customer],[phone1],[phone2],[fax],[email],[manager],[address],[workingdays],[Mobile],[Sector],[Profession],[del]) output INSERTED.[id] Values
                        (@name,@customer,@phone1,@phone2,@fax,@email,@manager,@address,@workingdays,@Mobile,@Sector,@Profession,@del)";
                        Command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(InstituteNameTextBox.Text);
                        Command.Parameters.Add("@customer", SqlDbType.Int).Value = CustomerID;
                        Command.Parameters.Add("@phone1", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone1TextBox.Text);
                        Command.Parameters.Add("@phone2", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone2TextBox.Text);
                        Command.Parameters.Add("@fax", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(FaxTextBox.Text);
                        Command.Parameters.Add("@email", SqlDbType.NVarChar).Value = EmailTextBox.Text;
                        Command.Parameters.Add("@manager", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(InstituteManagerTextBox.Text);
                        Command.Parameters.Add("@address", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(AddressTextBox.Text);
                        Command.Parameters.Add("@workingdays", SqlDbType.NVarChar).Value = CalcWorkingDays();
                        Command.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(MobileTextBox.Text);
                        Command.Parameters.Add("@Sector", SqlDbType.NVarChar).Value = SectorComboBox.Text;
                        Command.Parameters.Add(new SqlParameter("@Profession", SqlDbType.Int)).Value = (object)InstituteProfessionsComboBox.SelectedValue ?? DBNull.Value;
                        
                        Command.Parameters.Add("@del", SqlDbType.Bit).Value = 0;

                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                InstituteID = Reader.GetInt32(0);
                        Reader.Close();
                        Command.Parameters.Clear();
                        NewInstitute = false;
                    }
                    else if (!NewInstitute)
                    {
                        Command.CommandText = @"update [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] SET 
                        [name] = @name,[customer] = @customer,[phone1] = @phone1,[phone2] = @phone2,[fax] = @fax
                        ,[email] = @email,[manager] = @manager,[address] = @address,[workingdays] = @workingdays
                        ,[Mobile] = @Mobile,[Sector] = @Sector,[Profession] = @Profession where [id]=" + InstituteID;
                        Command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(InstituteNameTextBox.Text);
                        Command.Parameters.Add("@customer", SqlDbType.Int).Value = CustomerID;
                        Command.Parameters.Add("@phone1", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone1TextBox.Text);
                        Command.Parameters.Add("@phone2", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(Phone2TextBox.Text);
                        Command.Parameters.Add("@fax", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(FaxTextBox.Text);
                        Command.Parameters.Add("@email", SqlDbType.NVarChar).Value = EmailTextBox.Text;
                        Command.Parameters.Add("@manager", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(InstituteManagerTextBox.Text);
                        Command.Parameters.Add("@address", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(AddressTextBox.Text);
                        Command.Parameters.Add("@workingdays", SqlDbType.NVarChar).Value = CalcWorkingDays();
                        Command.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(MobileTextBox.Text);
                        Command.Parameters.Add("@Sector", SqlDbType.NVarChar).Value = SectorComboBox.Text;
                        Command.Parameters.Add(new SqlParameter("@Profession", SqlDbType.Int)).Value = (object)InstituteProfessionsComboBox.SelectedValue ?? DBNull.Value;
                        Command.Parameters.Add("@del", SqlDbType.Bit).Value = 0;
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                    }

                    NotifyMessage NW = new NotifyMessage("تم حفظ بيانات المنشأة", NotifyMessage.NotifyMessageIcon.Saved);
                    NW.Show();
                    
                    ChangesMade = false;
                    return true;
                }
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //doubleclick a plant row
            if (PlantsDGV.Rows.Count > 0)
                if (e.RowIndex >= 0)
                    OpenPlantWindow();
        }

        private void RefreshPlantDGV()
        {
            //Refresh DataGridView data
            Data.Clear();
            PlantsDGV.DataSource = null;
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id] as [#],[plant] as [الوحدة],[technician] as [الفني المسؤول],[contract_type] as [نوع العقد],[LastStatus] as [الحالة الأخيرة]
                FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants_view] where [del]=0 and [institute_id]=" + InstituteID, Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(Data);
                PlantsDGV.DataSource = Data;
                PlantsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PlantsDGV.Columns[0].Width = 30;
            }
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.Focused)
                VerifyCustomer();
        }

        private void CustomerComboBox_Leave(object sender, EventArgs e)
        {
            VerifyCustomer();
        }

        private void CustomerComboBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.Focused)
                ChangesMade = true;
        }

        private void VerifyCustomer()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"select [id],[name] from [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] where [del]=0 and [name]='" + CustomerComboBox.Text + "'", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            CustomerID = Reader.GetInt32(0);
                        InfoPictureBox.Visible = false;
                    }
                else
                {
                    CustomerID = 0;
                    CustomerComboBox.Text = "";
                    InfoPictureBox.Visible = true;
                }
                Reader.Close();
                LoadCustomerInfo(CustomerID);
            }
        }

        private void LoadCustomerInfo(int CustomerID)
        {
            CustomerNOTextBox.Text = "";
            CustomerNameTextBox.Text = "";
            CustomerMobileTextBox.Text = "";
            CustomerManagerTextBox.Text = "";


            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"select [id],[name],[mobile],[manager],[CustomerPhone1],[CustomerPhone2] from [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] where [id]=" + CustomerID, Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            CustomerNOTextBox.Text = Convert.ToString(Reader.GetInt32(0));
                        if (!Reader.IsDBNull(1))
                        {
                            CustomerNameTextBox.Text = Reader.GetString(1);
                            CustomerComboBox.SelectedIndex = CustomerComboBox.FindStringExact(Reader.GetString(1));
                        }
                        if (!Reader.IsDBNull(2))
                            CustomerMobileTextBox.Text = Reader.GetString(2);
                        if (!Reader.IsDBNull(3))
                            CustomerManagerTextBox.Text = Reader.GetString(3);

                    }
            }
        }

        private void NewPlantButton_Click(object sender, EventArgs e)
        {
            CreateNewPlant();
        }

        private void EditPlantButton_Click(object sender, EventArgs e)
        {
            //EditPlantButton
            OpenPlantWindow();
        }

        private void OpenPlantWindow()
        {
            if (PlantsDGV.Rows.Count > 0)
                if (PlantsDGV.CurrentRow.Index >= 0)
                {
                    PlantForm OpenPlant = new PlantForm(Convert.ToInt32(PlantsDGV.SelectedCells[0].Value), user, 1, 0);
                    OpenPlant.FormClosed += new FormClosedEventHandler(plant_FormClosed);
                    OpenPlant.Show();
                }
        }

        private void DeletePlantButton_Click(object sender, EventArgs e)
        {
            DeletePlant();
        }

        private void RefreshPlantsButton_Click(object sender, EventArgs e)
        {
            RefreshPlantDGV();
        }

        private void InstituteProfessionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstituteProfessionsComboBox.Focused)
                ChangesMade = true;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("لم يتم العثور على الزبون المحدد ، سيتم إنشاء زبون جديد باسم المنشأة" , InfoPictureBox, InfoPictureBox.Width, InfoPictureBox.Height, 5000);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: break;
                case 1: RefreshPlantDGV(); break;
            }
        }


    }
}
