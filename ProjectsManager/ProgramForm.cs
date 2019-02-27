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
using Microsoft.Reporting.WinForms;


namespace ProjectsManager
{
    public partial class ProgramForm : Form
    {
        
        /// <summary>
        /// New Program
        /// </summary>
        /// <param name="user"></param>
        public ProgramForm(User user)
        {
            this.user = user;
            NewProgram = true;
            InitializeComponent();
        }

        /// <summary>
        /// Open Old Program
        /// </summary>
        /// <param name="user"></param>
        public ProgramForm(int ProgramID, User user)
        {
            this.ProgramID = ProgramID;
            this.user = user;
            NewProgram = false;
            InitializeComponent();
        }

        User user;
        bool ChangesMade = false;
        //bool SafeToExitWindow = true;
        bool NewProgram = false;
        int ProgramID;
        
        Dictionary<int, string> CustomersDic = new Dictionary<int, string>();
        Dictionary<int, string> InstitutesDic = new Dictionary<int, string>();
        Dictionary<int, string> PlantsDic = new Dictionary<int, string>();

        Dictionary<int, string> TechniciansDic = new Dictionary<int, string>();
        Dictionary<int, string> CarsDic = new Dictionary<int, string>();
        Dictionary<int, string> UsersDic = new Dictionary<int, string>();

        private void ServiceProgram_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("VisitID", "VisitID");
            dataGridView1.Columns.Add("CustomerID","CustomerID");
            dataGridView1.Columns.Add("الزبون","الزبون");
            dataGridView1.Columns.Add("InstituteID","InstituteID");
            dataGridView1.Columns.Add("المنشأة","المنشأة");
            dataGridView1.Columns.Add("PlantID","PlantID");
            dataGridView1.Columns.Add("وحدة المعالجة","وحدة المعالجة");
            dataGridView1.Columns.Add("المطلوب", "المطلوب");
            dataGridView1.Columns.Add("ملاحظات اضافية", "ملاحظات اضافية");
            dataGridView1.Columns.Add("IsNewRecord", "IsNewRecord");       //1 = New Record - 0 = Old Record
            dataGridView1.Columns.Add("RecordOrderNO", "RecordOrderNO");

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            TechniciansDic.Add(0, " ");
            CarsDic.Add(0, " ");

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[TechnicianName] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[Technicians]", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        TechniciansDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                    
                    VisorComboBox.DisplayMember = "Value";
                    VisorComboBox.ValueMember = "Key";
                    VisorComboBox.DataSource = new BindingSource(TechniciansDic, null);
                    VisorComboBox.SelectedValue = 0;

                    
                    AccompanyingComboBox.DisplayMember = "Value";
                    AccompanyingComboBox.ValueMember = "Key";
                    AccompanyingComboBox.DataSource = new BindingSource(TechniciansDic, null);
                    AccompanyingComboBox.SelectedValue = 0;

                    
                    DriverComboBox.DisplayMember = "Value";
                    DriverComboBox.ValueMember = "Key";
                    DriverComboBox.DataSource = new BindingSource(TechniciansDic, null);
                    DriverComboBox.SelectedValue = 0;
                }
                Reader.Close();

                Command.CommandText = @"SELECT [id],[VehicleName] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[Vehicles]";
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        CarsDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                    
                    CarComboBox.DisplayMember = "Value";
                    CarComboBox.ValueMember = "Key";
                    CarComboBox.DataSource = new BindingSource(CarsDic, null);
                    CarComboBox.SelectedValue = 0;
                }
                Reader.Close();

                Command.CommandText = @"SELECT [id],[displayname] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[users]";
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                        UsersDic.Add(Reader.GetInt32(0), Reader.GetString(1));
                    
                    ByUserComboBox.DisplayMember = "Value";
                    ByUserComboBox.ValueMember = "Key";
                    ByUserComboBox.DataSource = new BindingSource(UsersDic, null);
                }
                Reader.Close();

                if (NewProgram)
                {
                    ByUserComboBox.SelectedValue = user.UserID;
                    ProgramNOTextBox.Text = @"*";
                    DeleteButton.Visible = false;
                }
                else if (!NewProgram)
                {
                    RemovePlantFromDGVButton.Visible = false;

                    Command.CommandText = @"SELECT [id],[ProgramDate],[VehicleID],[TechnicianID],[AccompanyingID],[DriverID]
                    ,[ProgramText],[ByUserID]
                    FROM [" + Settings1.Default.DatabaseName + "].[dbo].[Programs] where [id]=" + ProgramID;
                    Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                        {
                            if (!Reader.IsDBNull(0))
                                ProgramNOTextBox.Text = Convert.ToString(Reader.GetInt32(0));
                            if (!Reader.IsDBNull(1))
                                ProgramDatePicker.Value = Reader.GetDateTime(1);
                            if (!Reader.IsDBNull(2))
                                CarComboBox.SelectedValue = Reader.GetInt32(2);
                            if (!Reader.IsDBNull(3))
                                VisorComboBox.SelectedValue = Reader.GetInt32(3);
                            if (!Reader.IsDBNull(4))
                                AccompanyingComboBox.SelectedValue = Reader.GetInt32(4);
                            if (!Reader.IsDBNull(5))
                                DriverComboBox.SelectedValue = Reader.GetInt32(5);
                            if (!Reader.IsDBNull(6))
                                ProgramTextBox.Text = Reader.GetString(6);
                            if (!Reader.IsDBNull(7))
                                ByUserComboBox.SelectedValue = Reader.GetInt32(7);
                        }
                    Reader.Close();

                    RefreshDGV();
                }
            }

            VerifyUserPermissions();
        }

        private void ProgramWindow_Shown(object sender, EventArgs e)
        {
            ProgramNOTextBox.Focus();
        }

        private void RefreshDGV()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                int i = 0;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [VisitID],[CustomerID],[CustomerName] as [الزبون],[InstituteID] as [InstituteID],[InstituteName] as [المنشأة],[PlantID] as [PlantID]
                    ,[PlantName] as [وحدة المعالجة],[VisitText] as [المطلوب],[VisitNote] as [ملاحظات اضافية],[RecordOrderNO] 
                    FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PlantServiceView] where [ProgramID]=" + ProgramID, Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        dataGridView1.Rows.Add();

                        if (!Reader.IsDBNull(0))
                            dataGridView1.Rows[i].Cells["VisitID"].Value = Reader.GetInt32(0);     //DR[0] = VisiteID
                        if (!Reader.IsDBNull(1))
                            dataGridView1.Rows[i].Cells["CustomerID"].Value = Reader.GetInt32(1);
                        if (!Reader.IsDBNull(2))
                            dataGridView1.Rows[i].Cells["الزبون"].Value = Reader.GetString(2);
                        if (!Reader.IsDBNull(3))
                            dataGridView1.Rows[i].Cells["InstituteID"].Value = Reader.GetInt32(3);
                        if (!Reader.IsDBNull(4))
                            dataGridView1.Rows[i].Cells["المنشأة"].Value = Reader.GetString(4);
                        if (!Reader.IsDBNull(5))
                            dataGridView1.Rows[i].Cells["PlantID"].Value = Reader.GetInt32(5);
                        if (!Reader.IsDBNull(6))
                            dataGridView1.Rows[i].Cells["وحدة المعالجة"].Value = Reader.GetString(6);
                        if (!Reader.IsDBNull(7))
                            dataGridView1.Rows[i].Cells["المطلوب"].Value = Reader.GetString(7);
                        if (!Reader.IsDBNull(8))
                            dataGridView1.Rows[i].Cells["ملاحظات اضافية"].Value = Reader.GetString(8);

                        dataGridView1.Rows[i].Cells["IsNewRecord"].Value = 0;                   //its old record

                        if (!Reader.IsDBNull(9))
                            dataGridView1.Rows[i].Cells["RecordOrderNO"].Value = Reader.GetInt32(9);
                        i++;
                    }
                dataGridView1.Sort(dataGridView1.Columns["RecordOrderNO"], ListSortDirection.Ascending);
            }
        }

        private void VerifyUserPermissions()
        {
            if (user.ReadPermission)
            { }
            else
            {
                groupBox1.Enabled = false; groupBox2.Enabled = false; groupBox3.Enabled = false;
                SaveButton.Visible = false;
            }
            
            if (user.ModifyPermission)
            { }
            else
            {
                groupBox1.Enabled = false; groupBox2.Enabled = false; groupBox3.Enabled = false;
                SaveButton.Visible = false; 
            }

            if (user.DeletePermission)
            { }
            else
            { DeleteButton.Visible = false; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Add Row to DataGridView by User
            if (plantChoose1.IsDataOK() && VisitTextBox.Text != "")
            {
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count, "", plantChoose1.CustomerID, plantChoose1.CustomerName, plantChoose1.InstituteID, plantChoose1.InstituteName, plantChoose1.PlantID, plantChoose1.PlantName, VisitTextBox.Text, VisitNoteTextBox.Text, 1);

                plantChoose1.ClearDataFromBoxes();
                VisitTextBox.Text = "";
                VisitNoteTextBox.Text = "";
                InsertStatusComboBox.SelectedIndex = InsertStatusComboBox.FindStringExact(" ");
            }
            else
            {
                NotifyMessage nm = new NotifyMessage("يرجى اختيار المنشأة و وحدة المعالجة التابعة لها ومعلومات الزيارة", NotifyMessage.NotifyMessageIcon.Error);
                nm.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null && dataGridView1.CurrentCell.ColumnIndex != -1)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ChangesMade = false;
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void VisorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VisorComboBox.Focused)
                ChangesMade = true;
        }

        private void AccompanyingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AccompanyingComboBox.Focused)
                ChangesMade = true;
        }

        private void DriverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DriverComboBox.Focused)
                ChangesMade = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ProgramDatePicker.Focused)
                ChangesMade = true;
        }

        private void CarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarComboBox.Focused)
                ChangesMade = true;
        }
        private void ProgramTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ProgramTextBox.Focused)
                ChangesMade = true;
        }

        private void PlantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangesMade = true;
        }

        private void ServiceProgram_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangesMade)
            {
                DialogResult resualt = MessageBox.Show("هل تريد حفظ التغييرات", "إغلاق", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (resualt == DialogResult.Yes)
                {
                    if (!SaveChanges())
                        e.Cancel = true;
                }
                else if (resualt == DialogResult.Cancel)
                    e.Cancel = true;
                else if (resualt == DialogResult.No)
                    e.Cancel = false;
            }
        }

        private bool SaveChanges()
        {
            if (Convert.ToInt32(VisorComboBox.SelectedValue) == 0)
            {
                NotifyMessage nm = new NotifyMessage("لا يمكن الحفظ ، الرجاء التأكد من إدخال الحقول الناقصة", NotifyMessage.NotifyMessageIcon.Error);
                nm.Show();
                Asterisk1.Visible = true;
                return false;
            }
            else
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand();
                    Command.Connection = Connection;

                    if (NewProgram)
                    {
                        Command.CommandText = @"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[Programs]
                        ([ProgramDate],[VehicleID],[TechnicianID],[AccompanyingID],[DriverID],[ProgramText],[TimeStamp],[ByUserID]) output INSERTED.[id] VALUES
                        (@ProgramDate,@VehicleID,@TechnicianID,@AccompanyingID,@DriverID,@ProgramText,convert(datetime,getdate(),102),@ByUserID)";

                        Command.Parameters.Add("@ProgramDate", SqlDbType.DateTime).Value = ProgramDatePicker.Value.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"));
                        Command.Parameters.Add(new SqlParameter("@VehicleID", SqlDbType.Int)).Value = (object)CarComboBox.SelectedValue ?? DBNull.Value;
                        Command.Parameters.Add("@TechnicianID", SqlDbType.Int).Value = VisorComboBox.SelectedValue;
                        Command.Parameters.Add(new SqlParameter("@AccompanyingID", SqlDbType.Int)).Value = (object)AccompanyingComboBox.SelectedValue ?? DBNull.Value;
                        Command.Parameters.Add(new SqlParameter("@DriverID", SqlDbType.Int)).Value = (object)DriverComboBox.SelectedValue ?? DBNull.Value;
                        Command.Parameters.Add("@ProgramText", SqlDbType.NVarChar).Value = ProgramTextBox.Text;
                        Command.Parameters.Add("@ByUserID", SqlDbType.Int).Value = user.UserID;
                        SqlDataReader Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                ProgramID = Reader.GetInt32(0);
                        Reader.Close();
                        Command.Parameters.Clear();

                        if (dataGridView1.Rows.Count > 0)
                            if (!SavePlantService())
                                return false;

                        NewProgram = false;
                    }
                    else if (!NewProgram)
                    {
                        Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[Programs] SET 
                        [ProgramDate] = @ProgramDate,[VehicleID] = @VehicleID,[TechnicianID] = @TechnicianID,[AccompanyingID]=@AccompanyingID
                        ,[DriverID] = @DriverID,[ProgramText] = @ProgramText WHERE [id]=" + ProgramID;

                        Command.Parameters.Add("@ProgramDate", SqlDbType.DateTime).Value = ProgramDatePicker.Value.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"));
                        Command.Parameters.Add("@VehicleID", SqlDbType.Int).Value = CarComboBox.SelectedValue;
                        Command.Parameters.Add("@TechnicianID", SqlDbType.Int).Value = VisorComboBox.SelectedValue;
                        Command.Parameters.Add("@AccompanyingID", SqlDbType.Int).Value = AccompanyingComboBox.SelectedValue;
                        Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverComboBox.SelectedValue;
                        Command.Parameters.Add("@ProgramText", SqlDbType.Text).Value = ProgramTextBox.Text;
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();

                        if (dataGridView1.Rows.Count > 0)
                            if (!SavePlantService())
                                return false;
                    }

                    ChangesMade = false;

                    NotifyMessage nw = new NotifyMessage("تم حفظ البرنامج", NotifyMessage.NotifyMessageIcon.Saved);
                    nw.Show();
                    DeleteButton.Visible = true;
                    return true;
                }
        }

        private bool SavePlantService()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                SqlCommand Command = new SqlCommand("", Connection);
                Connection.Open();

                int i = 1;      //To set Record Order in table. At each record add i is increased by +1
                foreach (DataGridViewRow DR in dataGridView1.Rows)
                {
                    if (DR.Cells[9].Value.ToString() == "1")            //New Record
                    {
                        Command.CommandText = @"INSERT INTO [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantService]
                            ([CustomerID],[InstituteID],[PlantID],[VisitText],[VisitNote],[ProgramID],[RecordOrderNO])  VALUES
                            (@CustomerID,@InstituteID,@PlantID,@VisitText,@VisitNote,@ProgramID,@RecordOrderNO)";
                        Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = DR.Cells["CustomerID"].Value;
                        Command.Parameters.Add("@InstituteID", SqlDbType.Int).Value = DR.Cells["InstituteID"].Value;
                        Command.Parameters.Add("@PlantID", SqlDbType.Int).Value = DR.Cells["PlantID"].Value;
                        Command.Parameters.Add("@VisitText", SqlDbType.NVarChar).Value = DR.Cells["المطلوب"].Value;
                        Command.Parameters.Add("@VisitNote", SqlDbType.NVarChar).Value = DR.Cells["ملاحظات اضافية"].Value;
                        Command.Parameters.Add("@ProgramID", SqlDbType.Int).Value = ProgramID;
                        Command.Parameters.Add("@RecordOrderNO", SqlDbType.Int).Value = i;
                    }
                    else if (DR.Cells[9].Value.ToString() == "0")       //Old Record
                    {
                        Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantService] SET 
                            [CustomerID] = @CustomerID,[InstituteID] = @InstituteID,[PlantID] = @PlantID,[VisitText] = @VisitText
                            ,[VisitNote]=@VisitNote,[RecordOrderNO]=@RecordOrderNO WHERE [id]=@id";
                        Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = DR.Cells["CustomerID"].Value;
                        Command.Parameters.Add("@InstituteID", SqlDbType.Int).Value = DR.Cells["InstituteID"].Value;
                        Command.Parameters.Add("@PlantID", SqlDbType.Int).Value = DR.Cells["PlantID"].Value;
                        Command.Parameters.Add("@VisitText", SqlDbType.NVarChar).Value = DR.Cells["المطلوب"].Value;
                        Command.Parameters.Add("@VisitNote", SqlDbType.NVarChar).Value = DR.Cells["ملاحظات اضافية"].Value;
                        Command.Parameters.Add("@id", SqlDbType.Int).Value = DR.Cells[0].Value;
                        Command.Parameters.Add("@RecordOrderNO", SqlDbType.Int).Value = i;
                    }
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                    i++;
                }
                return true;
            }
            return false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Print button

            DialogResult DR = MessageBox.Show("يجب حفظ التغييرات , هل ترغب بالمتابعة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DR == System.Windows.Forms.DialogResult.Yes)
            {
                if (SaveChanges())
                {
                    RefreshDGV();
                    List<ReportParameter> parameters = new List<ReportParameter>();
                    parameters.Add(new ReportParameter("ProgramDate", ProgramDatePicker.Value.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"))));
                    parameters.Add(new ReportParameter("TechnicianName", VisorComboBox.Text));
                    parameters.Add(new ReportParameter("ProgramID", ProgramID.ToString()));
                    parameters.Add(new ReportParameter("AccompanyingName", AccompanyingComboBox.Text));
                    parameters.Add(new ReportParameter("ProgramText", ProgramTextBox.Text));
                    parameters.Add(new ReportParameter("DriverName", DriverComboBox.Text));
                    parameters.Add(new ReportParameter("Car", CarComboBox.Text));

                    PrintForm PF = new PrintForm(ProgramID, parameters);
                    PF.Show();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Delete 
            if (DeleteItem.DeleteProgram(ProgramID))
            {
                ChangesMade = false;
                Close();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SaveLinkLabel.Visible = true;
                CancelLinkLabel.Visible = true;

                plantChoose1.CustomersComboBox.SelectedValue = Convert.ToInt32(dataGridView1.SelectedCells[1].Value);
                plantChoose1.InstituteComboBox.SelectedValue = Convert.ToInt32(dataGridView1.SelectedCells[3].Value);
                plantChoose1.PlantComboBox.SelectedValue = Convert.ToInt32(dataGridView1.SelectedCells[5].Value);
                VisitTextBox.Text = Convert.ToString(dataGridView1.SelectedCells[7].Value);
                VisitNoteTextBox.Text = Convert.ToString(dataGridView1.SelectedCells[8].Value);
            }
            else
            {
                SaveLinkLabel.Visible = false;
                CancelLinkLabel.Visible = false;
            }
        }

        private void SaveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Commit changes from boxes to DataGridView1

            if (plantChoose1.SuccessChoose && VisitTextBox.Text != "")
            {
                dataGridView1.SelectedCells[1].Value = plantChoose1.CustomerID;
                dataGridView1.SelectedCells[2].Value = plantChoose1.CustomerName;
                dataGridView1.SelectedCells[3].Value = plantChoose1.InstituteID;
                dataGridView1.SelectedCells[4].Value = plantChoose1.InstituteName;
                dataGridView1.SelectedCells[5].Value = plantChoose1.PlantID;
                dataGridView1.SelectedCells[6].Value = plantChoose1.PlantName;
                dataGridView1.SelectedCells[7].Value = VisitTextBox.Text;
                dataGridView1.SelectedCells[8].Value = VisitNoteTextBox.Text;

                SaveLinkLabel.Visible = false;
                CancelLinkLabel.Visible = false;
                plantChoose1.ClearDataFromBoxes();
                VisitTextBox.Text = "";
                VisitNoteTextBox.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CancelLinkLabel.Visible = false;
            SaveLinkLabel.Visible = false;
            plantChoose1.ClearDataFromBoxes();
            VisitTextBox.Text = "";
            VisitNoteTextBox.Text = "";
        }

        private void MoveUPButton_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dataGridView1.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dataGridView1.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                // get index of the column for the selected cell
                int colIndex = dataGridView1.SelectedCells[2].OwningColumn.Index;
                
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                dataGridView1.Rows.Remove(selectedRow);
                dataGridView1.Rows.Insert(rowIndex - 1, selectedRow);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dataGridView1.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dataGridView1.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                // get index of the column for the selected cell
                int colIndex = dataGridView1.SelectedCells[2].OwningColumn.Index;

                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                dataGridView1.Rows.Remove(selectedRow);
                dataGridView1.Rows.Insert(rowIndex + 1, selectedRow);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
            catch(Exception ex) { }
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
                        VisitTextBox.Text = "";
                        break;

                    case "الاتصال (أخر تحديث)":

                        Command.CommandText = @"SELECT [Text] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PhoneCallsLogView] where [PlantID]=" + plantChoose1.PlantID;
                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                if (!Reader.IsDBNull(0))
                                    LastRows = Reader.GetString(0);
                        VisitTextBox.Text = LastRows;
                        break;

                    case "المطلوب (أخر تحديث)":
                        Command.CommandText = @"SELECT [VisitText] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PlantServiceView] where [PlantID]=" + plantChoose1.PlantID;
                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                if (!Reader.IsDBNull(0))
                                    LastRows = Reader.GetString(0);
                        VisitTextBox.Text = LastRows;
                        break;

                    case "تقرير الصيانة (أخر تحديث)":
                        Command.CommandText = @"SELECT [ServiceText] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PlantServiceView] where [PlantID]=" + plantChoose1.PlantID;
                        Reader = Command.ExecuteReader();
                        if (Reader.HasRows)
                            while (Reader.Read())
                                if (!Reader.IsDBNull(0))
                                    LastRows = Reader.GetString(0);
                        VisitTextBox.Rtf = LastRows;

                        var t = VisitTextBox.Text;
                        VisitTextBox.Rtf = string.Empty;
                        VisitTextBox.Text = t;

                        break;
                }
                ChangesMade = true;
            }
        }





    }


}
