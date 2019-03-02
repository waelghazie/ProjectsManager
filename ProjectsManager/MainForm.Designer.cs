namespace ProjectsManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("الزبائن");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("المنشآت");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("وحدات المعالجة");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("العناصر المحذوفة", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ApplicationWizardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بطاقاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الزبائنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المتعهدينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.VehicleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techniciansMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstituteProfessionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أنواعوحداتالمعالجةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التذكيراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تذكيرجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التذكيراتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageUsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BackupMenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إنشاءنسخةاحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreDBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDBMenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اختيارالحقولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مساعدةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تفعيلالنسخةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عنالبرنامجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ConnectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatabaseLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoggedUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RowsCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ReminderTimer = new System.Windows.Forms.Timer(this.components);
            this.BackupTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClearStatusTimer = new System.Windows.Forms.Timer(this.components);
            this.TrialTimer = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1 = new ProjectsManager.TablessControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TodayDateLabel = new System.Windows.Forms.Label();
            this.clock1 = new AnalogClock.Clock();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveAppointmentsDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RemindersDGV = new System.Windows.Forms.DataGridView();
            this.TodayCallsDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RestoreButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.FastSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.AdvancedSearchButton = new System.Windows.Forms.ToolStripButton();
            this.EnterServiceReportButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveAppointmentsDGV)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemindersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodayCallsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).BeginInit();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.بطاقاتToolStripMenuItem,
            this.التذكيراتToolStripMenuItem,
            this.ManagementMenuItem,
            this.ViewMenuItem,
            this.مساعدةToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.LoginMenuItem,
            this.toolStripSeparator3,
            this.ApplicationWizardMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.mainToolStripMenuItem.Text = "رئيسية";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "اتصال / قطع الاتصال";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoginMenuItem.Text = "تسجيل دخول / خروج";
            this.LoginMenuItem.Click += new System.EventHandler(this.LoginToApplicationClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // ApplicationWizardMenuItem
            // 
            this.ApplicationWizardMenuItem.Name = "ApplicationWizardMenuItem";
            this.ApplicationWizardMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ApplicationWizardMenuItem.Text = "معالج اعداد البرنامج";
            this.ApplicationWizardMenuItem.Click += new System.EventHandler(this.ApplicationWizardMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "إعدادات البرنامج";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // بطاقاتToolStripMenuItem
            // 
            this.بطاقاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الزبائنToolStripMenuItem,
            this.المتعهدينToolStripMenuItem,
            this.toolStripSeparator6,
            this.VehicleMenuItem,
            this.techniciansMenuItem,
            this.InstituteProfessionsMenuItem,
            this.أنواعوحداتالمعالجةToolStripMenuItem});
            this.بطاقاتToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.بطاقاتToolStripMenuItem.Name = "بطاقاتToolStripMenuItem";
            this.بطاقاتToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.بطاقاتToolStripMenuItem.Text = "بطاقات";
            // 
            // الزبائنToolStripMenuItem
            // 
            this.الزبائنToolStripMenuItem.Name = "الزبائنToolStripMenuItem";
            this.الزبائنToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.الزبائنToolStripMenuItem.Text = "الزبائن";
            this.الزبائنToolStripMenuItem.Click += new System.EventHandler(this.الزبائنToolStripMenuItem_Click);
            // 
            // المتعهدينToolStripMenuItem
            // 
            this.المتعهدينToolStripMenuItem.Name = "المتعهدينToolStripMenuItem";
            this.المتعهدينToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.المتعهدينToolStripMenuItem.Text = "المتعهدون";
            this.المتعهدينToolStripMenuItem.Click += new System.EventHandler(this.المتعهدينToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(174, 6);
            // 
            // VehicleMenuItem
            // 
            this.VehicleMenuItem.Name = "VehicleMenuItem";
            this.VehicleMenuItem.Size = new System.Drawing.Size(177, 22);
            this.VehicleMenuItem.Text = "وسائل النقل";
            this.VehicleMenuItem.Click += new System.EventHandler(this.VehicleMenuItem_Click);
            // 
            // techniciansMenuItem
            // 
            this.techniciansMenuItem.Name = "techniciansMenuItem";
            this.techniciansMenuItem.Size = new System.Drawing.Size(177, 22);
            this.techniciansMenuItem.Text = "الفنيين";
            this.techniciansMenuItem.Click += new System.EventHandler(this.techniciansMenuItem_Click);
            // 
            // InstituteProfessionsMenuItem
            // 
            this.InstituteProfessionsMenuItem.Name = "InstituteProfessionsMenuItem";
            this.InstituteProfessionsMenuItem.Size = new System.Drawing.Size(177, 22);
            this.InstituteProfessionsMenuItem.Text = "اختصاصات المنشأت";
            this.InstituteProfessionsMenuItem.Click += new System.EventHandler(this.InstituteProfessionsMenuItem_Click);
            // 
            // أنواعوحداتالمعالجةToolStripMenuItem
            // 
            this.أنواعوحداتالمعالجةToolStripMenuItem.Name = "أنواعوحداتالمعالجةToolStripMenuItem";
            this.أنواعوحداتالمعالجةToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.أنواعوحداتالمعالجةToolStripMenuItem.Text = "أنواع وحدات المعالجة";
            this.أنواعوحداتالمعالجةToolStripMenuItem.Click += new System.EventHandler(this.أنواعوحداتالمعالجةToolStripMenuItem_Click);
            // 
            // التذكيراتToolStripMenuItem
            // 
            this.التذكيراتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تذكيرجديدToolStripMenuItem,
            this.التذكيراتToolStripMenuItem1});
            this.التذكيراتToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.التذكيراتToolStripMenuItem.Name = "التذكيراتToolStripMenuItem";
            this.التذكيراتToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.التذكيراتToolStripMenuItem.Text = "التذكيرات";
            // 
            // تذكيرجديدToolStripMenuItem
            // 
            this.تذكيرجديدToolStripMenuItem.Name = "تذكيرجديدToolStripMenuItem";
            this.تذكيرجديدToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.تذكيرجديدToolStripMenuItem.Text = "تذكير جديد";
            this.تذكيرجديدToolStripMenuItem.Click += new System.EventHandler(this.تذكيرجديدToolStripMenuItem_Click);
            // 
            // التذكيراتToolStripMenuItem1
            // 
            this.التذكيراتToolStripMenuItem1.Name = "التذكيراتToolStripMenuItem1";
            this.التذكيراتToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.التذكيراتToolStripMenuItem1.Text = "التذكيرات";
            this.التذكيراتToolStripMenuItem1.Click += new System.EventHandler(this.التذكيراتToolStripMenuItem1_Click);
            // 
            // ManagementMenuItem
            // 
            this.ManagementMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppSettingsMenuItem,
            this.ManageUsersMenuItem,
            this.toolStripSeparator4,
            this.BackupMenuMenuItem,
            this.NewDBMenuMenuItem});
            this.ManagementMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementMenuItem.Name = "ManagementMenuItem";
            this.ManagementMenuItem.Size = new System.Drawing.Size(41, 20);
            this.ManagementMenuItem.Text = "ادارة";
            // 
            // AppSettingsMenuItem
            // 
            this.AppSettingsMenuItem.Name = "AppSettingsMenuItem";
            this.AppSettingsMenuItem.Size = new System.Drawing.Size(185, 22);
            this.AppSettingsMenuItem.Text = "إعدادات قاعدة البيانات";
            this.AppSettingsMenuItem.Click += new System.EventHandler(this.AppSettingsMenuItem_Click);
            // 
            // ManageUsersMenuItem
            // 
            this.ManageUsersMenuItem.Name = "ManageUsersMenuItem";
            this.ManageUsersMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ManageUsersMenuItem.Text = "إدارة المستخدمين";
            this.ManageUsersMenuItem.Click += new System.EventHandler(this.ManageUsersMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(182, 6);
            // 
            // BackupMenuMenuItem
            // 
            this.BackupMenuMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إنشاءنسخةاحتياطيةToolStripMenuItem,
            this.RestoreDBMenuItem});
            this.BackupMenuMenuItem.Name = "BackupMenuMenuItem";
            this.BackupMenuMenuItem.Size = new System.Drawing.Size(185, 22);
            this.BackupMenuMenuItem.Text = "نسخ احتياطي";
            // 
            // إنشاءنسخةاحتياطيةToolStripMenuItem
            // 
            this.إنشاءنسخةاحتياطيةToolStripMenuItem.Name = "إنشاءنسخةاحتياطيةToolStripMenuItem";
            this.إنشاءنسخةاحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.إنشاءنسخةاحتياطيةToolStripMenuItem.Text = "إنشاء نسخة احتياطية";
            this.إنشاءنسخةاحتياطيةToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // RestoreDBMenuItem
            // 
            this.RestoreDBMenuItem.Name = "RestoreDBMenuItem";
            this.RestoreDBMenuItem.Size = new System.Drawing.Size(198, 22);
            this.RestoreDBMenuItem.Text = "استرجاع نسخة احتياطية";
            this.RestoreDBMenuItem.Click += new System.EventHandler(this.RestoreDBMenuItem_Click);
            // 
            // NewDBMenuMenuItem
            // 
            this.NewDBMenuMenuItem.Name = "NewDBMenuMenuItem";
            this.NewDBMenuMenuItem.Size = new System.Drawing.Size(185, 22);
            this.NewDBMenuMenuItem.Text = "قاعدة بيانات جديدة";
            this.NewDBMenuMenuItem.Click += new System.EventHandler(this.NewDBMenuMenuItem_Click);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اختيارالحقولToolStripMenuItem});
            this.ViewMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ViewMenuItem.Text = "عرض";
            // 
            // اختيارالحقولToolStripMenuItem
            // 
            this.اختيارالحقولToolStripMenuItem.Name = "اختيارالحقولToolStripMenuItem";
            this.اختيارالحقولToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.اختيارالحقولToolStripMenuItem.Text = "اختيار الحقول";
            this.اختيارالحقولToolStripMenuItem.Click += new System.EventHandler(this.اختيارالحقولToolStripMenuItem_Click);
            // 
            // مساعدةToolStripMenuItem
            // 
            this.مساعدةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تفعيلالنسخةToolStripMenuItem,
            this.عنالبرنامجToolStripMenuItem});
            this.مساعدةToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.مساعدةToolStripMenuItem.Name = "مساعدةToolStripMenuItem";
            this.مساعدةToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.مساعدةToolStripMenuItem.Text = "مساعدة";
            // 
            // تفعيلالنسخةToolStripMenuItem
            // 
            this.تفعيلالنسخةToolStripMenuItem.Name = "تفعيلالنسخةToolStripMenuItem";
            this.تفعيلالنسخةToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.تفعيلالنسخةToolStripMenuItem.Text = "تفعيل النسخة";
            this.تفعيلالنسخةToolStripMenuItem.Click += new System.EventHandler(this.تفعيلالنسخةToolStripMenuItem_Click);
            // 
            // عنالبرنامجToolStripMenuItem
            // 
            this.عنالبرنامجToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.عنالبرنامجToolStripMenuItem.Name = "عنالبرنامجToolStripMenuItem";
            this.عنالبرنامجToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.عنالبرنامجToolStripMenuItem.Text = "عن البرنامج";
            this.عنالبرنامجToolStripMenuItem.Click += new System.EventHandler(this.عنالبرنامجToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionStatusLabel,
            this.DatabaseLabel,
            this.LoggedUserLabel,
            this.RowsCountLabel,
            this.StatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(888, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(86, 17);
            this.ConnectionStatusLabel.Text = "ConnectionLabel";
            this.ConnectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseLabel.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatabaseLabel.Size = new System.Drawing.Size(78, 17);
            this.DatabaseLabel.Text = "DatabaseLabel";
            // 
            // LoggedUserLabel
            // 
            this.LoggedUserLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedUserLabel.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.LoggedUserLabel.Name = "LoggedUserLabel";
            this.LoggedUserLabel.Size = new System.Drawing.Size(89, 17);
            this.LoggedUserLabel.Text = "LoggedUserLabel";
            // 
            // RowsCountLabel
            // 
            this.RowsCountLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowsCountLabel.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.RowsCountLabel.Name = "RowsCountLabel";
            this.RowsCountLabel.Size = new System.Drawing.Size(87, 17);
            this.RowsCountLabel.Text = "RowsCountLabel";
            // 
            // StatusLabel4
            // 
            this.StatusLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel4.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.StatusLabel4.Name = "StatusLabel4";
            this.StatusLabel4.Size = new System.Drawing.Size(69, 17);
            this.StatusLabel4.Text = "StatusLabel4";
            // 
            // ReminderTimer
            // 
            this.ReminderTimer.Interval = 240000;
            this.ReminderTimer.Tick += new System.EventHandler(this.ReminderTimer_Tick);
            // 
            // BackupTimer
            // 
            this.BackupTimer.Interval = 300000;
            this.BackupTimer.Tick += new System.EventHandler(this.BackupTimer_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ClearStatusTimer
            // 
            this.ClearStatusTimer.Interval = 300000;
            this.ClearStatusTimer.Tick += new System.EventHandler(this.ClearStatusTimer_Tick);
            // 
            // TrialTimer
            // 
            this.TrialTimer.Interval = 3600000;
            this.TrialTimer.Tick += new System.EventHandler(this.TrialTimer_Tick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button7.Image = global::ProjectsManager.Properties.Resources.Programs;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(0, 270);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "حركة الورشات";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button6.Image = global::ProjectsManager.Properties.Resources.CallLog1;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(0, 225);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "الاتصالات";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button3.Image = global::ProjectsManager.Properties.Resources.plant;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(0, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "وحدات المعالجة";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button2.Image = global::ProjectsManager.Properties.Resources.institutes1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "المنشآت";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 45);
            this.panel3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7F);
            this.button1.Image = global::ProjectsManager.Properties.Resources.home1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 45);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(143, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "الصفحة الرئيسية";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 45);
            this.panel4.TabIndex = 10;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 470);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "الزبائن";
            treeNode2.Name = "Node1";
            treeNode2.Text = "المنشآت";
            treeNode3.Name = "Node2";
            treeNode3.Text = "وحدات المعالجة";
            treeNode4.Name = "Node0";
            treeNode4.Text = "العناصر المحذوفة";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(143, 79);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 558);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.treeView1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(149, 552);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(143, 461);
            this.panel5.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(158, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 552);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(713, 440);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TodayDateLabel);
            this.panel1.Controls.Add(this.clock1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 434);
            this.panel1.TabIndex = 0;
            // 
            // TodayDateLabel
            // 
            this.TodayDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayDateLabel.Location = new System.Drawing.Point(6, 139);
            this.TodayDateLabel.Name = "TodayDateLabel";
            this.TodayDateLabel.Size = new System.Drawing.Size(164, 29);
            this.TodayDateLabel.TabIndex = 6;
            this.TodayDateLabel.Text = "تاريخ ";
            this.TodayDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clock1
            // 
            this.clock1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clock1.BigMarkers = new AnalogClock.Marker[] {
        new AnalogClock.Marker("BigMarker90", 90F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker60", 60F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker30", 30F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker0", 0F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker330", 330F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker300", 300F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker270", 270F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker240", 240F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker210", 210F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker180", 180F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker150", 150F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("BigMarker120", 120F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.06F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null)};
            this.clock1.CenterPoint.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
            this.clock1.CenterPoint.RelativeRadius = 0.03F;
            this.clock1.CenterPoint.Tag = null;
            this.clock1.HourHand.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
            this.clock1.HourHand.RelativeRadius = 0.65F;
            this.clock1.HourHand.Tag = null;
            this.clock1.HourHand.Width = 5F;
            this.clock1.Location = new System.Drawing.Point(28, 10);
            this.clock1.MinuteHand.Motion = AnalogClock.HandMotion.Sweep;
            this.clock1.MinuteHand.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
            this.clock1.MinuteHand.RelativeRadius = 0.8F;
            this.clock1.MinuteHand.Tag = null;
            this.clock1.MinuteHand.Width = 5F;
            this.clock1.Name = "clock1";
            this.clock1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clock1.SecondHand.Motion = AnalogClock.HandMotion.Sweep;
            this.clock1.SecondHand.PaintAttributes = new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F);
            this.clock1.SecondHand.RelativeRadius = 0.9F;
            this.clock1.SecondHand.Tag = null;
            this.clock1.SecondHand.Width = 1F;
            this.clock1.Size = new System.Drawing.Size(122, 114);
            this.clock1.SmallMarkers = new AnalogClock.Marker[] {
        new AnalogClock.Marker("SmallMarker90", 90F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker84", 84F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker78", 78F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker72", 72F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker66", 66F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker60", 60F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker54", 54F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker48", 48F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker42", 42F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker36", 36F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker30", 30F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker24", 24F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker18", 18F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker12", 12F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker6", 6F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker0", 0F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker354", 354F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker348", 348F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker342", 342F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker336", 336F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker330", 330F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker324", 324F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker318", 318F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker312", 312F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker306", 306F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker300", 300F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker294", 294F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker288", 288F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker282", 282F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker276", 276F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker270", 270F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker264", 264F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker258", 258F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker252", 252F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker246", 246F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker240", 240F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker234", 234F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker228", 228F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker222", 222F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker216", 216F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker210", 210F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker204", 204F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker198", 198F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker192", 192F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker186", 186F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker180", 180F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker174", 174F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker168", 168F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker162", 162F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker156", 156F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker150", 150F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker144", 144F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker138", 138F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker132", 132F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker126", 126F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker120", 120F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker114", 114F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker108", 108F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker102", 102F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null),
        new AnalogClock.Marker("SmallMarker96", 96F, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, true, 57F, 1F, 0.03F, 1F, new AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1F), AnalogClock.SmoothMode.AntiAlias, null)};
            this.clock1.Symbols = new AnalogClock.Symbol[] {
        new AnalogClock.Symbol("Symbol90", 90F, "12", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 0, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol60", 60F, "1", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 1, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol30", 30F, "2", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 2, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol0", 0F, "3", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 3, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol330", 330F, "4", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 4, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol300", 300F, "5", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 5, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol270", 270F, "6", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 6, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol240", 240F, "7", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 7, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol210", 210F, "8", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 8, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol180", 180F, "9", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 9, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol150", 150F, "10", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 10, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null),
        new AnalogClock.Symbol("Symbol120", 120F, "11", new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), System.Drawing.Color.Black, new System.Drawing.Point(1, 1), 11, true, true, AnalogClock.SymbolStyle.Numeric, 57F, 0.82F, System.Drawing.Text.TextRenderingHint.SystemDefault, null)};
            this.clock1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.ActiveAppointmentsDGV, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(210, 10);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(493, 420);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // ActiveAppointmentsDGV
            // 
            this.ActiveAppointmentsDGV.AllowUserToAddRows = false;
            this.ActiveAppointmentsDGV.AllowUserToDeleteRows = false;
            this.ActiveAppointmentsDGV.AllowUserToOrderColumns = true;
            this.ActiveAppointmentsDGV.AllowUserToResizeRows = false;
            this.ActiveAppointmentsDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ActiveAppointmentsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ActiveAppointmentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ActiveAppointmentsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ActiveAppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ActiveAppointmentsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ActiveAppointmentsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveAppointmentsDGV.EnableHeadersVisualStyles = false;
            this.ActiveAppointmentsDGV.Location = new System.Drawing.Point(3, 234);
            this.ActiveAppointmentsDGV.MultiSelect = false;
            this.ActiveAppointmentsDGV.Name = "ActiveAppointmentsDGV";
            this.ActiveAppointmentsDGV.ReadOnly = true;
            this.ActiveAppointmentsDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActiveAppointmentsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ActiveAppointmentsDGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ActiveAppointmentsDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ActiveAppointmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActiveAppointmentsDGV.Size = new System.Drawing.Size(487, 183);
            this.ActiveAppointmentsDGV.TabIndex = 10;
            this.ActiveAppointmentsDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActiveAppointmentsDGV_CellContentDoubleClick);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 210);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(487, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "المواعيد النشطة:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.RemindersDGV, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.TodayCallsDGV, 3, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(487, 204);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(264, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 44);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(-18, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "أهلا وسهلا";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(-18, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "لديك";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "اتصالات اليوم:";
            // 
            // RemindersDGV
            // 
            this.RemindersDGV.AllowUserToAddRows = false;
            this.RemindersDGV.AllowUserToDeleteRows = false;
            this.RemindersDGV.AllowUserToOrderColumns = true;
            this.RemindersDGV.AllowUserToResizeRows = false;
            this.RemindersDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.RemindersDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RemindersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RemindersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RemindersDGV.ColumnHeadersVisible = false;
            this.RemindersDGV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RemindersDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.RemindersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemindersDGV.Location = new System.Drawing.Point(247, 53);
            this.RemindersDGV.MultiSelect = false;
            this.RemindersDGV.Name = "RemindersDGV";
            this.RemindersDGV.ReadOnly = true;
            this.RemindersDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RemindersDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.RemindersDGV.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.RemindersDGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.RemindersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RemindersDGV.Size = new System.Drawing.Size(217, 158);
            this.RemindersDGV.TabIndex = 3;
            this.RemindersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RemindersDGV_CellContentClick);
            // 
            // TodayCallsDGV
            // 
            this.TodayCallsDGV.AllowUserToAddRows = false;
            this.TodayCallsDGV.AllowUserToDeleteRows = false;
            this.TodayCallsDGV.AllowUserToOrderColumns = true;
            this.TodayCallsDGV.AllowUserToResizeRows = false;
            this.TodayCallsDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TodayCallsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TodayCallsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TodayCallsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TodayCallsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TodayCallsDGV.DefaultCellStyle = dataGridViewCellStyle10;
            this.TodayCallsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodayCallsDGV.EnableHeadersVisualStyles = false;
            this.TodayCallsDGV.Location = new System.Drawing.Point(3, 53);
            this.TodayCallsDGV.MultiSelect = false;
            this.TodayCallsDGV.Name = "TodayCallsDGV";
            this.TodayCallsDGV.ReadOnly = true;
            this.TodayCallsDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TodayCallsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.TodayCallsDGV.RowHeadersVisible = false;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.TodayCallsDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.TodayCallsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TodayCallsDGV.Size = new System.Drawing.Size(218, 158);
            this.TodayCallsDGV.TabIndex = 7;
            this.TodayCallsDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CallsDGV_CellContentDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ProjectsManager.Properties.Resources.background_img;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ItemsDGV, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ToolBar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(713, 520);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ItemsDGV
            // 
            this.ItemsDGV.AllowUserToAddRows = false;
            this.ItemsDGV.AllowUserToDeleteRows = false;
            this.ItemsDGV.AllowUserToOrderColumns = true;
            this.ItemsDGV.AllowUserToResizeRows = false;
            this.ItemsDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ItemsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ItemsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.ItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDGV.DefaultCellStyle = dataGridViewCellStyle14;
            this.ItemsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsDGV.EnableHeadersVisualStyles = false;
            this.ItemsDGV.Location = new System.Drawing.Point(3, 133);
            this.ItemsDGV.MultiSelect = false;
            this.ItemsDGV.Name = "ItemsDGV";
            this.ItemsDGV.ReadOnly = true;
            this.ItemsDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.ItemsDGV.RowHeadersVisible = false;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.ItemsDGV.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.ItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDGV.Size = new System.Drawing.Size(707, 384);
            this.ItemsDGV.TabIndex = 2;
            this.ItemsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDGV_CellDoubleClick);
            this.ItemsDGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemsDGV_CellMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(652, 55);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(58, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.White;
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RestoreButton,
            this.toolStripLabel1,
            this.FastSearchTextBox,
            this.RefreshButton,
            this.AdvancedSearchButton,
            this.EnterServiceReportButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolBar.Size = new System.Drawing.Size(713, 39);
            this.ToolBar.TabIndex = 8;
            this.ToolBar.Text = "toolStrip1";
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Image = global::ProjectsManager.Properties.Resources.add_img;
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.NewButton.Name = "NewButton";
            this.NewButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.NewButton.Size = new System.Drawing.Size(46, 36);
            this.NewButton.Text = "جديد";
            this.NewButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = global::ProjectsManager.Properties.Resources.edit;
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.EditButton.Size = new System.Drawing.Size(46, 36);
            this.EditButton.Text = "تعديل";
            this.EditButton.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = global::ProjectsManager.Properties.Resources.garbage_img;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DeleteButton.Size = new System.Drawing.Size(46, 36);
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RestoreButton
            // 
            this.RestoreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RestoreButton.Image = global::ProjectsManager.Properties.Resources.broken_link;
            this.RestoreButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(36, 36);
            this.RestoreButton.Text = "استعادة من الحذف";
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::ProjectsManager.Properties.Resources.search1;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 36);
            this.toolStripLabel1.Text = "بحث";
            // 
            // FastSearchTextBox
            // 
            this.FastSearchTextBox.AutoSize = false;
            this.FastSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FastSearchTextBox.MaxLength = 50;
            this.FastSearchTextBox.Name = "FastSearchTextBox";
            this.FastSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FastSearchTextBox.Size = new System.Drawing.Size(150, 23);
            this.FastSearchTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FastSearchTextBox.Enter += new System.EventHandler(this.FastSearchTextBox_Enter);
            this.FastSearchTextBox.TextChanged += new System.EventHandler(this.FastSearchTextBox_TextChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Image = global::ProjectsManager.Properties.Resources.repeat;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.RefreshButton.Size = new System.Drawing.Size(46, 36);
            this.RefreshButton.Text = "تحديث";
            this.RefreshButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // AdvancedSearchButton
            // 
            this.AdvancedSearchButton.Font = new System.Drawing.Font("Tahoma", 7F);
            this.AdvancedSearchButton.Image = global::ProjectsManager.Properties.Resources.binoculars;
            this.AdvancedSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdvancedSearchButton.Name = "AdvancedSearchButton";
            this.AdvancedSearchButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.AdvancedSearchButton.Size = new System.Drawing.Size(98, 36);
            this.AdvancedSearchButton.Text = "بحث متقدم";
            this.AdvancedSearchButton.Click += new System.EventHandler(this.AdvancedSearchButton_Click);
            // 
            // EnterServiceReportButton
            // 
            this.EnterServiceReportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EnterServiceReportButton.Image = global::ProjectsManager.Properties.Resources.notepad;
            this.EnterServiceReportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EnterServiceReportButton.Name = "EnterServiceReportButton";
            this.EnterServiceReportButton.Size = new System.Drawing.Size(36, 36);
            this.EnterServiceReportButton.Text = "ادخال تقرير صيانة";
            this.EnterServiceReportButton.Click += new System.EventHandler(this.EnterServiceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 604);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدير المشاريع";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveAppointmentsDGV)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemindersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodayCallsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDGV)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بطاقاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الزبائنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المتعهدينToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox FastSearchTextBox;
        private System.Windows.Forms.DataGridView ItemsDGV;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel DatabaseLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem التذكيراتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تذكيرجديدToolStripMenuItem;
        private System.Windows.Forms.Timer ReminderTimer;
        private System.Windows.Forms.Timer BackupTimer;
        private AnalogClock.Clock clock1;
        private System.Windows.Forms.ToolStripButton AdvancedSearchButton;
        private System.Windows.Forms.ToolStripStatusLabel RowsCountLabel;
        private System.Windows.Forms.ToolStripMenuItem التذكيراتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer ClearStatusTimer;
        private System.Windows.Forms.ToolStripMenuItem مساعدةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عنالبرنامجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تفعيلالنسخةToolStripMenuItem;
        private System.Windows.Forms.Timer TrialTimer;
        private System.Windows.Forms.ToolStripStatusLabel LoggedUserLabel;
        private TablessControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView RemindersDGV;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TodayDateLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem VehicleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppSettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageUsersMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem BackupMenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إنشاءنسخةاحتياطيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestoreDBMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDBMenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techniciansMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InstituteProfessionsMenuItem;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اختيارالحقولToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton RestoreButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton EnterServiceReportButton;
        private System.Windows.Forms.ToolStripMenuItem أنواعوحداتالمعالجةToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView ActiveAppointmentsDGV;
        private System.Windows.Forms.DataGridView TodayCallsDGV;
        private System.Windows.Forms.ToolStripMenuItem ApplicationWizardMenuItem;

    }
}