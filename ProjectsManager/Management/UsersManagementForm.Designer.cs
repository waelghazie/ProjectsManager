namespace ProjectsManager
{
    partial class UsersManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PermissionReadCheckBox = new System.Windows.Forms.CheckBox();
            this.PermissionModifyCheckBox = new System.Windows.Forms.CheckBox();
            this.PermissionCreateCheckBox = new System.Windows.Forms.CheckBox();
            this.PermissionDeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.PermissionManageCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ModifyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.DispalyNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserDisplayNameLabel = new System.Windows.Forms.Label();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.PasswrodConfirmLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SaveDomainInfoButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ConnectToADbutton = new System.Windows.Forms.Button();
            this.DomainPasswordLabel = new System.Windows.Forms.Label();
            this.DomainUserNamelabel = new System.Windows.Forms.Label();
            this.DomainSufficLabel = new System.Windows.Forms.Label();
            this.DomainUsernameTextBox = new System.Windows.Forms.TextBox();
            this.DomainSuffixTextBox = new System.Windows.Forms.TextBox();
            this.DomainLabel = new System.Windows.Forms.Label();
            this.OULabel = new System.Windows.Forms.Label();
            this.DomainControllerLabel = new System.Windows.Forms.Label();
            this.DomainTextBox = new System.Windows.Forms.TextBox();
            this.OUTextBox = new System.Windows.Forms.TextBox();
            this.DomainControllerTextBox = new System.Windows.Forms.TextBox();
            this.DomainPasswordTextBox = new ProjectsManager.ProtectedTextBox();
            this.ActiveDirectoryConnectBGW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // PermissionReadCheckBox
            // 
            this.PermissionReadCheckBox.AutoSize = true;
            this.PermissionReadCheckBox.Enabled = false;
            this.PermissionReadCheckBox.Location = new System.Drawing.Point(508, 38);
            this.PermissionReadCheckBox.Name = "PermissionReadCheckBox";
            this.PermissionReadCheckBox.Size = new System.Drawing.Size(48, 17);
            this.PermissionReadCheckBox.TabIndex = 1;
            this.PermissionReadCheckBox.Text = "قراءة";
            this.PermissionReadCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermissionModifyCheckBox
            // 
            this.PermissionModifyCheckBox.AutoSize = true;
            this.PermissionModifyCheckBox.Enabled = false;
            this.PermissionModifyCheckBox.Location = new System.Drawing.Point(504, 61);
            this.PermissionModifyCheckBox.Name = "PermissionModifyCheckBox";
            this.PermissionModifyCheckBox.Size = new System.Drawing.Size(52, 17);
            this.PermissionModifyCheckBox.TabIndex = 2;
            this.PermissionModifyCheckBox.Text = "تعديل";
            this.PermissionModifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermissionCreateCheckBox
            // 
            this.PermissionCreateCheckBox.AutoSize = true;
            this.PermissionCreateCheckBox.Enabled = false;
            this.PermissionCreateCheckBox.Location = new System.Drawing.Point(505, 85);
            this.PermissionCreateCheckBox.Name = "PermissionCreateCheckBox";
            this.PermissionCreateCheckBox.Size = new System.Drawing.Size(51, 17);
            this.PermissionCreateCheckBox.TabIndex = 3;
            this.PermissionCreateCheckBox.Text = "إنشاء";
            this.PermissionCreateCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermissionDeleteCheckBox
            // 
            this.PermissionDeleteCheckBox.AutoSize = true;
            this.PermissionDeleteCheckBox.Enabled = false;
            this.PermissionDeleteCheckBox.Location = new System.Drawing.Point(504, 109);
            this.PermissionDeleteCheckBox.Name = "PermissionDeleteCheckBox";
            this.PermissionDeleteCheckBox.Size = new System.Drawing.Size(52, 17);
            this.PermissionDeleteCheckBox.TabIndex = 4;
            this.PermissionDeleteCheckBox.Text = "مسح";
            this.PermissionDeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermissionManageCheckBox
            // 
            this.PermissionManageCheckBox.AutoSize = true;
            this.PermissionManageCheckBox.Enabled = false;
            this.PermissionManageCheckBox.Location = new System.Drawing.Point(447, 132);
            this.PermissionManageCheckBox.Name = "PermissionManageCheckBox";
            this.PermissionManageCheckBox.Size = new System.Drawing.Size(109, 17);
            this.PermissionManageCheckBox.TabIndex = 5;
            this.PermissionManageCheckBox.Text = "إدارة المستخدمين";
            this.PermissionManageCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "الصلاحيات :";
            // 
            // NewUserButton
            // 
            this.NewUserButton.Location = new System.Drawing.Point(89, 220);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(75, 23);
            this.NewUserButton.TabIndex = 7;
            this.NewUserButton.Text = "جديد";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(8, 220);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteUserButton.TabIndex = 8;
            this.DeleteUserButton.Text = "حذف";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(488, 452);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "اغلاق";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ModifyLinkLabel
            // 
            this.ModifyLinkLabel.AutoSize = true;
            this.ModifyLinkLabel.Location = new System.Drawing.Point(526, 163);
            this.ModifyLinkLabel.Name = "ModifyLinkLabel";
            this.ModifyLinkLabel.Size = new System.Drawing.Size(33, 13);
            this.ModifyLinkLabel.TabIndex = 10;
            this.ModifyLinkLabel.TabStop = true;
            this.ModifyLinkLabel.Text = "تعديل";
            this.ModifyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ModifyUser_LinkClicked);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(161, 153);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.SaveChangesButton.TabIndex = 11;
            this.SaveChangesButton.Text = "حفظ";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Visible = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.Location = new System.Drawing.Point(80, 153);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(75, 23);
            this.CancelChangesButton.TabIndex = 12;
            this.CancelChangesButton.Text = "الغاء";
            this.CancelChangesButton.UseVisualStyleBackColor = true;
            this.CancelChangesButton.Visible = false;
            this.CancelChangesButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DispalyNameTextBox
            // 
            this.DispalyNameTextBox.Location = new System.Drawing.Point(80, 38);
            this.DispalyNameTextBox.Name = "DispalyNameTextBox";
            this.DispalyNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DispalyNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.DispalyNameTextBox.TabIndex = 6;
            this.DispalyNameTextBox.Visible = false;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(80, 65);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.UserNameTextBox.TabIndex = 7;
            this.UserNameTextBox.Visible = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(229, 68);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(88, 13);
            this.UserNameLabel.TabIndex = 16;
            this.UserNameLabel.Text = "اسم المستخدم :";
            this.UserNameLabel.Visible = false;
            // 
            // UserDisplayNameLabel
            // 
            this.UserDisplayNameLabel.AutoSize = true;
            this.UserDisplayNameLabel.Location = new System.Drawing.Point(229, 41);
            this.UserDisplayNameLabel.Name = "UserDisplayNameLabel";
            this.UserDisplayNameLabel.Size = new System.Drawing.Size(72, 13);
            this.UserDisplayNameLabel.TabIndex = 17;
            this.UserDisplayNameLabel.Text = "الاسم الكامل:";
            this.UserDisplayNameLabel.Visible = false;
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(229, 95);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(62, 13);
            this.UserPasswordLabel.TabIndex = 18;
            this.UserPasswordLabel.Text = "كلمة السر :";
            this.UserPasswordLabel.Visible = false;
            // 
            // PasswrodConfirmLabel
            // 
            this.PasswrodConfirmLabel.AutoSize = true;
            this.PasswrodConfirmLabel.Location = new System.Drawing.Point(229, 122);
            this.PasswrodConfirmLabel.Name = "PasswrodConfirmLabel";
            this.PasswrodConfirmLabel.Size = new System.Drawing.Size(86, 13);
            this.PasswrodConfirmLabel.TabIndex = 19;
            this.PasswrodConfirmLabel.Text = "تأكيد كلمة السر :";
            this.PasswrodConfirmLabel.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 175);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 275);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ConfirmPasswordTextBox);
            this.tabPage1.Controls.Add(this.PasswordTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PermissionReadCheckBox);
            this.tabPage1.Controls.Add(this.PasswrodConfirmLabel);
            this.tabPage1.Controls.Add(this.PermissionModifyCheckBox);
            this.tabPage1.Controls.Add(this.UserPasswordLabel);
            this.tabPage1.Controls.Add(this.PermissionCreateCheckBox);
            this.tabPage1.Controls.Add(this.UserDisplayNameLabel);
            this.tabPage1.Controls.Add(this.PermissionDeleteCheckBox);
            this.tabPage1.Controls.Add(this.UserNameLabel);
            this.tabPage1.Controls.Add(this.PermissionManageCheckBox);
            this.tabPage1.Controls.Add(this.NewUserButton);
            this.tabPage1.Controls.Add(this.UserNameTextBox);
            this.tabPage1.Controls.Add(this.DeleteUserButton);
            this.tabPage1.Controls.Add(this.DispalyNameTextBox);
            this.tabPage1.Controls.Add(this.ModifyLinkLabel);
            this.tabPage1.Controls.Add(this.CancelChangesButton);
            this.tabPage1.Controls.Add(this.SaveChangesButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Application";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(81, 117);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(142, 20);
            this.ConfirmPasswordTextBox.TabIndex = 21;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            this.ConfirmPasswordTextBox.Visible = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(81, 91);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBox.Size = new System.Drawing.Size(142, 20);
            this.PasswordTextBox.TabIndex = 20;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.SaveDomainInfoButton);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.ConnectToADbutton);
            this.tabPage2.Controls.Add(this.DomainPasswordLabel);
            this.tabPage2.Controls.Add(this.DomainUserNamelabel);
            this.tabPage2.Controls.Add(this.DomainSufficLabel);
            this.tabPage2.Controls.Add(this.DomainUsernameTextBox);
            this.tabPage2.Controls.Add(this.DomainSuffixTextBox);
            this.tabPage2.Controls.Add(this.DomainLabel);
            this.tabPage2.Controls.Add(this.OULabel);
            this.tabPage2.Controls.Add(this.DomainControllerLabel);
            this.tabPage2.Controls.Add(this.DomainTextBox);
            this.tabPage2.Controls.Add(this.OUTextBox);
            this.tabPage2.Controls.Add(this.DomainControllerTextBox);
            this.tabPage2.Controls.Add(this.DomainPasswordTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Active Directory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(462, 215);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(97, 17);
            this.progressBar1.TabIndex = 17;
            // 
            // SaveDomainInfoButton
            // 
            this.SaveDomainInfoButton.Location = new System.Drawing.Point(484, 88);
            this.SaveDomainInfoButton.Name = "SaveDomainInfoButton";
            this.SaveDomainInfoButton.Size = new System.Drawing.Size(75, 23);
            this.SaveDomainInfoButton.TabIndex = 16;
            this.SaveDomainInfoButton.Text = "Save";
            this.SaveDomainInfoButton.UseVisualStyleBackColor = true;
            this.SaveDomainInfoButton.Click += new System.EventHandler(this.SaveDomainInfo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 18);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(187, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Active Directory Connection Settings:";
            // 
            // ConnectToADbutton
            // 
            this.ConnectToADbutton.Location = new System.Drawing.Point(484, 58);
            this.ConnectToADbutton.Name = "ConnectToADbutton";
            this.ConnectToADbutton.Size = new System.Drawing.Size(75, 24);
            this.ConnectToADbutton.TabIndex = 12;
            this.ConnectToADbutton.Text = "Connect";
            this.ConnectToADbutton.UseVisualStyleBackColor = true;
            this.ConnectToADbutton.Click += new System.EventHandler(this.ConnectToADButton_Click);
            // 
            // DomainPasswordLabel
            // 
            this.DomainPasswordLabel.AutoSize = true;
            this.DomainPasswordLabel.Location = new System.Drawing.Point(9, 191);
            this.DomainPasswordLabel.Name = "DomainPasswordLabel";
            this.DomainPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainPasswordLabel.Size = new System.Drawing.Size(57, 13);
            this.DomainPasswordLabel.TabIndex = 11;
            this.DomainPasswordLabel.Text = "Password:";
            // 
            // DomainUserNamelabel
            // 
            this.DomainUserNamelabel.AutoSize = true;
            this.DomainUserNamelabel.Location = new System.Drawing.Point(9, 165);
            this.DomainUserNamelabel.Name = "DomainUserNamelabel";
            this.DomainUserNamelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainUserNamelabel.Size = new System.Drawing.Size(55, 13);
            this.DomainUserNamelabel.TabIndex = 10;
            this.DomainUserNamelabel.Text = "Username";
            // 
            // DomainSufficLabel
            // 
            this.DomainSufficLabel.AutoSize = true;
            this.DomainSufficLabel.Location = new System.Drawing.Point(9, 139);
            this.DomainSufficLabel.Name = "DomainSufficLabel";
            this.DomainSufficLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainSufficLabel.Size = new System.Drawing.Size(77, 13);
            this.DomainSufficLabel.TabIndex = 9;
            this.DomainSufficLabel.Text = "Domain Suffix:";
            // 
            // DomainUsernameTextBox
            // 
            this.DomainUsernameTextBox.Location = new System.Drawing.Point(111, 162);
            this.DomainUsernameTextBox.Name = "DomainUsernameTextBox";
            this.DomainUsernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainUsernameTextBox.Size = new System.Drawing.Size(194, 20);
            this.DomainUsernameTextBox.TabIndex = 14;
            // 
            // DomainSuffixTextBox
            // 
            this.DomainSuffixTextBox.Location = new System.Drawing.Point(111, 136);
            this.DomainSuffixTextBox.Name = "DomainSuffixTextBox";
            this.DomainSuffixTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainSuffixTextBox.Size = new System.Drawing.Size(194, 20);
            this.DomainSuffixTextBox.TabIndex = 13;
            // 
            // DomainLabel
            // 
            this.DomainLabel.AutoSize = true;
            this.DomainLabel.Location = new System.Drawing.Point(9, 113);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainLabel.Size = new System.Drawing.Size(46, 13);
            this.DomainLabel.TabIndex = 5;
            this.DomainLabel.Text = "Domain:";
            // 
            // OULabel
            // 
            this.OULabel.AutoSize = true;
            this.OULabel.Location = new System.Drawing.Point(9, 87);
            this.OULabel.Name = "OULabel";
            this.OULabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OULabel.Size = new System.Drawing.Size(26, 13);
            this.OULabel.TabIndex = 4;
            this.OULabel.Text = "OU:";
            // 
            // DomainControllerLabel
            // 
            this.DomainControllerLabel.AutoSize = true;
            this.DomainControllerLabel.Location = new System.Drawing.Point(9, 61);
            this.DomainControllerLabel.Name = "DomainControllerLabel";
            this.DomainControllerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainControllerLabel.Size = new System.Drawing.Size(96, 13);
            this.DomainControllerLabel.TabIndex = 3;
            this.DomainControllerLabel.Text = "Domain Controller:";
            // 
            // DomainTextBox
            // 
            this.DomainTextBox.Location = new System.Drawing.Point(111, 110);
            this.DomainTextBox.Name = "DomainTextBox";
            this.DomainTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainTextBox.Size = new System.Drawing.Size(194, 20);
            this.DomainTextBox.TabIndex = 12;
            // 
            // OUTextBox
            // 
            this.OUTextBox.Location = new System.Drawing.Point(111, 84);
            this.OUTextBox.Name = "OUTextBox";
            this.OUTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OUTextBox.Size = new System.Drawing.Size(194, 20);
            this.OUTextBox.TabIndex = 11;
            // 
            // DomainControllerTextBox
            // 
            this.DomainControllerTextBox.Location = new System.Drawing.Point(111, 58);
            this.DomainControllerTextBox.Name = "DomainControllerTextBox";
            this.DomainControllerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainControllerTextBox.Size = new System.Drawing.Size(194, 20);
            this.DomainControllerTextBox.TabIndex = 10;
            // 
            // DomainPasswordTextBox
            // 
            this.DomainPasswordTextBox.Location = new System.Drawing.Point(111, 188);
            this.DomainPasswordTextBox.Name = "DomainPasswordTextBox";
            this.DomainPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DomainPasswordTextBox.Size = new System.Drawing.Size(194, 20);
            this.DomainPasswordTextBox.TabIndex = 15;
            this.DomainPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ActiveDirectoryConnectBGW
            // 
            this.ActiveDirectoryConnectBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ActiveDirectoryConnect_DoWork);
            this.ActiveDirectoryConnectBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ActiveDirectoryConnect_RunWorkerCompleted);
            // 
            // UsersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 480);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersManagementForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ادارة المستخدمين";
            this.Load += new System.EventHandler(this.UsersManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox PermissionReadCheckBox;
        private System.Windows.Forms.CheckBox PermissionModifyCheckBox;
        private System.Windows.Forms.CheckBox PermissionCreateCheckBox;
        private System.Windows.Forms.CheckBox PermissionDeleteCheckBox;
        private System.Windows.Forms.CheckBox PermissionManageCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.LinkLabel ModifyLinkLabel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.TextBox DispalyNameTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserDisplayNameLabel;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.Label PasswrodConfirmLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label OULabel;
        private System.Windows.Forms.Label DomainControllerLabel;
        private System.Windows.Forms.TextBox DomainTextBox;
        private System.Windows.Forms.TextBox OUTextBox;
        private System.Windows.Forms.TextBox DomainControllerTextBox;
        private System.Windows.Forms.Label DomainLabel;
        private System.Windows.Forms.Label DomainPasswordLabel;
        private System.Windows.Forms.Label DomainUserNamelabel;
        private System.Windows.Forms.Label DomainSufficLabel;
        private System.Windows.Forms.TextBox DomainUsernameTextBox;
        private System.Windows.Forms.TextBox DomainSuffixTextBox;
        private System.Windows.Forms.Button ConnectToADbutton;
        private System.Windows.Forms.Label label12;
        private ProtectedTextBox DomainPasswordTextBox;
        private System.ComponentModel.BackgroundWorker ActiveDirectoryConnectBGW;
        private System.Windows.Forms.Button SaveDomainInfoButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}