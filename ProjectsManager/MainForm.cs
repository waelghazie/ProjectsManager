using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace ProjectsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        LoginForm LoginWindow;
        ApplicationWizardForm WizardForm;
        
        string BackupStatus;

        User user;
        bool LoggedIN = false;

        public enum CurrentOpenSection {Home, Institutes, Plants, PhoneCallsLog, Programs, DeletedInstitutes, DeletedPlants ,DeletedCustomers}
        CurrentOpenSection CurrentSection;
        DataTable PlantsData, InstitutesData, TodaysAppointments, DeletedInstitutesData, DeletedPlantsData, DeletedCustomersData;
        DataTable PhoneCallsLogData, MyRemindersData, TodayCallsData, ProgramsData;

        SqlConnection Connection;

        ActivationInfo AI;
        StreamWriter SWriter;
        StreamReader SReader;
        bool TrialPeriodEnd = false;

        List<int> OpenRemindersList = new List<int>();

        InstituteAdvancedSearch InstituteSearchPanel;
        PlantAdvancedSearch PlantSearchPanel;
        CallsAdvancedSearch CallSearchPanel;
        ChoosePlantSelectedTab PlantToolTip;

        private void MainForm_Load(object sender, EventArgs e)
        {
            InstituteSearchPanel = new InstituteAdvancedSearch();
            InstituteSearchPanel.PropertyChanged += new PropertyChangedEventHandler(InstituteSearchPanel_PropertyChanged);
            PlantSearchPanel = new PlantAdvancedSearch();
            PlantSearchPanel.PropertyChanged += new PropertyChangedEventHandler(PlantSearchPanel_PropertyChanged);
            CallSearchPanel = new CallsAdvancedSearch();
            CallSearchPanel.PropertyChanged += new PropertyChangedEventHandler(CallSearch_PropertyChanged);

            PlantToolTip = new ChoosePlantSelectedTab();
            PlantToolTip.PropertyChanged += new PropertyChangedEventHandler(PlantTabChoosen);

            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //ItemsDGV.Columns.Add(chk); { chk.HeaderText = " "; }

            clock1.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now);
            StatusLabel4.Visible = false;
            DatabaseLabel.Visible = false;
            LoggedUserLabel.Text = "";
            TodayDateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            RowsCountLabel.Visible = false;
            ConnectionStatusLabel.Text = "غير متصل";

            user = new User();

            if (!Settings1.Default.AutoLogin)
            {
                SplashScreen SplashScreen = new SplashScreen();
                SplashScreen.ShowDialog();
            }

            if (Settings1.Default.LoginAsADUser)
                LoginMenuItem.Visible = false;
            else
                LoginMenuItem.Visible = true;

            PlantsData = new DataTable();
            InstitutesData = new DataTable();
            TodaysAppointments = new DataTable();
            DeletedCustomersData = new DataTable();
            DeletedInstitutesData = new DataTable();
            DeletedPlantsData = new DataTable();
            
            MyRemindersData = new DataTable();
            PhoneCallsLogData = new DataTable();
            TodayCallsData = new DataTable();
            ProgramsData = new DataTable();

            DisableApplicationControls();

            LoginWindow = new LoginForm();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            CheckActivationStatus();

            if (CheckOS32or64.IsOS64Bit())
            {
                using (RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Sharp Code\\Settings", true))
                    if (myKey != null)
                        if (myKey.GetValue("FirstRun", 0, RegistryValueOptions.None).ToString() == "1")
                        {
                            WizardForm = new ApplicationWizardForm();
                            WizardForm.ShowDialog();

                            if (WizardForm.SuccessDBConnect || WizardForm.SuccessDBCreation)
                                if (ConnectToDatabase())
                                    LoginToAppliacation();
                        }
                        else if (ConnectToDatabase())
                            LoginToAppliacation();
            }
            else if (!CheckOS32or64.IsOS64Bit())
            {
                using (RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Sharp Code\\Settings", true))
                    if (myKey != null)
                        if (myKey.GetValue("FirstRun", 0, RegistryValueOptions.None).ToString() == "1")
                        {
                            WizardForm = new ApplicationWizardForm();
                            WizardForm.ShowDialog();

                            if (WizardForm.SuccessDBConnect || WizardForm.SuccessDBCreation)
                                if (ConnectToDatabase())
                                    LoginToAppliacation();
                        }
                        else if (ConnectToDatabase())
                            LoginToAppliacation();
            }
        }

        private bool ConnectToDatabase()        //true: can connect to DB - false: Can't Connect successfully to DB
        {
            if (Settings1.Default.SQLServer != "" && Settings1.Default.DatabaseName != "")
                try
                {
                    Connection = AppConnection.GetConnection();
                    Connection.StateChange += new StateChangeEventHandler(ConnectionStateChange);
                    Connection.Open();
                    return true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message + "\n مشكلة اتصال مع المخدم أو قاعدة البيانات", "لم يتم الاتصال بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConnectionStatusLabel.Text = "غير متصل";
                    return false;
                }
            return false;
        }

        void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            switch (Connection.State)
            {
                case ConnectionState.Open:
                    ConnectionStatusLabel.Text = "متصل";
                    DatabaseLabel.Visible = true;
                    DatabaseLabel.Text = @"Server: " + Settings1.Default.SQLServer + "  Database: " + Settings1.Default.DatabaseName;
                    
                    if (Settings1.Default.LoginAsADUser)
                        LoginMenuItem.Visible = false;
                    else
                        LoginMenuItem.Visible = true;

                    break;
                case ConnectionState.Closed:
                    ConnectionStatusLabel.Text = "غير متصل";
                    DatabaseLabel.Text = "";

                    if (Settings1.Default.LoginAsADUser)
                        LoginMenuItem.Visible = false;
                    else
                        LoginMenuItem.Visible = true;

                    DisableApplicationControls();
                    break;
                default:
                    ConnectionStatusLabel.Text = "جاري الاتصال";
                    break;
            }
        }

        private void LoginToAppliacation()
        {
            if (Connection.State == ConnectionState.Open)
            {
                LoginWindow.ShowDialog();
                if (LoginWindow.CloseApplication == true)
                    Close();

                if (LoginWindow.Authorized)         //مسموح الدخول للمستخدم
                {
                    this.user = LoginWindow.user;
                    LoggedUserLabel.Text = user.DisplayName;
                    LoggedIN = true;

                    LoadDBSettings();

                    EnableAppplicationControls();
                    VerifyUserPermissions(CurrentOpenSection.Home);
                }
                else                     //غير مسموح للمستخدم بالدخول  
                {
                    DisableApplicationControls();
                }
            }
        }

        private void LoadDBSettings()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                //تحميل اعدادات البرنامج وحفظها لدى المستخدم على جهازه
                SqlCommand Command = new SqlCommand(@"SELECT [ReportsPath],[PhotosPath],[BackupPath],[BackupInterval] 
                    FROM [" + Settings1.Default.DatabaseName + "].[dbo].[appsettings]", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            Settings1.Default.ReportsFolder = Reader.GetString(0);
                        if (!Reader.IsDBNull(1))
                            Settings1.Default.PhotosPath = Reader.GetString(1);
                        if (!Reader.IsDBNull(2))
                            Settings1.Default.BackupFolder = Reader.GetString(2);
                        if (!Reader.IsDBNull(3))
                            Settings1.Default.BackupInterval = Reader.GetInt32(3);
                    }
                BackupTimer.Interval = Settings1.Default.BackupTimer * 1000;
                ReminderTimer.Interval = Settings1.Default.ReminderTimer * 1000;
                Settings1.Default.Save();
            }
        }

        void DisableApplicationControls()
        {
            //ايقاف ازرار و وظائف البرنامج
            
            بطاقاتToolStripMenuItem.Enabled = false;
            التذكيراتToolStripMenuItem.Enabled = false;
            ViewMenuItem.Enabled = false;
            AppSettingsMenuItem.Visible = false;
            ManageUsersMenuItem.Visible = false;
            BackupMenuMenuItem.Visible = false;
            ViewMenuItem.Visible = false;

            tableLayoutPanel1.Visible = false;

            ReminderTimer.Enabled = false;
            BackupTimer.Enabled = false;

        }

        void EnableAppplicationControls()
        {
            //تفعيل ازرار البرنامج و وظائفه
            if (!TrialPeriodEnd)
            {
                التذكيراتToolStripMenuItem.Enabled = true;
                بطاقاتToolStripMenuItem.Enabled = true;
                ViewMenuItem.Enabled = true;
                AppSettingsMenuItem.Visible = true;
                ManageUsersMenuItem.Visible = true;
                BackupMenuMenuItem.Visible = true;
                ViewMenuItem.Visible = true;

                tableLayoutPanel1.Visible = true;

                ReminderTimer.Enabled = true;
                BackupTimer.Enabled = true;

                RefreshMyRemindersDGV();
                RefreshTodayCallsDGV();
                RefreshActiveAppointmentsDGV();
            }
        }

        private void VerifyUserPermissions(CurrentOpenSection CD)
        {
            if (user.ReadPermission)
            { tabControl1.Visible = true; }
            else
            { tabControl1.Visible = false; }

            if (user.ModifyPermission)
            { EditButton.Visible = true; /*ActiveAppointmentsDGV.ReadOnly = false; TodayCallsDGV.ReadOnly = false;*/ EnterServiceReportButton.Visible = true; }
            else
            { EditButton.Visible = false; /*ActiveAppointmentsDGV.ReadOnly = true; TodayCallsDGV.ReadOnly = true;*/ EnterServiceReportButton.Visible = false; }

            if (user.CreatePermission)
            { NewButton.Visible = true; }
            else
            { NewButton.Visible = false; }

            if (user.DeletePermission)
            { DeleteButton.Visible = true; RestoreButton.Visible = true; treeView1.Visible = true; }
            else
            { DeleteButton.Visible = false; RestoreButton.Visible = false; treeView1.Visible = false; }

            if (user.ManageUsers)
            { ManageUsersMenuItem.Visible = true; BackupMenuMenuItem.Visible = true; }
            else
            { ManageUsersMenuItem.Visible = false; BackupMenuMenuItem.Visible = false; }

            switch (CD)
            {
                case CurrentOpenSection.Institutes:
                    RestoreButton.Visible = false; AdvancedSearchButton.Visible = true;
                    break;
                case CurrentOpenSection.Plants:
                    RestoreButton.Visible = false; AdvancedSearchButton.Visible = true;
                    break;
                case CurrentOpenSection.PhoneCallsLog:
                    EditButton.Visible = false; AdvancedSearchButton.Visible = true; DeleteButton.Visible = false; RestoreButton.Visible = false; EnterServiceReportButton.Visible = false;
                    break;
                case CurrentOpenSection.Programs:
                    RestoreButton.Visible = false; AdvancedSearchButton.Visible = false;
                    break;
                case CurrentOpenSection.DeletedCustomers:
                    DeleteButton.Visible = true; NewButton.Visible = false; EditButton.Visible = false; AdvancedSearchButton.Visible = false; EnterServiceReportButton.Visible = false;
                    break;
                case CurrentOpenSection.DeletedInstitutes:
                    DeleteButton.Visible = true; NewButton.Visible = false; EditButton.Visible = false; AdvancedSearchButton.Visible = false; EnterServiceReportButton.Visible = false;
                    break;
                case CurrentOpenSection.DeletedPlants:
                    DeleteButton.Visible = true; NewButton.Visible = false; EditButton.Visible = false; AdvancedSearchButton.Visible = false; EnterServiceReportButton.Visible = false;
                    break; 
            }
        }

        void plant_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDGV(CurrentSection,"");
        }

        private void RefreshMyRemindersDGV()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                MyRemindersData.Clear();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[Title],[Text] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[reminders] where [ToUserID]=" + user.UserID.ToString() + "and [Dismiss]=0 and datediff(minute,[TargetTime],getdate())>0", Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(MyRemindersData);
                RemindersDGV.DataSource = MyRemindersData;
                RemindersDGV.Columns[0].Visible = false;

                RemindersDGV.BorderStyle = BorderStyle.None;
                label3.Text = "أهلا وسهلاً، " + user.DisplayName + " !";
                if (RemindersDGV.Rows.Count > 0)
                {
                    label4.Visible = true;
                    label4.Text = "لديك " + Convert.ToString(RemindersDGV.Rows.Count) + " تذكير";
                    RemindersDGV.Visible = true;
                }
                else
                { label4.Visible = false; RemindersDGV.Visible = false; }
            }
        }

        private void RefreshTodayCallsDGV()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                TodayCallsData.Clear();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[InstituteName] as [المنشأة],[PlantName] as [الوحدة],[Text] as [نص الاتصال]
                FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PhoneCallsLogView] where datediff(day,[TimeStamp],getdate())=0", Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(TodayCallsData);
                TodayCallsDGV.DataSource = TodayCallsData;
                TodayCallsDGV.Columns[0].Visible = false;

                if (TodayCallsDGV.Rows.Count > 0)
                { label5.Visible = true; TodayCallsDGV.Visible = true; }
                else
                { label5.Visible = false; TodayCallsDGV.Visible = false; }
                TodayCallsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void RefreshActiveAppointmentsDGV()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                TodaysAppointments.Clear();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[customer] as [الزبون],[institute] as [المنشأة],[plant] as [وحدة المعالجة],[LastStatus] as [الحالة الأخيرة]
                FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants_view] 
                where datediff(day,[start_time],getdate())>=0 and datediff(day,getdate(),[end_time])>=0 and  [del]=0", Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(TodaysAppointments);

                ActiveAppointmentsDGV.DataSource = TodaysAppointments;
                ActiveAppointmentsDGV.Columns[0].Visible = false;

                if (ActiveAppointmentsDGV.Rows.Count > 0)
                { label7.Visible = true; ActiveAppointmentsDGV.Visible = true; }
                else
                { label7.Visible = false; ActiveAppointmentsDGV.Visible = false; }
                ActiveAppointmentsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();

                else if (Connection.State == ConnectionState.Closed)
                    if (ConnectToDatabase())
                        LoginToAppliacation();
            }
            catch
            { }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connection.Close();
            AppSettingsForm SettingForm = new AppSettingsForm();
            SettingForm.ShowDialog();

            if (SettingForm.SuccessConnect)
                if(ConnectToDatabase())
                    LoginToAppliacation();
        }

        private void LoginToApplicationClick(object sender, EventArgs e)
        {
            if (LoggedIN)
            {
                DisableApplicationControls();
                LoginToAppliacation();
            }
            if (!LoggedIN)
                DisableApplicationControls(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connection.Close();
            Close();
        }

        private void RefreshDGV(CurrentOpenSection Source, string QueryFilter)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand() { Connection = Connection };
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);

                switch (Source)
                {
                    case CurrentOpenSection.Institutes:
                        label1.Text = "المنشأت :";
                        InstitutesData.Clear();
                        Command.CommandText = @"SELECT [id] as [#]" + Settings1.Default.InstituteColumnFilter +
                        " FROM [" + Settings1.Default.DatabaseName + "].[dbo].[institutes_view] WHERE [del]='False' " + QueryFilter;
                        Adapter.Fill(InstitutesData);
                        ItemsDGV.DataSource = InstitutesData;
                        break;

                    case CurrentOpenSection.Plants:
                        label1.Text = "وحدات المعالجة :";
                        PlantsData.Clear();
                        Command.CommandText = @"SELECT [id] as [#]" + Settings1.Default.PlantColumnFilter +
                        "FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants_view] WHERE [del]='False'" + QueryFilter;
                        Adapter.Fill(PlantsData);
                        ItemsDGV.DataSource = PlantsData;
                        break;

                    case CurrentOpenSection.PhoneCallsLog:
                        label1.Text = "سجل اتصالات الزبائن :";
                        PhoneCallsLogData.Clear();
                        Command.CommandText = @"SELECT [id] as [#],[TimeStamp] as [تاريخ الاتصال],[CustomerName] as [اسم الزبون],[InstituteName] as [المنشأة]
                    ,[PlantName] as [الوحدة],[Text] as  [نص المكالمة],[ByUserName] as [من قبل]
                    FROM [" + Settings1.Default.DatabaseName + "].[dbo].[PhoneCallsLogView] where 1=1" + QueryFilter;
                        Adapter.Fill(PhoneCallsLogData);
                        ItemsDGV.DataSource = PhoneCallsLogData;
                        break;

                    case CurrentOpenSection.Programs:
                        label1.Text = "حركات الورشات :";
                        ProgramsData.Clear();
                        Command.CommandText = @"SELECT [id] as [#],[ProgramDate] as [تاريخ البرنامج],[TechnicianName] as [مشرف الورشة],[VehicleName] as [وسيلة النقل],[ProgramText] as [ملاحظة البرنامج]
                    FROM [" + Settings1.Default.DatabaseName + "].[dbo].[ProgramsView]";
                        Adapter.Fill(ProgramsData);
                        ItemsDGV.DataSource = ProgramsData;
                        break;
                        
                    case CurrentOpenSection.DeletedCustomers:
                        label1.Text = "الزبائن المحذوفة :";
                        DeletedCustomersData.Clear();
                        Command.CommandText = @"SELECT [id] as [#],[name] as [الزبون] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] where [del]='True'" + QueryFilter;
                        Adapter.Fill(DeletedCustomersData);
                        ItemsDGV.DataSource = DeletedCustomersData;
                        break;

                    case CurrentOpenSection.DeletedInstitutes:
                        label1.Text = "المنشأت المحذوفة :" + "\n" + "ملاحظة: عند استعادة المنشأة يجب التأكد أن الزبون صاحب المنشأة غير محذوف " ;
                        DeletedInstitutesData.Clear();
                        Command.CommandText = @"SELECT [id] as [#],[name] as [المنشأة],[customer] as [الزبون] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes_view] where [del]='True'" + QueryFilter;
                        Adapter.Fill(DeletedInstitutesData);
                        ItemsDGV.DataSource = DeletedInstitutesData;

                        break;

                    case CurrentOpenSection.DeletedPlants:
                        label1.Text = "الوحدات المحذوفة :";
                        DeletedPlantsData.Clear();
                        Command.CommandText = @"SELECT [id] as [#],[plant] as [الوحدة],[institute] as [المنشأة],[contractor] as [المتعهد],[customer] as [الزبون] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants_view] where [del]='True'" + QueryFilter;
                        Adapter.Fill(DeletedPlantsData);
                        ItemsDGV.DataSource = DeletedPlantsData;
                        break;

                }
                RowsCountLabel.Visible = true;
                RowsCountLabel.Text = Convert.ToString(ItemsDGV.Rows.Count);

                ItemsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ItemsDGV.Columns[0].Width = 30;
                //ItemsDGV.Columns[1].Width = 30;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Home button

            RefreshMyRemindersDGV();
            RefreshTodayCallsDGV();
            RefreshActiveAppointmentsDGV();

            CurrentSection = CurrentOpenSection.Home;
            VerifyUserPermissions(CurrentSection);

            tabControl1.SelectedTab = tabPage1;
            RowsCountLabel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Institutes button
            tabControl1.SelectedTab = tabPage2;

            CurrentSection = CurrentOpenSection.Institutes;
            VerifyUserPermissions(CurrentSection);
            RefreshDGV(CurrentSection,"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //plants display
            tabControl1.SelectedTab = tabPage2;
            CurrentSection = CurrentOpenSection.Plants;
            VerifyUserPermissions(CurrentSection);
            RefreshDGV(CurrentSection,"");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Display Phone Calls Log
            tabControl1.SelectedTab = tabPage2;

            CurrentSection = CurrentOpenSection.PhoneCallsLog;
            VerifyUserPermissions(CurrentSection);
            RefreshDGV(CurrentSection, "");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Services Programs
            tabControl1.SelectedTab = tabPage2;
            CurrentSection = CurrentOpenSection.Programs;
            VerifyUserPermissions(CurrentSection);
            RefreshDGV(CurrentSection, "");
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            TreeViewSelection(e.Node.Name);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            TreeViewSelection(e.Node.Name);
        }

        void TreeViewSelection(string NodeName)
        {
            //Deledted items display

            switch (NodeName)
            {
                case "Node0":
                    CurrentSection = CurrentOpenSection.DeletedCustomers;
                    RefreshDGV(CurrentSection, "");
                    break;
                case "Node1":
                    CurrentSection = CurrentOpenSection.DeletedInstitutes;
                    RefreshDGV(CurrentSection, "");
                    break;
                case "Node2":
                    CurrentSection = CurrentOpenSection.DeletedPlants;
                    RefreshDGV(CurrentSection, "");
                    break;
                case "Node3":
                    CurrentSection = CurrentOpenSection.DeletedCustomers;
                    RefreshDGV(CurrentSection, "");
                    break;
            }
            VerifyUserPermissions(CurrentSection);
        }

        private void ItemsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1 Cell Double Click
            if (ItemsDGV.Rows.Count > 0)
                if (e.RowIndex >= 0)
                    OpenItemWindow();
        }

        private void ItemsDGV_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ItemsDGV.Rows.Count > 0)
                if (e.RowIndex >= 0)
                    if (e.Button == MouseButtons.Right && ItemsDGV.DataSource == PlantsData)
                    {
                        ItemsDGV.Rows[e.RowIndex].Selected = true;
                        PlantToolTip.SetDesktopLocation(MousePosition.X - PlantToolTip.Width / 2, MousePosition.Y);
                        PlantToolTip.PlanID = Convert.ToInt32(ItemsDGV.SelectedCells[0].Value);
                        PlantToolTip.ShowForm();
                    }
        }

        void institute_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDGV(CurrentSection, "");
        }

        private void DeleteItemButton()
        {
            //Delete Item

            if (ItemsDGV.Rows.Count > 0)
                if (ItemsDGV.CurrentRow.Index >= 0)
                    switch (CurrentSection)
                    {
                        case CurrentOpenSection.Institutes:
                            if (DeleteItem.DeleteInstitute(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value)))
                                RefreshDGV(CurrentSection, "");
                            break;

                        case CurrentOpenSection.Plants:
                            if (DeleteItem.DeletePlant(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value)))
                                RefreshDGV(CurrentSection, "");
                            break;
                            
                        case CurrentOpenSection.DeletedCustomers:
                            if(DeleteItem.DeleteCustomer(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value)))
                                RefreshDGV(CurrentSection,"");
                            break;

                        case CurrentOpenSection.DeletedInstitutes:
                            if (DeleteItem.DeleteInstitute(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value)))
                                RefreshDGV(CurrentSection, "");
                            break;

                        case CurrentOpenSection.DeletedPlants:
                            if (DeleteItem.DeletePlant(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value)))
                                RefreshDGV(CurrentSection, "");
                            break;
                        case CurrentOpenSection.Programs:
                            if (DeleteItem.DeleteProgram(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value)))
                                RefreshDGV(CurrentSection, "");
                            break;
                    }
        }

        private void OpenItemWindow()
        {
            //Open saved item; institute, plant, call ....
            if (ItemsDGV.Rows.Count > 0)
                if (ItemsDGV.SelectedCells[0].RowIndex >= 0)
                    switch (CurrentSection)
                    {
                        case CurrentOpenSection.Institutes:
                            {
                                InstituteForm OpenInstitute = new InstituteForm(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value), user);
                                OpenInstitute.FormClosed += new FormClosedEventHandler(institute_FormClosed);
                                OpenInstitute.Show();
                            }
                            break;
                        case CurrentOpenSection.DeletedInstitutes:
                            {
                                InstituteForm OpenInstitute = new InstituteForm(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value), user);
                                OpenInstitute.FormClosed += new FormClosedEventHandler(institute_FormClosed);
                                OpenInstitute.Show();
                            }
                            break;
                        case CurrentOpenSection.Plants:
                            {
                                PlantForm OpenPlant = new PlantForm(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value), user, 1, 0);
                                OpenPlant.FormClosed += new FormClosedEventHandler(plant_FormClosed);
                                OpenPlant.Show();
                            }
                            break;
                        case CurrentOpenSection.DeletedPlants:
                            {
                                PlantForm OpenPlant = new PlantForm(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value), user, 1, 0);
                                OpenPlant.FormClosed += new FormClosedEventHandler(plant_FormClosed);
                                OpenPlant.Show();
                            }
                            break;
                        case CurrentOpenSection.PhoneCallsLog:
                            CallWindow OpenCallWindow = new CallWindow(user, Convert.ToInt32(ItemsDGV.SelectedCells[0].Value));
                            OpenCallWindow.FormClosed += new FormClosedEventHandler(NewCallWindow_FormClosed);
                            OpenCallWindow.Show();
                            break;
                        case CurrentOpenSection.Programs:
                            ProgramForm OpenServiceProgram = new ProgramForm(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value), user);
                            OpenServiceProgram.FormClosed += new FormClosedEventHandler(NewServiceProgram_FormClosed);
                            OpenServiceProgram.Show();
                            break;
                    }
        }

        private void RestoreFromRecyclebin()
        {
            if (ItemsDGV.Rows.Count > 0)
                if (ItemsDGV.CurrentRow.Index >= 0)
                    switch (CurrentSection)
                    {
                        case CurrentOpenSection.DeletedInstitutes:
                            if (RestoreItem.RestoreInstitute(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value)))
                                RefreshDGV(CurrentSection, "");
                            break;
                        case CurrentOpenSection.DeletedPlants:
                            if (RestoreItem.RestorePlant(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value)))
                                RefreshDGV(CurrentSection, "");
                            break;
                        case CurrentOpenSection.DeletedCustomers:
                            if (RestoreItem.RestoreCustomer(Convert.ToInt32(ItemsDGV.SelectedCells[0].Value)))
                                RefreshDGV(CurrentSection, "");
                            break;
                    }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //New Item
            switch (CurrentSection)
            {
                case CurrentOpenSection.Institutes:
                    InstituteForm NewInstitute = new InstituteForm(user);
                    NewInstitute.Show();
                    NewInstitute.FormClosed+=new FormClosedEventHandler(institute_FormClosed);
                    break;
                case CurrentOpenSection.Plants:
                    PlantForm NewPlant = new PlantForm(user);
                    NewPlant.FormClosed+=new FormClosedEventHandler(plant_FormClosed);
                    NewPlant.Show();
                    break;
                case CurrentOpenSection.PhoneCallsLog:
                    CallWindow NewCallWindow = new CallWindow(user);
                    NewCallWindow.Show();
                    NewCallWindow.FormClosed += new FormClosedEventHandler(NewCallWindow_FormClosed);
                    break;
                case CurrentOpenSection.Programs:
                    ProgramForm NewServiceProgram = new ProgramForm(user);
                    NewServiceProgram.FormClosed += new FormClosedEventHandler(NewServiceProgram_FormClosed);
                    NewServiceProgram.Show();
                    break;
            }
        }

        void NewServiceProgram_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDGV(CurrentOpenSection.Programs, "");
        }

        void NewCallWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDGV(CurrentOpenSection.PhoneCallsLog, "");
        }

        private void الزبائنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm CustomersWindow = new CustomersForm(user);
            CustomersWindow.ShowDialog();
        }

        private void المتعهدينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractorsForm contractors = new ContractorsForm(user);
            contractors.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Refresh button
            RefreshDGV(CurrentSection, "");
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            BackupDBForm backup = new BackupDBForm();
            backup.ShowDialog();
        }

        private void تذكيرجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReminderCreator NewReminder = new ReminderCreator(user);
            NewReminder.Show();
        }

        [DebuggerStepThrough]
        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            //Check For Reminders Sent to Me on Timer Tick

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[reminders] 
                WHERE [Dismiss]=0 and datediff(minute,[TargetTime],getdate())>0 and [ToUserID]=" + user.UserID, Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!OpenRemindersList.Contains(Reader.GetInt32(0)))
                        {
                            Reminder ReminderWindow = new Reminder(Reader.GetInt32(0));
                            OpenRemindersList.Add(Reader.GetInt32(0));
                            ReminderWindow.Show();
                        }
                    }
            }
        }

        private void BackupTimer_Tick(object sender, EventArgs e)
        {
            //النسخ الاحتياطي الاوتوماتيكي
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                DateTime LastBackupDate = new DateTime();
                SqlCommand Command = new SqlCommand(@"SELECT [date] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[BackupSummary] WHERE datediff(day,[date],getdate())=0", Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                        LastBackupDate = Reader.GetDateTime(0);
                Reader.Close();

                if (LastBackupDate.Hour + Settings1.Default.BackupInterval < DateTime.Now.Hour)
                {
                    StatusLabel4.Text = "جاري عمل نسخة احتياطية";
                    StatusLabel4.Visible = true;

                    if (!backgroundWorker1.IsBusy)
                        backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                try
                {
                    /* Command.CommandText = @"USE [master]
                     declare @myPath NVARCHAR(512)
                     set @myPath=N'@path\Backup  + replace(convert(varchar,getdate(),120),':','-') + '.bak' 
                     BACKUP DATABASE [@DB] TO  DISK = @myPath WITH NOFORMAT, NOINIT,  NAME = N'@BackupName', SKIP, NOREWIND, NOUNLOAD,  STATS = 10, CHECKSUM";
                
                     Command.Parameters.Add("@path", SqlDbType.NVarChar).Value = Settings1.Default.BackupFolder;
                     Command.Parameters.Add("@DB", SqlDbType.NVarChar).Value = Settings1.Default.DatabaseName;
                     Command.Parameters.Add("@BackupName", SqlDbType.NVarChar).Value = Settings1.Default.DatabaseName;*/

                    SqlCommand Command = new SqlCommand(@"BACKUP DATABASE [" + Settings1.Default.DatabaseName + "] TO  DISK = N'" + Settings1.Default.BackupFolder + "\\Backup " + DateTime.Now.ToString("yyyy-MM-dd hh:mm ", new System.Globalization.CultureInfo("en-US")).Replace("/", "-").Replace(":", "-") + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'" + Settings1.Default.DatabaseName + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10, CHECKSUM", Connection);
                    Command.ExecuteNonQuery();

                    Command.CommandText = @"INSERT INTO [" + Settings1.Default.DatabaseName + "].[dbo].[BackupSummary] ([date]) Values (convert(datetime,'" + DateTime.Now.ToString("yyyy-MM-dd hh:mm tt", new System.Globalization.CultureInfo("en-US")) + @"',102))";
                    Command.ExecuteNonQuery();
                    BackupStatus = "تم عمل نسخة احتياطية";
                }
                catch (Exception exp)
                { BackupStatus = "خطأ في عملية النسخ الاحتياطي"; }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StatusLabel4.Text = BackupStatus;
            ClearStatusTimer.Enabled = true;
        }

        private void التذكيراتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemindersViewForm RemindersView = new RemindersViewForm(user);
            RemindersView.Show();
        }

        private void ClearStatusTimer_Tick(object sender, EventArgs e)
        {
            StatusLabel4.Text = "";
            ClearStatusTimer.Enabled = false;
        }

        private void عنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //about program
            SplashScreen SplashScreen = new SplashScreen();
            SplashScreen.EnableEventHandler = true;
            SplashScreen.timer1.Enabled = false;
            SplashScreen.ShowDialog();
        }

        private void تفعيلالنسخةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicensingApplicationForm LicenseWindow = new LicensingApplicationForm();
            LicenseWindow.ShowDialog();
        }

        private void CheckActivationStatus()
        {
            //old: if(Settings1.Default.APPFRUN &&
            if ( !File.Exists(Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\pma"))
            {
                try
                {
                    SWriter = new StreamWriter(Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\pma");
                    SWriter.WriteLine(ActivateProjectsManager.CreateTrialCode());
                    SWriter.Close();
                    TrialTimer.Enabled = true;
                    Settings1.Default.APPFRUN = false;
                    MessageBox.Show("تم تفعيل البرنامج للعمل كنسخة تجريبية لمدة 25 مرة" + "\n ستتم اعادة تشغيل البرنامج", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ProcessStartInfo Info = new ProcessStartInfo();
                    Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                    Info.WindowStyle = ProcessWindowStyle.Hidden;
                    Info.CreateNoWindow = true;
                    Info.FileName = "cmd.exe";
                    Process.Start(Info);
                    Application.Exit();
                }
                catch (Exception exp)
                { ActivationError(); }
            }
            else
            {
                if (File.Exists(Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\pma"))
                {
                    try
                    {
                        SReader = new StreamReader(Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\pma");
                        AI = ActivateProjectsManager.ReadActivation(SReader.ReadLine());
                        SReader.Close();

                        if (!AI.CorruptActivation)
                        {
                            if (AI.ActivationStatus == ActivationStatus.Trial)
                            {
                                if (AI.TrialDays > 0)
                                {
                                    SWriter = new StreamWriter(Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\pma");
                                    SWriter.WriteLine(ActivateProjectsManager.ReduceTrialDays(AI.LicenseString));
                                    SWriter.Close();
                                    TrialTimer.Enabled = true;
                                    Text += " - [نسخة تجريبية]";
                                }
                                else
                                {
                                    Text += " - [انتهاء مدة النسخة التجريبية]";
                                    TrialPeriodEnd = true;
                                    LicensingApplicationForm LicenseWindow = new LicensingApplicationForm();
                                    LicenseWindow.ShowDialog();
                                }
                            }
                        }
                        else
                        { ActivationError(); }
                    }
                    catch (Exception exp)
                    { ActivationError(); }
                }
                else
                { ActivationError(); }
            }
        }

        private void ActivationError()
        {
            DisableApplicationControls();
            StatusLabel4.Visible = true;
            StatusLabel4.Text = "مشكلة في تفعيل النسخة";
        }

        private void TrialTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                    TrialTimer.Enabled = false;
                }
            }
            catch
            { }

            MessageBox.Show("شكراً لاستخدامك هذه النسخة التجريبية من البرنامج \n" + "لتفعيل النسخة يرجى اختيار مساعدة - تفعيل النسخة \n" + "سيتم اغلاق البرنامج", "مدير المشاريع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings1.Default.Save();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void RemindersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Reminder OpenReminderWindow = new Reminder(Convert.ToInt32(RemindersDGV.SelectedCells[0].Value));
            OpenReminderWindow.Show();
        }

        private void CallsDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CallWindow OpenCallWindow = new CallWindow(user, Convert.ToInt32(TodayCallsDGV.SelectedCells[0].Value));
            OpenCallWindow.Show();
        }

        private void ActiveAppointmentsDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PlantForm OpenPlantWindow = new PlantForm(Convert.ToInt32(ActiveAppointmentsDGV.SelectedCells[0].Value), user, 1, 0);
            OpenPlantWindow.Show();
        }

        private void ManageUsersMenuItem_Click(object sender, EventArgs e)
        {
            UsersManagementForm UsersManagmentWindow = new UsersManagementForm();
            UsersManagmentWindow.ShowDialog();
        }

        private void RestoreDBMenuItem_Click(object sender, EventArgs e)
        {
            //Connection.Close();

            RestoreDBBackupForm RestoreDBBackupWindow = new RestoreDBBackupForm();
            RestoreDBBackupWindow.ShowDialog();
        }

        private void NewDBMenuMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewDBform NewDB = new CreateNewDBform();
            NewDB.ShowDialog();
        }

        private void AppSettingsMenuItem_Click(object sender, EventArgs e)
        {
            DBSettingsForm AppSettingsWindow = new DBSettingsForm(user);
            AppSettingsWindow.FormClosed += new FormClosedEventHandler(AppSettingsWindow_FormClosed);
            AppSettingsWindow.ShowDialog();
        }

        void AppSettingsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDBSettings();
        }

        private void VehicleMenuItem_Click(object sender, EventArgs e)
        {
            VehiclesWindow CarsWindow = new VehiclesWindow(user);
            CarsWindow.ShowDialog();
        }

        private void techniciansMenuItem_Click(object sender, EventArgs e)
        {
            TechniciansWindow NewTechniciansWindow = new TechniciansWindow(user);
            NewTechniciansWindow.ShowDialog();
        }

        private void InstituteProfessionsMenuItem_Click(object sender, EventArgs e)
        {
            InstituteProfessionsWindow InstituteProfessionsWindow = new InstituteProfessionsWindow(user);
            InstituteProfessionsWindow.ShowDialog();
        }


        void PlantTabChoosen(object sender, PropertyChangedEventArgs e)
        {
            PlantForm OpenPlant = new PlantForm(PlantToolTip.PlanID, user, PlantToolTip.SelectedTab, 0);
            OpenPlant.FormClosed += new FormClosedEventHandler(plant_FormClosed);
            OpenPlant.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            OpenItemWindow();
        }

        private void AdvancedSearchButton_Click(object sender, EventArgs e)
        {
            //Show advanced Panel Search
            switch (CurrentSection)
            {
                case CurrentOpenSection.Institutes:
                    try
                    {
                        InstituteSearchPanel.SetDesktopLocation(ToolBar.PointToScreen(Point.Empty).X + ToolBar.Width / 3, ToolBar.PointToScreen(Point.Empty).Y + AdvancedSearchButton.Size.Height);
                        InstituteSearchPanel.ShowForm();
                    }
                    catch (Exception exp)
                    { }
                    break;
                case CurrentOpenSection.Plants:
                    try
                    {
                        PlantSearchPanel.SetDesktopLocation(ToolBar.PointToScreen(Point.Empty).X + ToolBar.Width / 3, ToolBar.PointToScreen(Point.Empty).Y + AdvancedSearchButton.Size.Height);
                        PlantSearchPanel.ShowForm();
                    }
                    catch (Exception exp)
                    { }
                    break;
                case CurrentOpenSection.PhoneCallsLog:
                    try
                    {
                        CallSearchPanel.SetDesktopLocation(ToolBar.PointToScreen(Point.Empty).X + ToolBar.Width / 3, ToolBar.PointToScreen(Point.Empty).Y + AdvancedSearchButton.Size.Height);
                        CallSearchPanel.ShowForm();
                    }
                    catch (Exception exp)
                    { }
                    break;
            }
        }

        void InstituteSearchPanel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RefreshDGV(CurrentSection, InstituteSearchPanel.QueryFilter);
        }
        
        void PlantSearchPanel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RefreshDGV(CurrentSection, PlantSearchPanel.QueryFilter);
        }
        
        void CallSearch_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RefreshDGV(CurrentSection, CallSearchPanel.QueryFilter);
        }

        private void اختيارالحقولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColumnsSelectForm CS = new ColumnsSelectForm();
            CS.ShowDialog();
            try
            {
                RefreshDGV(CurrentSection, "");
            }
            catch
            { }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteItemButton();
        }

        private void FastSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //Fast Search box
            switch (CurrentSection)
            {
                case CurrentOpenSection.Institutes:
                    RefreshDGV(CurrentSection, @" and [name] LIKE '%" + ReplaceChar.ReplaceAChar(FastSearchTextBox.Text) + @"%'");
                    break;

                case CurrentOpenSection.Plants:
                    RefreshDGV(CurrentSection, @" and [plant] LIKE '%" + ReplaceChar.ReplaceAChar(FastSearchTextBox.Text) + @"%'");
                    break;

                case CurrentOpenSection.DeletedInstitutes:
                    RefreshDGV(CurrentSection, @" and [name] LIKE '%" + ReplaceChar.ReplaceAChar(FastSearchTextBox.Text) + @"%'");
                    break;

                case CurrentOpenSection.DeletedPlants:
                    RefreshDGV(CurrentSection, @" and [plant] LIKE '%" + ReplaceChar.ReplaceAChar(FastSearchTextBox.Text) + @"%'");
                    break;
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            RestoreFromRecyclebin();
        }

        private void FastSearchTextBox_Enter(object sender, EventArgs e)
        {
            //FastSearchTextBox.Width = 150;
        }

        private void EnterServiceButton_Click(object sender, EventArgs e)
        {
            EnterServiceTextForVisit VisitSearch = new EnterServiceTextForVisit(user);
            VisitSearch.ShowDialog();
        }

        private void أنواعوحداتالمعالجةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlantTypeForm PlantTypeForm = new PlantTypeForm(user);
            PlantTypeForm.ShowDialog();
        }

        private void ApplicationWizardMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationWizardForm WizardForm = new ApplicationWizardForm();
            WizardForm.ShowDialog();

            if (WizardForm.SuccessDBConnect || WizardForm.SuccessDBCreation)
                if (ConnectToDatabase())
                    LoginToAppliacation();

            //if () { }
        }







    }
}
