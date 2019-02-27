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
            this.ReadCheckBox = new System.Windows.Forms.CheckBox();
            this.ModifyCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateCheckBox = new System.Windows.Forms.CheckBox();
            this.DeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.ManageCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ModifyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.DispalyNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SaveDomainInfoButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ConnectToADbutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DomainUsernameTextBox = new System.Windows.Forms.TextBox();
            this.DomainSuffixTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DomainTextBox = new System.Windows.Forms.TextBox();
            this.OUTextBox = new System.Windows.Forms.TextBox();
            this.DomainControllerTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DomainPasswordTextBox = new ProjectsManager.ProtectedTextBox();
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
            // ReadCheckBox
            // 
            this.ReadCheckBox.AutoSize = true;
            this.ReadCheckBox.Enabled = false;
            this.ReadCheckBox.Location = new System.Drawing.Point(508, 38);
            this.ReadCheckBox.Name = "ReadCheckBox";
            this.ReadCheckBox.Size = new System.Drawing.Size(48, 17);
            this.ReadCheckBox.TabIndex = 1;
            this.ReadCheckBox.Text = "قراءة";
            this.ReadCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModifyCheckBox
            // 
            this.ModifyCheckBox.AutoSize = true;
            this.ModifyCheckBox.Enabled = false;
            this.ModifyCheckBox.Location = new System.Drawing.Point(504, 61);
            this.ModifyCheckBox.Name = "ModifyCheckBox";
            this.ModifyCheckBox.Size = new System.Drawing.Size(52, 17);
            this.ModifyCheckBox.TabIndex = 2;
            this.ModifyCheckBox.Text = "تعديل";
            this.ModifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateCheckBox
            // 
            this.CreateCheckBox.AutoSize = true;
            this.CreateCheckBox.Enabled = false;
            this.CreateCheckBox.Location = new System.Drawing.Point(505, 85);
            this.CreateCheckBox.Name = "CreateCheckBox";
            this.CreateCheckBox.Size = new System.Drawing.Size(51, 17);
            this.CreateCheckBox.TabIndex = 3;
            this.CreateCheckBox.Text = "إنشاء";
            this.CreateCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeleteCheckBox
            // 
            this.DeleteCheckBox.AutoSize = true;
            this.DeleteCheckBox.Enabled = false;
            this.DeleteCheckBox.Location = new System.Drawing.Point(504, 109);
            this.DeleteCheckBox.Name = "DeleteCheckBox";
            this.DeleteCheckBox.Size = new System.Drawing.Size(52, 17);
            this.DeleteCheckBox.TabIndex = 4;
            this.DeleteCheckBox.Text = "مسح";
            this.DeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManageCheckBox
            // 
            this.ManageCheckBox.AutoSize = true;
            this.ManageCheckBox.Enabled = false;
            this.ManageCheckBox.Location = new System.Drawing.Point(447, 132);
            this.ManageCheckBox.Name = "ManageCheckBox";
            this.ManageCheckBox.Size = new System.Drawing.Size(109, 17);
            this.ManageCheckBox.TabIndex = 5;
            this.ManageCheckBox.Text = "إدارة المستخدمين";
            this.ManageCheckBox.UseVisualStyleBackColor = true;
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
            this.NewUserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(8, 220);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteUserButton.TabIndex = 8;
            this.DeleteUserButton.Text = "حذف";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(488, 452);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "اغلاق";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button3_Click);
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
            this.ModifyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.SaveChangesButton.Click += new System.EventHandler(this.button4_Click);
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
            this.CancelChangesButton.Click += new System.EventHandler(this.button5_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "اسم المستخدم :";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "الاسم الكامل:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "كلمة السر :";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "تأكيد كلمة السر :";
            this.label5.Visible = false;
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
            this.tabPage1.Controls.Add(this.ReadCheckBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ModifyCheckBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CreateCheckBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.DeleteCheckBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ManageCheckBox);
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
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.DomainUsernameTextBox);
            this.tabPage2.Controls.Add(this.DomainSuffixTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
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
            this.progressBar1.Location = new System.Drawing.Point(8, 221);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(97, 17);
            this.progressBar1.TabIndex = 17;
            // 
            // SaveDomainInfoButton
            // 
            this.SaveDomainInfoButton.Location = new System.Drawing.Point(360, 215);
            this.SaveDomainInfoButton.Name = "SaveDomainInfoButton";
            this.SaveDomainInfoButton.Size = new System.Drawing.Size(75, 23);
            this.SaveDomainInfoButton.TabIndex = 16;
            this.SaveDomainInfoButton.Text = "Save";
            this.SaveDomainInfoButton.UseVisualStyleBackColor = true;
            this.SaveDomainInfoButton.Click += new System.EventHandler(this.SaveADinfo_Click);
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
            this.ConnectToADbutton.Location = new System.Drawing.Point(144, 214);
            this.ConnectToADbutton.Name = "ConnectToADbutton";
            this.ConnectToADbutton.Size = new System.Drawing.Size(161, 24);
            this.ConnectToADbutton.TabIndex = 12;
            this.ConnectToADbutton.Text = "Connect to Active Directory";
            this.ConnectToADbutton.UseVisualStyleBackColor = true;
            this.ConnectToADbutton.Click += new System.EventHandler(this.ConnectToADbutton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 191);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 165);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 139);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Domain Suffix:";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 113);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Domain:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 87);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "OU:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 61);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Domain Controller:";
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
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
            // UsersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 480);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersManagementForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ادارة المستخدمين";
            this.Load += new System.EventHandler(this.UsersManagement_Load);
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
        private System.Windows.Forms.CheckBox ReadCheckBox;
        private System.Windows.Forms.CheckBox ModifyCheckBox;
        private System.Windows.Forms.CheckBox CreateCheckBox;
        private System.Windows.Forms.CheckBox DeleteCheckBox;
        private System.Windows.Forms.CheckBox ManageCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.LinkLabel ModifyLinkLabel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.TextBox DispalyNameTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DomainTextBox;
        private System.Windows.Forms.TextBox OUTextBox;
        private System.Windows.Forms.TextBox DomainControllerTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DomainUsernameTextBox;
        private System.Windows.Forms.TextBox DomainSuffixTextBox;
        private System.Windows.Forms.Button ConnectToADbutton;
        private System.Windows.Forms.Label label12;
        private ProtectedTextBox DomainPasswordTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SaveDomainInfoButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}