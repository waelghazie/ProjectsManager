namespace ProjectsManager
{
    partial class ApplicationSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TryConnectButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DatabaseComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PassTextBox = new ProjectsManager.ProtectedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeoutTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.SQLAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.WindowsAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.ServerComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeveloperOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetSettingsButton = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackupTimerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReminderTimerTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ApplicationRadioButton = new System.Windows.Forms.RadioButton();
            this.DomainAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ListServersBGW = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.DeveloperOptionsGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 30);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SaveButton.Location = new System.Drawing.Point(4, 378);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TryConnectButton
            // 
            this.TryConnectButton.Location = new System.Drawing.Point(20, 312);
            this.TryConnectButton.Name = "TryConnectButton";
            this.TryConnectButton.Size = new System.Drawing.Size(75, 23);
            this.TryConnectButton.TabIndex = 3;
            this.TryConnectButton.Text = "Try Connect";
            this.TryConnectButton.UseVisualStyleBackColor = true;
            this.TryConnectButton.Click += new System.EventHandler(this.TryButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 372);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.TryConnectButton);
            this.tabPage1.Controls.Add(this.ServerComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(362, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Database";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DatabaseComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(20, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(323, 56);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect To Database";
            // 
            // DatabaseComboBox
            // 
            this.DatabaseComboBox.FormattingEnabled = true;
            this.DatabaseComboBox.Location = new System.Drawing.Point(107, 27);
            this.DatabaseComboBox.Name = "DatabaseComboBox";
            this.DatabaseComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatabaseComboBox.Size = new System.Drawing.Size(180, 21);
            this.DatabaseComboBox.TabIndex = 5;
            this.DatabaseComboBox.DropDown += new System.EventHandler(this.DatabaseComboBox_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PassTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TimeoutTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UserNameTextBox);
            this.groupBox1.Controls.Add(this.SQLAuthRadioButton);
            this.groupBox1.Controls.Add(this.WindowsAuthRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(20, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(323, 192);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Authentication:";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(107, 97);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '#';
            this.PassTextBox.Size = new System.Drawing.Size(180, 20);
            this.PassTextBox.TabIndex = 3;
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Time-Out";
            // 
            // TimeoutTextBox
            // 
            this.TimeoutTextBox.Location = new System.Drawing.Point(107, 146);
            this.TimeoutTextBox.Name = "TimeoutTextBox";
            this.TimeoutTextBox.Size = new System.Drawing.Size(54, 20);
            this.TimeoutTextBox.TabIndex = 4;
            this.TimeoutTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeoutTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "User Name";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(107, 66);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.UserNameTextBox.TabIndex = 2;
            // 
            // SQLAuthRadioButton
            // 
            this.SQLAuthRadioButton.AutoSize = true;
            this.SQLAuthRadioButton.Checked = true;
            this.SQLAuthRadioButton.Location = new System.Drawing.Point(32, 43);
            this.SQLAuthRadioButton.Name = "SQLAuthRadioButton";
            this.SQLAuthRadioButton.Size = new System.Drawing.Size(173, 17);
            this.SQLAuthRadioButton.TabIndex = 1;
            this.SQLAuthRadioButton.TabStop = true;
            this.SQLAuthRadioButton.Text = "Use SQL Server Authentication";
            this.SQLAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // WindowsAuthRadioButton
            // 
            this.WindowsAuthRadioButton.AutoSize = true;
            this.WindowsAuthRadioButton.Enabled = false;
            this.WindowsAuthRadioButton.Location = new System.Drawing.Point(32, 19);
            this.WindowsAuthRadioButton.Name = "WindowsAuthRadioButton";
            this.WindowsAuthRadioButton.Size = new System.Drawing.Size(162, 17);
            this.WindowsAuthRadioButton.TabIndex = 0;
            this.WindowsAuthRadioButton.TabStop = true;
            this.WindowsAuthRadioButton.Text = "Use Windows Authentication";
            this.WindowsAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // ServerComboBox
            // 
            this.ServerComboBox.FormattingEnabled = true;
            this.ServerComboBox.Location = new System.Drawing.Point(127, 25);
            this.ServerComboBox.Name = "ServerComboBox";
            this.ServerComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServerComboBox.Size = new System.Drawing.Size(180, 21);
            this.ServerComboBox.TabIndex = 1;
            this.ServerComboBox.DropDown += new System.EventHandler(this.ServerComboBox_DropDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeveloperOptionsGroupBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.ApplicationRadioButton);
            this.tabPage2.Controls.Add(this.DomainAuthRadioButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(362, 346);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeveloperOptionsGroupBox
            // 
            this.DeveloperOptionsGroupBox.Controls.Add(this.ResetSettingsButton);
            this.DeveloperOptionsGroupBox.Controls.Add(this.checkBox3);
            this.DeveloperOptionsGroupBox.Controls.Add(this.checkBox2);
            this.DeveloperOptionsGroupBox.Controls.Add(this.label9);
            this.DeveloperOptionsGroupBox.Controls.Add(this.label10);
            this.DeveloperOptionsGroupBox.Controls.Add(this.label3);
            this.DeveloperOptionsGroupBox.Controls.Add(this.BackupTimerTextBox);
            this.DeveloperOptionsGroupBox.Controls.Add(this.label4);
            this.DeveloperOptionsGroupBox.Controls.Add(this.ReminderTimerTextBox);
            this.DeveloperOptionsGroupBox.Location = new System.Drawing.Point(8, 127);
            this.DeveloperOptionsGroupBox.Name = "DeveloperOptionsGroupBox";
            this.DeveloperOptionsGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeveloperOptionsGroupBox.Size = new System.Drawing.Size(283, 213);
            this.DeveloperOptionsGroupBox.TabIndex = 38;
            this.DeveloperOptionsGroupBox.TabStop = false;
            this.DeveloperOptionsGroupBox.Text = "Dev";
            // 
            // ResetSettingsButton
            // 
            this.ResetSettingsButton.Location = new System.Drawing.Point(10, 184);
            this.ResetSettingsButton.Name = "ResetSettingsButton";
            this.ResetSettingsButton.Size = new System.Drawing.Size(87, 23);
            this.ResetSettingsButton.TabIndex = 39;
            this.ResetSettingsButton.Text = "Reset Settings";
            this.ResetSettingsButton.UseVisualStyleBackColor = true;
            this.ResetSettingsButton.Click += new System.EventHandler(this.ResetSettingsButton_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 106);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 17);
            this.checkBox3.TabIndex = 38;
            this.checkBox3.Text = "FirstRun";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(186, 17);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "AutoLogin and Hide SplashScreen";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Reminder Timer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Backup Timer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Sec";
            // 
            // BackupTimerTextBox
            // 
            this.BackupTimerTextBox.Location = new System.Drawing.Point(96, 13);
            this.BackupTimerTextBox.Name = "BackupTimerTextBox";
            this.BackupTimerTextBox.Size = new System.Drawing.Size(100, 20);
            this.BackupTimerTextBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sec";
            // 
            // ReminderTimerTextBox
            // 
            this.ReminderTimerTextBox.Location = new System.Drawing.Point(96, 39);
            this.ReminderTimerTextBox.Name = "ReminderTimerTextBox";
            this.ReminderTimerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReminderTimerTextBox.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 39);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(124, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Developer Options Label";
            this.label11.DoubleClick += new System.EventHandler(this.DeveloperOptionsLabel_DoubleClick);
            // 
            // ApplicationRadioButton
            // 
            this.ApplicationRadioButton.AutoSize = true;
            this.ApplicationRadioButton.Location = new System.Drawing.Point(73, 91);
            this.ApplicationRadioButton.Name = "ApplicationRadioButton";
            this.ApplicationRadioButton.Size = new System.Drawing.Size(281, 17);
            this.ApplicationRadioButton.TabIndex = 2;
            this.ApplicationRadioButton.Text = "اسم مستخدم وكلمة مرور (Application Authentication)";
            this.ApplicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // DomainAuthRadioButton
            // 
            this.DomainAuthRadioButton.AutoSize = true;
            this.DomainAuthRadioButton.Checked = true;
            this.DomainAuthRadioButton.Location = new System.Drawing.Point(98, 68);
            this.DomainAuthRadioButton.Name = "DomainAuthRadioButton";
            this.DomainAuthRadioButton.Size = new System.Drawing.Size(256, 17);
            this.DomainAuthRadioButton.TabIndex = 1;
            this.DomainAuthRadioButton.TabStop = true;
            this.DomainAuthRadioButton.Text = "حساب ويندوز من مجال (Windows Authentication)";
            this.DomainAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "نمط تسجيل الدخول للبرنامج :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(370, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel1.Text = "جاهز";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(283, 378);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ListServersBGW
            // 
            this.ListServersBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ListServersBGW_DoWork);
            this.ListServersBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ListServersBGW_RunWorkerCompleted);
            // 
            // ApplicationSettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(370, 426);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationSettingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعدادات البرنامج";
            this.Load += new System.EventHandler(this.ApplicationSettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.DeveloperOptionsGroupBox.ResumeLayout(false);
            this.DeveloperOptionsGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button TryConnectButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox DatabaseComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.RadioButton SQLAuthRadioButton;
        private System.Windows.Forms.RadioButton WindowsAuthRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TimeoutTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton ApplicationRadioButton;
        private System.Windows.Forms.RadioButton DomainAuthRadioButton;
        private System.Windows.Forms.Label label8;
        private ProtectedTextBox PassTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.ComponentModel.BackgroundWorker ListServersBGW;
        public System.Windows.Forms.ComboBox ServerComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReminderTimerTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BackupTimerTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox DeveloperOptionsGroupBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button ResetSettingsButton;

    }
}