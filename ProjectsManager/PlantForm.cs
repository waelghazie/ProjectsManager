using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ProjectsManager
{
    public partial class PlantForm : Form
    {

        /// <summary>
        /// New Plant window
        /// </summary>
        public PlantForm(User user)
        {
            this.NewPlant = true;
            this.user = user;
            InitializeComponent();
        }

        /// <summary>
        /// New Plant window
        /// </summary>
        public PlantForm(int InstituteID, User user)
        {
            this.InstituteID = InstituteID;
            this.NewPlant = true;
            this.user = user;
            InitializeComponent();
        }

        /// <summary>
        /// Old Plant Window
        /// </summary>
        public PlantForm(int PlantID, User user, int SelectedTab, int SelectedVisitID)
        {
            this.PlantID = PlantID;
            this.user = user;
            this.SelectedTab = SelectedTab;
            this.SelectedVisitID = SelectedVisitID;
            this.NewPlant = false;
            InitializeComponent();

            PlantNoTextBox.Text = Convert.ToString(PlantID);
        }

        int PlantID, InstituteID, ContractorID, CustomerID;
        string InstituteName, ContractorName, report_name, PhotoFolderName = "";
        bool PhotosListed = false;
        bool NewPlant = false;

        User user;
        bool PlantChangesMade = false;
        bool VisitChangesMade = false;
        //bool SafeToExitWindow = true;

        int SelectedTab, SelectedVisitID;
        DataTable PhoneCallsLogDataTable;
        DataTable VisitsData;

        Dictionary<int, string> ContractorsDic = new Dictionary<int, string>();
        Dictionary<int, string> InstitutesDic = new Dictionary<int, string>();
        Dictionary<int, string> TechniciansDic = new Dictionary<int, string>();
        Dictionary<int, string> PlantTypeDic = new Dictionary<int, string>();

        private bool NewVisit = false;

        private void PlantForm_Load(object sender, EventArgs e)
        {
            GetUserPermissions();

            PhoneCallsLogDataTable = new DataTable();
            VisitsData = new DataTable();

            PhotosStatusLabel.Text = "";

            SaveVisitButton.Visible = false;
            CancelVisitChangesButton.Visible = false;

            //Load Data to PlantType Combobox
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[PlantType] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantType]", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        if (!Reader.IsDBNull(0))
                            PlantTypeDic.Add(Reader.GetInt32(0), Reader.GetString(1));

                    PlantTypeComboBox.DisplayMember = "Value";
                    PlantTypeComboBox.ValueMember = "Key";
                    PlantTypeComboBox.DataSource = new BindingSource(PlantTypeDic, null);
                    PlantTypeComboBox.SelectedValue = 0;
                }
            }

            //Load Data to Contractors Combobox
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"select [id],[name] from [" + Settings1.Default.DatabaseName + @"].[dbo].[contractors]", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        if (!Reader.IsDBNull(0))
                            ContractorsDic.Add(Reader.GetInt32(0), Reader.GetString(1));

                    ContractorComboBox.DisplayMember = "Value";
                    ContractorComboBox.ValueMember = "Key";
                    ContractorComboBox.DataSource = new BindingSource(ContractorsDic, null);
                    ContractorComboBox.SelectedValue = 0;
                }
            }

            //Load Data to Institutes Combobox
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[name] FROM [" + Settings1.Default.DatabaseName +
                "].[dbo].[institutes] where [del]=0 ", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        InstitutesDic.Add(Reader.GetInt32(0), Reader.GetString(1));

                    InstituteComboBox.DisplayMember = "Value";
                    InstituteComboBox.ValueMember = "Key";
                    InstituteComboBox.DataSource = new BindingSource(InstitutesDic, null);
                    InstituteComboBox.SelectedValue = 0;
                }
            }

            //Load Visor ComboBox Data
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                TechniciansDic.Add(0, " ");

                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[TechnicianName] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[Technicians]", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        TechniciansDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                    Reader.Close();

                    VisorComboBox.DisplayMember = "Value";
                    VisorComboBox.ValueMember = "Key";
                    VisorComboBox.DataSource = new BindingSource(TechniciansDic, null);
                    VisorComboBox.SelectedValue = 0;

                    AccompanyingComboBox.DisplayMember = "Value";
                    AccompanyingComboBox.ValueMember = "Key";
                    AccompanyingComboBox.DataSource = new BindingSource(TechniciansDic, null);
                    AccompanyingComboBox.SelectedValue = 0;
                }
            }

            // Load Plant Data
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                if (NewPlant)
                {
                    PlantNoTextBox.Text = "*";
                    this.Text = "وحدة معالجة جديدة";
                    DeleteButton.Visible = false;
                    RestoreButton.Visible = false;

                    StartDatePicker.Value = DateTime.Now;
                    EndDatePicker.Value = DateTime.Now;
                    PlantStartingDatePicker.Value = DateTime.Now;

                    if (InstituteID > 0)
                    { InstituteComboBox.SelectedValue = InstituteID; }
                    else
                    {
                        InstituteComboBox.Text = "";
                        InstituteComboBox.Enabled = true;
                    }

                    SqlCommand Command = new SqlCommand(@"SELECT [customer_id],[customer] from [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes_view] where [id]=" + InstituteID, Connection);
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                            if (!Reader.IsDBNull(0))
                            {
                                CustomerID = Reader.GetInt32(0);
                                CustomerTextBox.Text = Reader.GetString(1);
                            }
                    Reader.Close();

                }
                else if (!NewPlant)
                {
                    SqlCommand Command = new SqlCommand(
                    @"SELECT [plant],[technician],[institute_id],[institute],[contractor_id],[contractor]
                    ,[contractor_phone1],[contractor_phone2],[customer],[contract_type]
                    ,[report_name],[start_time],[end_time],[del],[PhotoFolderName],[LastStatus],[PlantDetails],[CustomerID]
                    ,[PlantTypeID],[PlantStatus],[PlantStartingDate]
                    FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants_view] where [id]=" + PlantID, Connection);
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                        {
                            if (!Reader.IsDBNull(0))
                                PlantNameTextBox.Text = Reader.GetString(0);
                            if (!Reader.IsDBNull(1))
                                PlantTechPersonTextBox.Text = Reader.GetString(1);
                            if (!Reader.IsDBNull(2))
                            {
                                InstituteID = Reader.GetInt32(2);
                                InstituteComboBox.SelectedValue = Reader.GetInt32(2);
                            }
                            if (!Reader.IsDBNull(3))
                                InstituteName = Reader.GetString(3); //unused
                            if (!Reader.IsDBNull(4))
                                ContractorComboBox.SelectedValue = Reader.GetInt32(4);
                            if (!Reader.IsDBNull(5))
                                ContractorName = Reader.GetString(5);
                            if (!Reader.IsDBNull(6))
                                ContractorPhone1TextBox.Text = Reader.GetString(6);
                            if (!Reader.IsDBNull(7))
                                ContractorPhone2TextBox.Text = Reader.GetString(7);
                            if (!Reader.IsDBNull(8))
                                CustomerTextBox.Text = Reader.GetString(8);
                            if (!Reader.IsDBNull(9))
                                ContractTypeTextBox.Text = Reader.GetString(9);
                            if (!Reader.IsDBNull(10))
                                report_name = Reader.GetString(10);
                            if (!Reader.IsDBNull(11))
                                StartDatePicker.Value = Reader.GetDateTime(11);
                            if (!Reader.IsDBNull(12))
                                EndDatePicker.Value = Reader.GetDateTime(12);
                            if (!Reader.IsDBNull(13))
                                if (Reader.GetBoolean(13) == true) //Deleted Plant
                                {
                                    groupBox1.Enabled = false; groupBox2.Enabled = false; groupBox3.Enabled = false;
                                    groupBox4.Enabled = false; groupBox5.Enabled = false;
                                    panel3.Enabled = false;

                                    SaveButton.Visible = false; CallsDGV.Enabled = false;
                                    VisitsDGV.Enabled = false; VisitsToolBar.Enabled = false; CallsToolBar.Enabled = false;
                                }
                                else
                                { RestoreButton.Visible = false; }
                            if (!Reader.IsDBNull(14))
                                PhotoFolderName = Reader.GetString(14);
                            if (!Reader.IsDBNull(15))
                                PlantLastStatusTextBox.Text = Reader.GetString(15);
                            if (!Reader.IsDBNull(16))
                                PlantDescTextBox.Text = Reader.GetString(16);
                            if (!Reader.IsDBNull(17))
                                CustomerID = Reader.GetInt32(17);
                            if (!Reader.IsDBNull(18))
                                PlantTypeComboBox.SelectedValue = Reader.GetInt32(18);
                            if (!Reader.IsDBNull(19))
                                PlantStatusComboBox.SelectedIndex = PlantStatusComboBox.FindStringExact(Reader.GetString(19));
                            if (!Reader.IsDBNull(20))
                                PlantStartingDatePicker.Value = Reader.GetDateTime(20);
                        }
                    Reader.Close();

                    this.Text = "وحدة معالجة" + " [" + PlantNameTextBox.Text + "] " + "التابعة لمنشأة" + " [" + InstituteName + "]";

                    if (PhotoFolderName == "")
                    { PhotosStatusLabel.Text = "لم يتم تعيين مجلد الصور الخاص بالوحدة"; }
                    LoadContractorInfo(Convert.ToInt32(ContractorComboBox.SelectedValue));
                }
            }
        }

        private void RefreshCallsLog()
        {
            //load Calls information for this plant
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                PhoneCallsLogDataTable.Clear();
                CallsDGV.DataSource = null;

                SqlCommand Command = new SqlCommand(@"SELECT [id] as [#],[TimeStamp] as [تاريخ الاتصال],[Text] as  [نص المكالمة],[ByUserName] as [ادخال السجل من قبل]
                    FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PhoneCallsLogView] where [PlantID]=" + PlantID, Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(PhoneCallsLogDataTable);
                CallsDGV.DataSource = PhoneCallsLogDataTable;
                CallsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                CallsDGV.Columns[0].Width = 30;
            }
        }

        private void RefreshVisitsDGV()
        {
            //load Service Visits information for this plant

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                VisitsData.Clear();
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [VisitID],[ProgramDate] as [تاريخ الزيارة],[TechnicianName] as [فني الورشة],[AccompanyingName] as [مرافق الفني]
                    FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantServiceView] where [PlantID]=" + PlantID, Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(VisitsData);
                VisitsDGV.DataSource = VisitsData;
                VisitsDGV.Columns[0].Visible = false;
                VisitsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                VisitsDGV.Sort(VisitsDGV.Columns[1], ListSortDirection.Ascending);

                

                
            }
        }

        private void GetUserPermissions()
        {
            if (user.ReadPermission)
            { }
            else
            { MainToolBar.Enabled = false; tabControl1.Visible = false; groupBox2.Visible = false; }

            if (user.ModifyPermission)
            { }
            else
            {
                groupBox1.Enabled = false; groupBox2.Enabled = false; groupBox3.Enabled = false; 
                groupBox4.Enabled = false; groupBox5.Enabled = false;
                VisitsToolBar.Visible = false;
                PhotosPathButton.Visible = false; SaveButton.Visible = false;
                NewVisitButton.Visible = false; EditVisitButton.Visible = false; NewCallLogButton.Visible = false;
            }

            if (user.CreatePermission)
            { }
            else
            { NewVisitButton.Visible = false; NewCallLogButton.Visible = false; }

            if (user.DeletePermission)
            { }
            else
            { DeleteButton.Visible = false; RestoreButton.Visible = false; }
        }

        private void PlantForm_Shown(object sender, EventArgs e)
        {
            PlantNameTextBox.Focus();
            switch (SelectedTab)
            {
                case 1: tabControl1.SelectedTab = tabPage1; break;
                case 2: tabControl1.SelectedTab = tabPage2; break;
                case 3: tabControl1.SelectedTab = tabPage4; break;
                case 4: tabControl1.SelectedTab = tabPage3; break;
            }

            
        }

        private void LoadVisitInfo()
        {
            try
            {
                if (VisitsDGV.Rows.Count > 0)
                    if (VisitsDGV.SelectedCells[0].RowIndex >= 0)
                    {
                        VisorComboBox.SelectedValue = 0;
                        AccompanyingComboBox.SelectedValue = 0;
                        VisitTextBox.Text = "";
                        VisitNoteTextBox.Text = "";
                        ServiceTextBox.Text = "";
                        ServiceNoteTextBox.Text = "";
                        ProgramIDtextBox.Text = "";

                        ServiceTextBox.Rtf.Remove(0);
                        ServiceNoteTextBox.Rtf.Remove(0);

                        using (SqlConnection Connection = AppConnection.GetConnection())
                        {
                            Connection.Open();

                            SqlCommand Command = new SqlCommand(@"SELECT [ProgramDate],[TechnicianID],[AccompanyingID]
                        ,[VisitText],[VisitNote],[ServiceText],[ServiceNote],[VisitID],[ProgramID]
                        FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PlantServiceView] where [VisitID]=" + VisitsDGV.SelectedCells[0].Value.ToString(), Connection);
                            SqlDataReader Reader = Command.ExecuteReader();
                            if (Reader.HasRows)
                                while (Reader.Read())
                                {
                                    if (!Reader.IsDBNull(0))
                                        ProgramDatePicker.Value = Reader.GetDateTime(0);
                                    if (!Reader.IsDBNull(1))
                                        VisorComboBox.SelectedValue = Reader.GetInt32(1);
                                    if (!Reader.IsDBNull(2))
                                        AccompanyingComboBox.SelectedValue = Reader.GetInt32(2);
                                    if (!Reader.IsDBNull(3))
                                        VisitTextBox.Text = Reader.GetString(3);
                                    if (!Reader.IsDBNull(4))
                                        VisitNoteTextBox.Text = Reader.GetString(4);
                                    if (!Reader.IsDBNull(5))
                                        ServiceTextBox.Rtf = Reader.GetString(5);
                                    if (!Reader.IsDBNull(6))
                                        ServiceNoteTextBox.Rtf = Reader.GetString(6);
                                    if (!Reader.IsDBNull(7))
                                        VisitIDTextBox.Text = Convert.ToString(Reader.GetInt32(7));
                                    if (!Reader.IsDBNull(8))
                                        ProgramIDtextBox.Text = Convert.ToString(Reader.GetInt32(8));
                                }
                        }
                    }
            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool SavePlantChanges()
        {
            //Save Plant Data

            if (PlantNameTextBox.Text == "" || InstituteComboBox.Text == "")
            {
                NotifyMessage nw = new NotifyMessage("لا يمكن الحفظ ، الرجاء التأكد من إدخال الحقول الناقصة", NotifyMessage.NotifyMessageIcon.Error);
                nw.Show();
                Asterisk1.Visible = true; Asterisk2.Visible = true;
                return false;
            }
            else
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    if (NewPlant)
                    {
                        SqlCommand Command = new SqlCommand(
                        @"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[plants]
                        ([name],[institute],[technician],[contractor],[contract_type],[start_time],[end_time],[del],[PhotoFolderName],[LastStatus],[PlantDetails],[PlantTypeID],[PlantStatus],[PlantStartingDate]) 
                        output INSERTED.[id] VALUES
                        (@name,@institute,@technician,@contractor,@contract_type,@start_time,@end_time,@del,@PhotoFolderName,@LastStatus,@PlantDetails,@PlantTypeID,@PlantStatus,@PlantStartingDate)", Connection);
                        Command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(PlantNameTextBox.Text);
                        Command.Parameters.Add("@institute", SqlDbType.Int).Value = InstituteComboBox.SelectedValue;
                        Command.Parameters.Add("@technician", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(PlantTechPersonTextBox.Text);
                        Command.Parameters.Add(new SqlParameter("@contractor", SqlDbType.Int)).Value = (object)ContractorComboBox.SelectedValue ?? DBNull.Value;
                        Command.Parameters.Add("@contract_type", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(ContractTypeTextBox.Text);
                        Command.Parameters.Add("@start_time", SqlDbType.DateTime).Value = StartDatePicker.Value;
                        Command.Parameters.Add("@end_time", SqlDbType.DateTime).Value = EndDatePicker.Value;
                        Command.Parameters.Add("@del", SqlDbType.Bit).Value = 0;
                        Command.Parameters.Add("@PhotoFolderName", SqlDbType.NVarChar).Value = PhotoFolderName;
                        Command.Parameters.Add("@LastStatus", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(PlantLastStatusTextBox.Text);
                        Command.Parameters.Add("@PlantDetails", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(PlantDescTextBox.Text);
                        Command.Parameters.Add(new SqlParameter("@PlantTypeID", SqlDbType.Int)).Value = (object)PlantTypeComboBox.SelectedValue ?? DBNull.Value;
                        Command.Parameters.Add(new SqlParameter("@PlantStatus", SqlDbType.NVarChar)).Value = (object)PlantStatusComboBox.Text ?? DBNull.Value;
                        Command.Parameters.Add(new SqlParameter("@PlantStartingDate", SqlDbType.DateTime)).Value = (object)PlantStartingDatePicker.Value ?? DBNull.Value;

                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                PlantID = Reader.GetInt32(0);
                        Reader.Close();
                        Command.Parameters.Clear();

                        NewPlant = false;
                    }
                    else if (!NewPlant)
                    {
                        SqlCommand Command = new SqlCommand(
                        @"update [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] set 
                        [name]=@name,[technician]=@technician,[institute]=@institute,[contractor]=@contractor,[contract_type]=@contract_type,[start_time]=@start_time,[end_time]=@end_time
                        ,[PhotoFolderName]=@PhotoFolderName,[LastStatus]=@LastStatus,[PlantDetails]=@PlantDetails,[PlantTypeID]=@PlantTypeID,[PlantStatus]=@PlantStatus,[PlantStartingDate]=@PlantStartingDate 
                        where [id]=@PlantID", Connection);
                        Command.Parameters.Add("@name", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(PlantNameTextBox.Text);
                        Command.Parameters.Add("@technician", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(PlantTechPersonTextBox.Text);
                        Command.Parameters.Add("@institute", SqlDbType.Int).Value = InstituteComboBox.SelectedValue;
                        Command.Parameters.Add(new SqlParameter("@contractor", SqlDbType.Int)).Value = (object)ContractorComboBox.SelectedValue ?? DBNull.Value;
                        Command.Parameters.Add("@contract_type", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(ContractTypeTextBox.Text);
                        Command.Parameters.Add("@start_time", SqlDbType.DateTime).Value = StartDatePicker.Value;
                        Command.Parameters.Add("@end_time", SqlDbType.DateTime).Value = EndDatePicker.Value;
                        Command.Parameters.Add("@PhotoFolderName", SqlDbType.NVarChar).Value = PhotoFolderName;
                        Command.Parameters.Add("@PlantID", SqlDbType.Int).Value = PlantID;
                        Command.Parameters.Add("@LastStatus", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(PlantLastStatusTextBox.Text);
                        Command.Parameters.Add("@PlantDetails", SqlDbType.NVarChar).Value = ReplaceChar.ReplaceAChar(PlantDescTextBox.Text);
                        Command.Parameters.Add(new SqlParameter("@PlantTypeID", SqlDbType.Int)).Value = (object)PlantTypeComboBox.SelectedValue ?? DBNull.Value;
                        Command.Parameters.Add(new SqlParameter("@PlantStatus", SqlDbType.NVarChar)).Value = (object)PlantStatusComboBox.Text ?? DBNull.Value;
                        Command.Parameters.Add(new SqlParameter("@PlantStartingDate", SqlDbType.DateTime)).Value = (object)PlantStartingDatePicker.Value ?? DBNull.Value;

                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                    }
                    NotifyMessage nm = new NotifyMessage(" تم حفظ الوحدة", NotifyMessage.NotifyMessageIcon.Saved);
                    nm.Show();

                    PlantChangesMade = false;
                    return true;
                }
        }

        private void PlantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (user.ModifyPermission)
            {
                if (!VerifyPlantData())
                {
                    e.Cancel = true;
                    return;
                }
                if (!VerifyVisitData())
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private bool VerifyPlantData()         //Safe to Exit windows without Plant Data loss and according to user desire
        {                                      //true: Exit Without Dataloss - false: Don't Exit
            if (PlantChangesMade)
            {
                DialogResult resualt = MessageBox.Show("هل تريد حفظ بيانات الوحدة؟", "إغلاق", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (resualt == DialogResult.Yes)
                {
                    if (SavePlantChanges())
                        return true;
                    else
                        return false;
                }
                else if (resualt == DialogResult.No)
                    return true;
                else if (resualt == DialogResult.Cancel)
                    return false;
            }
            else
                return true;
            return true;
        }

        private bool VerifyVisitData()          //Safe to Exit windows without Current Visit Data loss and according to user desire
        {                                       //true: Exit Without Dataloss - false: Don't Exit
            if (VisitChangesMade)
            {
                DialogResult resualt = MessageBox.Show("هل تريد حفظ بيانات الزيارة؟", "إغلاق", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (resualt == DialogResult.Yes)
                {
                    if (SaveVisitData())
                        return true;
                    else
                        return false;
                }
                else if (resualt == DialogResult.No)
                    return true;
                else if (resualt == DialogResult.Cancel)
                    return false;
            }
            else
                return true;
            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (PlantNameTextBox.Focused)
                PlantChangesMade = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (StartDatePicker.Focused)
                PlantChangesMade = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (EndDatePicker.Focused)
                PlantChangesMade = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (ContractTypeTextBox.Focused)
                PlantChangesMade = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (PlantTechPersonTextBox.Focused)
                PlantChangesMade = true;
        }

        private void PB_MouseClick(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            PictureBox pic = (PictureBox)control;
            pictureBox1.Image = pic.Image;
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            //Draw Photos
            if (!NewPlant)
            {
                if (!PhotosListed)
                {
                    if (Settings1.Default.PhotosPath == "")
                    { PhotosStatusLabel.Text = ""; }
                    else if (PhotoFolderName != "")
                    {
                        PhotosPathTextBox.Text = Settings1.Default.PhotosPath + "\\" + PhotoFolderName;
                        DrawPhotos();
                    }

                }
            }
        }

        private void DrawPhotos()
        {
            try
            {
                DirectoryInfo PathFolder = new DirectoryInfo(PhotosPathTextBox.Text);
                FileInfo[] Images = PathFolder.GetFiles();

                panel2.Controls.Clear();

                int X_Location = 0, Y_Location = 0;
                foreach (FileInfo img in Images)
                {
                    if (img.Extension.ToLower() == ".png" || img.Extension.ToLower() == ".jpg" || img.Extension.ToLower() == ".gif" || img.Extension.ToLower() == ".jpeg" || img.Extension.ToLower() == ".bmp" || img.Extension.ToLower() == ".tif")
                    {
                        PictureBox PB = new PictureBox();
                        PB.Image = Image.FromFile(img.FullName);
                        PB.BackColor = Color.Black;
                        PB.Location = new Point(X_Location, Y_Location);
                        PB.Size = new Size(90, 90);
                        PB.SizeMode = PictureBoxSizeMode.StretchImage;
                        PB.MouseClick += new MouseEventHandler(PB_MouseClick);
                        panel2.Controls.Add(PB);

                        X_Location = X_Location + 100;
                    }
                }
                PhotosListed = true;
            }
            catch (Exception exp)
            { MessageBox.Show(exp.Message + exp.InnerException, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (Settings1.Default.PhotosPath != "")
            {
                FolderBrowser FB = new FolderBrowser();
                FB.ShowDialog();
                if (FB.FolderName != "")
                {
                    PhotoFolderName = FB.FolderName;
                    PhotosPathTextBox.Text = Settings1.Default.PhotosPath + @"\" + PhotoFolderName;
                    PhotosStatusLabel.Text = "";

                    DrawPhotos();

                    PlantChangesMade = true;
                }
            }
            else
            {
                NotifyMessage nm = new NotifyMessage("يرجى تعيين مجلد الصور ضمن الاعدادات", NotifyMessage.NotifyMessageIcon.Info);
                nm.Show();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //Exit Window button (without Save)
            PlantChangesMade = false;

            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (SavePlantChanges())
                Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Delete Plant
            if (DeleteItem.DeletePlant(PlantID))
            {
                PlantChangesMade = false;
                Close();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (RestoreItem.RestorePlant(PlantID))
            {
                Close();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (ContractorComboBox.Focused)
                PlantChangesMade = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContractorComboBox.Focused)
                VerifyContractor();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            VerifyContractor();
        }

        private void VerifyContractor()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"select [id],[name] from [" + Settings1.Default.DatabaseName + @"].[dbo].[contractors] where [name] = '" + ContractorComboBox.Text + "'", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            ContractorID = Reader.GetInt32(0);
                    }
                else
                {
                    ContractorName = "";
                    ContractorID = 0;
                    ContractorComboBox.Text = "";
                }

            }
            LoadContractorInfo(ContractorID);
        }

        private void LoadContractorInfo(int ContractorID)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand(@"select [id],[name],[phone1],[phone2] from [" + Settings1.Default.DatabaseName + @"].[dbo].[contractors] where [id]=" + ContractorID, Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            ContractorNoTextBox.Text = Convert.ToString(Reader.GetInt32(0));
                        if (!Reader.IsDBNull(1))
                        { ContractorNameTextBox.Text = Reader.GetString(1); ContractorComboBox.SelectedIndex = ContractorComboBox.FindStringExact(Reader.GetString(1)); }
                        if (!Reader.IsDBNull(2))
                            ContractorPhone1TextBox.Text = Reader.GetString(2);
                        if (!Reader.IsDBNull(3))
                            ContractorPhone2TextBox.Text = Reader.GetString(3);
                    }
                else
                {
                    ContractorComboBox.Text = "";
                    ContractorNoTextBox.Text = "";
                    ContractorNameTextBox.Text = "";
                    ContractorPhone1TextBox.Text = "";
                    ContractorPhone2TextBox.Text = "";
                }
            }
        }

        private void CallsDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CallsDGV.Rows.Count > 0)
                if (e.RowIndex >= 0)
                {
                    CallWindow OpenCallWindow = new CallWindow(user, Convert.ToInt32(CallsDGV.SelectedCells[0].Value));
                    OpenCallWindow.Show();
                }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (PlantDescTextBox.Focused)
                PlantChangesMade = true;
        }

        private void VisitsDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (VisitsDGV.Rows.Count > 0)
                if (e.RowIndex >= 0)
                    LoadVisitInfo();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (VisitsDGV.Focused)
                LoadVisitInfo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InstituteComboBox.Enabled = true;
        }

        private void InstituteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstituteComboBox.Focused)
                VerifyInstitute();
        }

        private void VerifyInstitute()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"select [id],[name],[customer],[customer_id] from [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes_view] where [name] = '" + InstituteComboBox.Text + "'", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        CustomerTextBox.Text = Reader.GetString(2);
                        CustomerID = Reader.GetInt32(3);
                    }

                if (!Reader.HasRows)
                {
                    InstituteComboBox.Text = "";
                    CustomerTextBox.Text = "";
                }

            }
        }

        private void InstituteComboBox_TextChanged(object sender, EventArgs e)
        {
            if (InstituteComboBox.Focused)
                PlantChangesMade = true;
        }

        private void InstituteComboBox_Leave(object sender, EventArgs e)
        {
            VerifyInstitute();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (NewPlant)
            {
                DialogResult DR = MessageBox.Show("هل ترغب بحفظ التغييرت؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    SavePlantChanges();
                }
            }
            else
            {
                AddPlantToProgram NewAdd = new AddPlantToProgram(CustomerID, InstituteID, PlantID, user);
                NewAdd.ShowDialog();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (NewPlant)
            {
                DialogResult DR = MessageBox.Show("هل ترغب بحفظ التغييرت؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    SavePlantChanges();
                }
            }
            else
            {
                ReminderCreator RC = new ReminderCreator(CustomerID, InstituteID, PlantID, user);
                RC.ShowDialog();
            }
        }

        private void OpenRichEditorButton_Click(object sender, EventArgs e)
        {
            RTFeditorForm RTForm = new RTFeditorForm(ServiceTextBox.Rtf, ServiceTextBox.ReadOnly);
            RTForm.ShowDialog();
            ServiceTextBox.Rtf = RTForm.RichText;
            VisitChangesMade = true;
        }

        private void OpenRichEditorButton2_Click(object sender, EventArgs e)
        {
            RTFeditorForm RTForm = new RTFeditorForm(ServiceNoteTextBox.Rtf, ServiceTextBox.ReadOnly);
            RTForm.ShowDialog();
            ServiceNoteTextBox.Rtf = RTForm.RichText;
            VisitChangesMade = true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //Edit Service Text for Visit
            EnableServiceBoxesForEdit();
        }
        
        private void NewButton_Click(object sender, EventArgs e)
        {
            //New Visit
            EnableVisitBoxesForNewVisit();
            NewVisit = true;
        }

        private void SaveVisitButton_Click(object sender, EventArgs e)
        {
            //Save Visit Data

            if (PlantChangesMade || CustomerID == 0 || InstituteID == 0 || PlantID == 0)
            {
                DialogResult DR = MessageBox.Show("يجب حفظ معلومات الوحدة. هل ترغب بالحفظ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                    if (SavePlantChanges())
                        if (SaveVisitData())
                        {
                            DisableVisitBoxes();
                            RefreshVisitsDGV();
                            LoadVisitInfo();
                        }
            }
            else if (!PlantChangesMade)
                if (SaveVisitData())
                {
                    DisableVisitBoxes();
                    RefreshVisitsDGV();
                    LoadVisitInfo();
                }
        }

        private bool SaveVisitData()
        {
            if (Convert.ToInt32(VisorComboBox.SelectedValue) == 0)
            {
                NotifyMessage nm = new NotifyMessage(@"لا يمكن حفظ تقرير الصيانة ، يرجى تحديد فني الورشة !", NotifyMessage.NotifyMessageIcon.Error);
                nm.Show();
                Asterisk3.Visible = true;
                return false;
            }
            else
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand() { Connection = Connection };

                    if (NewVisit)
                    {
                        //Create New Program
                        int ProgramID = 0;

                        Command.CommandText = @"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[Programs]
                        ([ProgramDate],[TechnicianID],[AccompanyingID],[ProgramText],[TimeStamp],[ByUserID]) output INSERTED.[id] VALUES
                        (@ProgramDate,@TechnicianID,@AccompanyingID,@ProgramText,@TimeStamp,@ByUserID)";
                        Command.Parameters.Add("@ProgramDate", SqlDbType.DateTime).Value = ProgramDatePicker.Value.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"));
                        Command.Parameters.Add("@TechnicianID", SqlDbType.Int).Value = VisorComboBox.SelectedValue;
                        Command.Parameters.Add(new SqlParameter("@AccompanyingID", SqlDbType.Int)).Value = (object)AccompanyingComboBox.SelectedValue ?? DBNull.Value;
                        Command.Parameters.Add("@ProgramText", SqlDbType.NVarChar).Value = @"برنامج خدمة مولد بشكل تلقائي ، لا تقم بالحذف";
                        Command.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"));
                        Command.Parameters.Add("@ByUserID", SqlDbType.Int).Value = user.UserID;
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                ProgramID = Reader.GetInt32(0);
                        Reader.Close();
                        Command.Parameters.Clear();

                        //Create new Visit linked to Created Program
                        Command.CommandText = @"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantService]
                        ([CustomerID],[InstituteID],[PlantID],[VisitText],[VisitNote],[ServiceText],[ServiceNote],[ProgramID]) VALUES
                        (@CustomerID,@InstituteID,@PlantID,@VisitText,@VisitNote,@ServiceText,@ServiceNote,@ProgramID)";
                        Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID;
                        Command.Parameters.Add("@InstituteID", SqlDbType.Int).Value = InstituteID;
                        Command.Parameters.Add("@PlantID", SqlDbType.Int).Value = PlantID;
                        Command.Parameters.Add("@VisitText", SqlDbType.NVarChar).Value = VisitTextBox.Text;
                        Command.Parameters.Add("@VisitNote", SqlDbType.NVarChar).Value = VisitNoteTextBox.Text;
                        Command.Parameters.Add("@ServiceText", SqlDbType.NVarChar).Value = ServiceTextBox.Rtf;
                        Command.Parameters.Add("@ServiceNote", SqlDbType.NVarChar).Value = ServiceNoteTextBox.Rtf;
                        Command.Parameters.Add("@ProgramID", SqlDbType.Int).Value = ProgramID;
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();

                        NotifyMessage nm = new NotifyMessage("تم اضافة بيانات الزيارة", NotifyMessage.NotifyMessageIcon.Saved);
                        nm.Show();
                        VisitChangesMade = false;
                        Asterisk3.Visible = false;
                        return true;
                    }
                    else if (!NewVisit)
                    {
                        Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantService] SET 
                        [CustomerID] = @CustomerID,[InstituteID] = @InstituteID,[PlantID] = @PlantID,[VisitText] = @VisitText
                        ,[VisitNote] = @VisitNote,[ServiceText] = @ServiceText,[ServiceNote] = @ServiceNote
                        WHERE [id]=" + VisitsDGV.SelectedCells[0].Value;
                        Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID;
                        Command.Parameters.Add("@InstituteID", SqlDbType.Int).Value = InstituteID;
                        Command.Parameters.Add("@PlantID", SqlDbType.Int).Value = PlantID;
                        Command.Parameters.Add("@VisitText", SqlDbType.NVarChar).Value = VisitTextBox.Text;
                        Command.Parameters.Add("@VisitNote", SqlDbType.NVarChar).Value = VisitNoteTextBox.Text;
                        Command.Parameters.Add("@ServiceText", SqlDbType.NVarChar).Value = ServiceTextBox.Rtf;
                        Command.Parameters.Add("@ServiceNote", SqlDbType.NVarChar).Value = ServiceNoteTextBox.Rtf;
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();

                        NotifyMessage nm = new NotifyMessage("تم حفظ بيانات الزيارة", NotifyMessage.NotifyMessageIcon.Saved);
                        nm.Show();
                        VisitChangesMade = false;
                        Asterisk3.Visible = false;
                        return true;
                    }
                }
            return false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DisableVisitBoxes();
            VisitChangesMade = false;
        }

        private void DisableVisitBoxes()
        {
            //Clear Data from Visit Boxes
            ServiceTextBox.Rtf = "";
            ServiceNoteTextBox.Rtf = "";

            VisorComboBox.Enabled = false;
            AccompanyingComboBox.Enabled = false;
            ProgramDatePicker.Enabled = false;
            VisitTextBox.ReadOnly = true;
            VisitNoteTextBox.ReadOnly = true;

            ServiceTextBox.ReadOnly = true;
            ServiceNoteTextBox.ReadOnly = true;
            
            //Load Data From DGV
            LoadVisitInfo();

            //Disable proper buttons
            NewVisitButton.Visible = true;
            EditVisitButton.Visible = true;
            SaveVisitButton.Visible = false;
            CancelVisitChangesButton.Visible = false;

            Asterisk3.Visible = false;

            VisitsDGV.Enabled = true;
        }

        private void EnableServiceBoxesForEdit()
        {
            ServiceTextBox.ReadOnly = false;
            ServiceNoteTextBox.ReadOnly = false;
            VisitsDGV.Enabled = false;

            NewVisitButton.Visible = false;
            EditVisitButton.Visible = false;
            SaveVisitButton.Visible = true;
            CancelVisitChangesButton.Visible = true;
            NewVisit = false;
            ServiceTextBox.Focus();
        }

        private void EnableVisitBoxesForNewVisit()
        {
            //Clear Data From boxes
            VisitIDTextBox.Text = "*";
            ServiceTextBox.Rtf = "";
            ServiceNoteTextBox.Rtf = "";
            VisitTextBox.Text = "";
            VisitNoteTextBox.Text = "";
            ProgramIDtextBox.Text = "*";

            VisorComboBox.Enabled = true;
            AccompanyingComboBox.Enabled = true;
            ProgramDatePicker.Enabled = true;
            VisitTextBox.ReadOnly = false;
            VisitNoteTextBox.ReadOnly = false;

            ServiceTextBox.ReadOnly = false;
            ServiceNoteTextBox.ReadOnly = false;

            VisorComboBox.SelectedValue = 0;
            AccompanyingComboBox.SelectedValue = 0;
            ProgramDatePicker.Value = DateTime.Now;
            
            NewVisitButton.Visible = false;
            EditVisitButton.Visible = false;
            SaveVisitButton.Visible = true;
            CancelVisitChangesButton.Visible = true;

            VisitsDGV.Enabled = false;
        }

        private void PlantStartingDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (PlantStartingDatePicker.Focused)
                PlantChangesMade = true;
        }

        private void PlantStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlantStatusComboBox.Focused)
                PlantChangesMade = true;
        }

        private void InsertStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand() { Connection = Connection };
                SqlDataReader Reader;
                string LastRows = "";

                switch (InsertStatusComboBox.Text)
                {
                    case "": 
                        PlantLastStatusTextBox.Text = "";
                        break;

                    case "الاتصال (أخر تحديث)":

                        Command.CommandText = @"SELECT [Text] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PhoneCallsLogView] where [PlantID]=" + PlantID;
                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                if (!Reader.IsDBNull(0))
                                    LastRows = Reader.GetString(0);
                        PlantLastStatusTextBox.Text = LastRows;
                        break;

                    case "المطلوب (أخر تحديث)": 
                        Command.CommandText = @"SELECT [VisitText] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PlantServiceView] where [PlantID]=" + PlantID;
                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                if (!Reader.IsDBNull(0))
                                    LastRows = Reader.GetString(0);
                        PlantLastStatusTextBox.Text = LastRows;
                        break;

                    case "تقرير الصيانة (أخر تحديث)": 
                        Command.CommandText = @"SELECT [ServiceText] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PlantServiceView] where [PlantID]=" + PlantID;
                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                if (!Reader.IsDBNull(0))
                                    LastRows = Reader.GetString(0);
                        PlantLastStatusTextBox.Rtf = LastRows;

                        var t = PlantLastStatusTextBox.Text;
                        PlantLastStatusTextBox.Rtf = string.Empty;
                        PlantLastStatusTextBox.Text = t;

                        break;
                }
                PlantChangesMade = true;
            }
        }

        private void PlantLastStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PlantLastStatusTextBox.Focused)
                PlantChangesMade = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CallWindow NewCallWindow = new CallWindow(user);
            NewCallWindow.FormClosed += new FormClosedEventHandler(NewCallWindow_FormClosed);
            NewCallWindow.Show();
            if (CustomerID != 0 && InstituteID != 0 && PlantID != 0)
            {
                NewCallWindow.plantChoose1.CustomersComboBox.SelectedValue = CustomerID;
                NewCallWindow.plantChoose1.InstituteComboBox.SelectedValue = InstituteID;
                NewCallWindow.plantChoose1.PlantComboBox.SelectedValue = PlantID;
            }
        }

        void NewCallWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshCallsLog();
        }

        private void PlantTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlantTypeComboBox.Focused)
                PlantChangesMade = true;
        }

        private void VisorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (VisorComboBox.Focused)
                VisitChangesMade = true;
        }

        private void AccompanyingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AccompanyingComboBox.Focused)
                VisitChangesMade = true;
        }

        private void ProgramDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ProgramDatePicker.Focused)
                VisitChangesMade = true;
        }

        private void VisitTextBox_TextChanged(object sender, EventArgs e)
        {
            if (VisitTextBox.Focused)
                VisitChangesMade = true;
        }

        private void VisitNoteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (VisitNoteTextBox.Focused)
                VisitChangesMade = true;
        }

        private void ServiceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ServiceTextBox.Focused)
                VisitChangesMade = true;
        }

        private void ServiceNoteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ServiceNoteTextBox.Focused)
                VisitChangesMade = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: break;
                case 1: 
                    
                    RefreshVisitsDGV();

                    if (SelectedVisitID != 0)
                        try
                        {
                            foreach (DataGridViewRow row in VisitsDGV.Rows)
                            {
                                if (Convert.ToInt32(row.Cells[0].Value) == SelectedVisitID)
                                {
                                    row.Selected = true;
                                    LoadVisitInfo();
                                    EnableServiceBoxesForEdit();
                                    ServiceTextBox.Focus();
                                    break;
                                }
                            }
                        }
                        catch
                        { }
                    else if (VisitsDGV.Rows.Count > 0)
                    {
                        VisitsDGV.Rows[0].Selected = true;
                        LoadVisitInfo();
                    }
                    break;
                case 2: RefreshCallsLog(); break;
                case 3: break;
            }


        }




    }
}
 