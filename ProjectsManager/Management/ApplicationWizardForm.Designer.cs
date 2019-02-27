namespace ProjectsManager
{
    partial class ApplicationWizardForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateDatabaseBGW = new System.ComponentModel.BackgroundWorker();
            this.GetServersBGW = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.DontShowAgainCheckBox = new System.Windows.Forms.CheckBox();
            this.tablessControl = new ProjectsManager.TablessControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ConnectRadioButton = new System.Windows.Forms.RadioButton();
            this.CreateRadioButton = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SQLRadioButton = new System.Windows.Forms.RadioButton();
            this.SQLexprRadioButton = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.ServerCreateComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeOutTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PathCreateTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseCreateTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UsernameCreateTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PasswordCreateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.PasswordConnectTextBox = new ProjectsManager.ProtectedTextBox();
            this.ServerConnectComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DatabaseConnectComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.UsernameConnectTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.AppLoginRadioButton = new System.Windows.Forms.RadioButton();
            this.LoginAsADuserRadioButton = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.BackupPathButton = new System.Windows.Forms.Button();
            this.BackupPathTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tablessControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(518, 413);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "إغلاق";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateDatabaseBGW
            // 
            this.CreateDatabaseBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CreateDatabaseBGW_DoWork);
            this.CreateDatabaseBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CreateDatabaseBGW_RunWorkerCompleted);
            // 
            // GetServersBGW
            // 
            this.GetServersBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetServersBGW_DoWork);
            this.GetServersBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GetServersBGW_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectsManager.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(505, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(112, 424);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "التالي";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(197, 424);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 21;
            this.PreviousButton.Text = "السابق";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(505, 151);
            this.ProgressBar1.MarqueeAnimationSpeed = 30;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar1.TabIndex = 70;
            this.ProgressBar1.Visible = false;
            // 
            // DontShowAgainCheckBox
            // 
            this.DontShowAgainCheckBox.AutoSize = true;
            this.DontShowAgainCheckBox.Font = new System.Drawing.Font("Tahoma", 6F);
            this.DontShowAgainCheckBox.Location = new System.Drawing.Point(491, 442);
            this.DontShowAgainCheckBox.Name = "DontShowAgainCheckBox";
            this.DontShowAgainCheckBox.Size = new System.Drawing.Size(118, 14);
            this.DontShowAgainCheckBox.TabIndex = 71;
            this.DontShowAgainCheckBox.Text = "عدم اظهار هذه النافذة مجددا";
            this.DontShowAgainCheckBox.UseVisualStyleBackColor = true;
            // 
            // tablessControl
            // 
            this.tablessControl.Controls.Add(this.tabPage1);
            this.tablessControl.Controls.Add(this.tabPage5);
            this.tablessControl.Controls.Add(this.tabPage2);
            this.tablessControl.Controls.Add(this.tabPage3);
            this.tablessControl.Controls.Add(this.tabPage8);
            this.tablessControl.Controls.Add(this.tabPage6);
            this.tablessControl.Controls.Add(this.tabPage7);
            this.tablessControl.Controls.Add(this.tabPage4);
            this.tablessControl.Location = new System.Drawing.Point(0, 0);
            this.tablessControl.Name = "tablessControl";
            this.tablessControl.SelectedIndex = 0;
            this.tablessControl.Size = new System.Drawing.Size(476, 411);
            this.tablessControl.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "welcome 0";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "اهلا بك في معالج اعداد برنامج مدير المشاريع !\r\n\r\n\r\nهذا البرنامج يتطلب قاعدة بيانا" +
                "ت SQL Server .\r\n";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ConnectRadioButton);
            this.tabPage5.Controls.Add(this.CreateRadioButton);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(468, 385);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "choose 1";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ConnectRadioButton
            // 
            this.ConnectRadioButton.AutoSize = true;
            this.ConnectRadioButton.Location = new System.Drawing.Point(262, 115);
            this.ConnectRadioButton.Name = "ConnectRadioButton";
            this.ConnectRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConnectRadioButton.Size = new System.Drawing.Size(154, 17);
            this.ConnectRadioButton.TabIndex = 2;
            this.ConnectRadioButton.Text = "الاتصال بقاعدة بيانات موجودة";
            this.ConnectRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreateRadioButton
            // 
            this.CreateRadioButton.AutoSize = true;
            this.CreateRadioButton.Location = new System.Drawing.Point(279, 92);
            this.CreateRadioButton.Name = "CreateRadioButton";
            this.CreateRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CreateRadioButton.Size = new System.Drawing.Size(137, 17);
            this.CreateRadioButton.TabIndex = 1;
            this.CreateRadioButton.Text = "إنشاء قاعدة بيانات جديدة";
            this.CreateRadioButton.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(388, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "يرجى الاختيار";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SQLRadioButton);
            this.tabPage2.Controls.Add(this.SQLexprRadioButton);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "create 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SQLRadioButton
            // 
            this.SQLRadioButton.AutoSize = true;
            this.SQLRadioButton.Location = new System.Drawing.Point(83, 128);
            this.SQLRadioButton.Name = "SQLRadioButton";
            this.SQLRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SQLRadioButton.Size = new System.Drawing.Size(79, 17);
            this.SQLRadioButton.TabIndex = 2;
            this.SQLRadioButton.Text = "SQL Server";
            this.SQLRadioButton.UseVisualStyleBackColor = true;
            // 
            // SQLexprRadioButton
            // 
            this.SQLexprRadioButton.AutoSize = true;
            this.SQLexprRadioButton.Location = new System.Drawing.Point(83, 105);
            this.SQLexprRadioButton.Name = "SQLexprRadioButton";
            this.SQLexprRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SQLexprRadioButton.Size = new System.Drawing.Size(207, 17);
            this.SQLexprRadioButton.TabIndex = 1;
            this.SQLexprRadioButton.Text = "SQL Server Express (Locally Installed)";
            this.SQLexprRadioButton.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(313, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "يرجى اختيار نوع قاعدة البيانات";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.ServerCreateComboBox);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.TimeOutTextBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.PathCreateTextBox);
            this.tabPage3.Controls.Add(this.DatabaseCreateTextBox);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.UsernameCreateTextBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.PasswordCreateTextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(468, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "create 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(330, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 69;
            this.label15.Text = "يرجى ملء البيانات";
            // 
            // ServerCreateComboBox
            // 
            this.ServerCreateComboBox.FormattingEnabled = true;
            this.ServerCreateComboBox.Location = new System.Drawing.Point(45, 126);
            this.ServerCreateComboBox.Name = "ServerCreateComboBox";
            this.ServerCreateComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServerCreateComboBox.Size = new System.Drawing.Size(231, 21);
            this.ServerCreateComboBox.TabIndex = 1;
            this.ServerCreateComboBox.DropDown += new System.EventHandler(this.ServerCreateComboBox_DropDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 260);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "المسار على المخدم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 129);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "المخدم";
            // 
            // TimeOutTextBox
            // 
            this.TimeOutTextBox.Location = new System.Drawing.Point(45, 205);
            this.TimeOutTextBox.Mask = "00000";
            this.TimeOutTextBox.Name = "TimeOutTextBox";
            this.TimeOutTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeOutTextBox.Size = new System.Drawing.Size(231, 20);
            this.TimeOutTextBox.TabIndex = 4;
            this.TimeOutTextBox.Text = "15";
            this.TimeOutTextBox.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 129);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "المخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 234);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "اسم قاعدة البيانات";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 260);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "المسار على المخدم";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 208);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "وقت الانتظار";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 234);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "قاعدة البيانات";
            // 
            // PathCreateTextBox
            // 
            this.PathCreateTextBox.Location = new System.Drawing.Point(45, 257);
            this.PathCreateTextBox.Name = "PathCreateTextBox";
            this.PathCreateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PathCreateTextBox.Size = new System.Drawing.Size(231, 20);
            this.PathCreateTextBox.TabIndex = 6;
            // 
            // DatabaseCreateTextBox
            // 
            this.DatabaseCreateTextBox.Location = new System.Drawing.Point(45, 231);
            this.DatabaseCreateTextBox.Name = "DatabaseCreateTextBox";
            this.DatabaseCreateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatabaseCreateTextBox.Size = new System.Drawing.Size(231, 20);
            this.DatabaseCreateTextBox.TabIndex = 5;
            this.DatabaseCreateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 182);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "كلمة السر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 208);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "وقت الانتظار";
            // 
            // UsernameCreateTextBox
            // 
            this.UsernameCreateTextBox.Location = new System.Drawing.Point(45, 153);
            this.UsernameCreateTextBox.Name = "UsernameCreateTextBox";
            this.UsernameCreateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameCreateTextBox.Size = new System.Drawing.Size(231, 20);
            this.UsernameCreateTextBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 156);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "اسم المستخدم";
            // 
            // PasswordCreateTextBox
            // 
            this.PasswordCreateTextBox.Location = new System.Drawing.Point(45, 179);
            this.PasswordCreateTextBox.Name = "PasswordCreateTextBox";
            this.PasswordCreateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordCreateTextBox.Size = new System.Drawing.Size(231, 20);
            this.PasswordCreateTextBox.TabIndex = 3;
            this.PasswordCreateTextBox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 182);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "كلمة السر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 156);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "اسم المستخدم";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button2);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.PasswordConnectTextBox);
            this.tabPage6.Controls.Add(this.ServerConnectComboBox);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.DatabaseConnectComboBox);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.UsernameConnectTextBox);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(468, 385);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "open 5";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "محاولة اتصال";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(45, 30);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(374, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "يرجى تحديد بيانات الاتصال مع المخدم الذي تتواجد عليه قاعدة بيانات منشأة سابقاً";
            // 
            // PasswordConnectTextBox
            // 
            this.PasswordConnectTextBox.Location = new System.Drawing.Point(146, 163);
            this.PasswordConnectTextBox.Name = "PasswordConnectTextBox";
            this.PasswordConnectTextBox.PasswordChar = '#';
            this.PasswordConnectTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordConnectTextBox.Size = new System.Drawing.Size(180, 20);
            this.PasswordConnectTextBox.TabIndex = 3;
            this.PasswordConnectTextBox.UseSystemPasswordChar = true;
            // 
            // ServerConnectComboBox
            // 
            this.ServerConnectComboBox.FormattingEnabled = true;
            this.ServerConnectComboBox.Location = new System.Drawing.Point(146, 109);
            this.ServerConnectComboBox.Name = "ServerConnectComboBox";
            this.ServerConnectComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServerConnectComboBox.Size = new System.Drawing.Size(180, 21);
            this.ServerConnectComboBox.TabIndex = 1;
            this.ServerConnectComboBox.DropDown += new System.EventHandler(this.ServerConnectComboBox_DropDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(332, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "كلمة السر";
            // 
            // DatabaseConnectComboBox
            // 
            this.DatabaseConnectComboBox.FormattingEnabled = true;
            this.DatabaseConnectComboBox.Location = new System.Drawing.Point(146, 189);
            this.DatabaseConnectComboBox.Name = "DatabaseConnectComboBox";
            this.DatabaseConnectComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatabaseConnectComboBox.Size = new System.Drawing.Size(180, 21);
            this.DatabaseConnectComboBox.TabIndex = 4;
            this.DatabaseConnectComboBox.DropDown += new System.EventHandler(this.DatabaseConnectComboBox_DropDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(332, 112);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "المخدم";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(332, 139);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "اسم مستخدم";
            // 
            // UsernameConnectTextBox
            // 
            this.UsernameConnectTextBox.Location = new System.Drawing.Point(146, 136);
            this.UsernameConnectTextBox.Name = "UsernameConnectTextBox";
            this.UsernameConnectTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameConnectTextBox.Size = new System.Drawing.Size(180, 20);
            this.UsernameConnectTextBox.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(332, 192);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "قاعدة البيانات";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.AppLoginRadioButton);
            this.tabPage7.Controls.Add(this.LoginAsADuserRadioButton);
            this.tabPage7.Controls.Add(this.label22);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(468, 385);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "option 6";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // AppLoginRadioButton
            // 
            this.AppLoginRadioButton.AutoSize = true;
            this.AppLoginRadioButton.Location = new System.Drawing.Point(135, 108);
            this.AppLoginRadioButton.Name = "AppLoginRadioButton";
            this.AppLoginRadioButton.Size = new System.Drawing.Size(281, 17);
            this.AppLoginRadioButton.TabIndex = 5;
            this.AppLoginRadioButton.Text = "اسم مستخدم وكلمة مرور (Application Authentication)";
            this.AppLoginRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoginAsADuserRadioButton
            // 
            this.LoginAsADuserRadioButton.AutoSize = true;
            this.LoginAsADuserRadioButton.Location = new System.Drawing.Point(160, 85);
            this.LoginAsADuserRadioButton.Name = "LoginAsADuserRadioButton";
            this.LoginAsADuserRadioButton.Size = new System.Drawing.Size(256, 17);
            this.LoginAsADuserRadioButton.TabIndex = 4;
            this.LoginAsADuserRadioButton.Text = "حساب ويندوز من مجال (Windows Authentication)";
            this.LoginAsADuserRadioButton.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(175, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(244, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "يرجى تحديد نمط تسجيل الدخول إلى مدير المشاريع:\r\n";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.SuccessLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(468, 385);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "success 7";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SuccessLabel.Location = new System.Drawing.Point(43, 30);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(413, 115);
            this.SuccessLabel.TabIndex = 0;
            this.SuccessLabel.Text = "تم بنجاح";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label23);
            this.tabPage8.Controls.Add(this.BackupPathButton);
            this.tabPage8.Controls.Add(this.BackupPathTextBox);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(468, 385);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "create 4";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(249, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(211, 26);
            this.label23.TabIndex = 17;
            this.label23.Text = "يرجى تحديد  مسار المجلد للنسخ الاحتياطي \r\n(يجب أن يكون مسار شبكة UNC Path)\r\n";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackupPathButton
            // 
            this.BackupPathButton.Location = new System.Drawing.Point(28, 110);
            this.BackupPathButton.Name = "BackupPathButton";
            this.BackupPathButton.Size = new System.Drawing.Size(29, 23);
            this.BackupPathButton.TabIndex = 16;
            this.BackupPathButton.Text = ". .";
            this.BackupPathButton.UseVisualStyleBackColor = true;
            this.BackupPathButton.Click += new System.EventHandler(this.BackupPathButton_Click);
            // 
            // BackupPathTextBox
            // 
            this.BackupPathTextBox.Location = new System.Drawing.Point(63, 112);
            this.BackupPathTextBox.Name = "BackupPathTextBox";
            this.BackupPathTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackupPathTextBox.Size = new System.Drawing.Size(394, 20);
            this.BackupPathTextBox.TabIndex = 15;
            // 
            // ApplicationWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(617, 459);
            this.ControlBox = false;
            this.Controls.Add(this.DontShowAgainCheckBox);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.tablessControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationWizardForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معالج اعداد البرنامج";
            this.Load += new System.EventHandler(this.ApplicationWizardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tablessControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitButton;
        private System.ComponentModel.BackgroundWorker CreateDatabaseBGW;
        private System.ComponentModel.BackgroundWorker GetServersBGW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TablessControl tablessControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton SQLRadioButton;
        private System.Windows.Forms.RadioButton SQLexprRadioButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox ServerCreateComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TimeOutTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PathCreateTextBox;
        private System.Windows.Forms.TextBox DatabaseCreateTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UsernameCreateTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PasswordCreateTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RadioButton ConnectRadioButton;
        private System.Windows.Forms.RadioButton CreateRadioButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private ProtectedTextBox PasswordConnectTextBox;
        public System.Windows.Forms.ComboBox ServerConnectComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox DatabaseConnectComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox UsernameConnectTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RadioButton AppLoginRadioButton;
        private System.Windows.Forms.RadioButton LoginAsADuserRadioButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox DontShowAgainCheckBox;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button BackupPathButton;
        private System.Windows.Forms.TextBox BackupPathTextBox;
    }
}