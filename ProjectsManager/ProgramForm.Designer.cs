namespace ProjectsManager
{
    partial class ProgramForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgramDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.VisorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AccompanyingComboBox = new System.Windows.Forms.ComboBox();
            this.DriverComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ProgramNOTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.VisitNoteTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgramTextBox = new System.Windows.Forms.TextBox();
            this.CarComboBox = new System.Windows.Forms.ComboBox();
            this.AddPlantToDGVButton = new System.Windows.Forms.PictureBox();
            this.RemovePlantFromDGVButton = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Asterisk1 = new System.Windows.Forms.Label();
            this.ByUserComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VisitTextBox = new System.Windows.Forms.RichTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.InsertStatusComboBox = new System.Windows.Forms.ComboBox();
            this.CancelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.plantChoose1 = new ProjectsManager.PlantChoose();
            this.SaveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUPButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddPlantToDGVButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePlantFromDGVButton)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاريخ البرنامج";
            // 
            // ProgramDatePicker
            // 
            this.ProgramDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ProgramDatePicker.Location = new System.Drawing.Point(709, 28);
            this.ProgramDatePicker.Name = "ProgramDatePicker";
            this.ProgramDatePicker.RightToLeftLayout = true;
            this.ProgramDatePicker.Size = new System.Drawing.Size(134, 20);
            this.ProgramDatePicker.TabIndex = 1;
            this.ProgramDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(19, 74);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(342, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "يرجى تعبئة الحقول ليتم إنشاء حركة ورشات  ، ثم اختيار المنشأت :";
            // 
            // VisorComboBox
            // 
            this.VisorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VisorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VisorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisorComboBox.FormattingEnabled = true;
            this.VisorComboBox.Location = new System.Drawing.Point(378, 20);
            this.VisorComboBox.Name = "VisorComboBox";
            this.VisorComboBox.Size = new System.Drawing.Size(199, 21);
            this.VisorComboBox.TabIndex = 3;
            this.VisorComboBox.SelectedIndexChanged += new System.EventHandler(this.VisorComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "مسؤول الورشة";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "المرافق";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "المطلوب";
            // 
            // AccompanyingComboBox
            // 
            this.AccompanyingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccompanyingComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AccompanyingComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AccompanyingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccompanyingComboBox.FormattingEnabled = true;
            this.AccompanyingComboBox.Location = new System.Drawing.Point(378, 47);
            this.AccompanyingComboBox.Name = "AccompanyingComboBox";
            this.AccompanyingComboBox.Size = new System.Drawing.Size(199, 21);
            this.AccompanyingComboBox.TabIndex = 9;
            this.AccompanyingComboBox.SelectedIndexChanged += new System.EventHandler(this.AccompanyingComboBox_SelectedIndexChanged);
            // 
            // DriverComboBox
            // 
            this.DriverComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DriverComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DriverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriverComboBox.FormattingEnabled = true;
            this.DriverComboBox.Location = new System.Drawing.Point(378, 74);
            this.DriverComboBox.Name = "DriverComboBox";
            this.DriverComboBox.Size = new System.Drawing.Size(199, 21);
            this.DriverComboBox.TabIndex = 11;
            this.DriverComboBox.SelectedIndexChanged += new System.EventHandler(this.DriverComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "السائق";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(227, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "وسيلة النقل";
            // 
            // ProgramNOTextBox
            // 
            this.ProgramNOTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramNOTextBox.Location = new System.Drawing.Point(709, 54);
            this.ProgramNOTextBox.Name = "ProgramNOTextBox";
            this.ProgramNOTextBox.ReadOnly = true;
            this.ProgramNOTextBox.Size = new System.Drawing.Size(134, 20);
            this.ProgramNOTextBox.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(849, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "#";
            // 
            // VisitNoteTextBox
            // 
            this.VisitNoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitNoteTextBox.Location = new System.Drawing.Point(57, 35);
            this.VisitNoteTextBox.Multiline = true;
            this.VisitNoteTextBox.Name = "VisitNoteTextBox";
            this.VisitNoteTextBox.Size = new System.Drawing.Size(155, 60);
            this.VisitNoteTextBox.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "ملاحظات";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "اعداد البرنامج من قبل";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "ملاحظة البرنامج";
            // 
            // ProgramTextBox
            // 
            this.ProgramTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramTextBox.Location = new System.Drawing.Point(57, 103);
            this.ProgramTextBox.Name = "ProgramTextBox";
            this.ProgramTextBox.Size = new System.Drawing.Size(786, 20);
            this.ProgramTextBox.TabIndex = 36;
            this.ProgramTextBox.TextChanged += new System.EventHandler(this.ProgramTextBox_TextChanged);
            // 
            // CarComboBox
            // 
            this.CarComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarComboBox.FormattingEnabled = true;
            this.CarComboBox.Location = new System.Drawing.Point(57, 20);
            this.CarComboBox.Name = "CarComboBox";
            this.CarComboBox.Size = new System.Drawing.Size(164, 21);
            this.CarComboBox.TabIndex = 37;
            this.CarComboBox.SelectedIndexChanged += new System.EventHandler(this.CarComboBox_SelectedIndexChanged);
            // 
            // AddPlantToDGVButton
            // 
            this.AddPlantToDGVButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPlantToDGVButton.Image = global::ProjectsManager.Properties.Resources.plus;
            this.AddPlantToDGVButton.Location = new System.Drawing.Point(11, 35);
            this.AddPlantToDGVButton.Name = "AddPlantToDGVButton";
            this.AddPlantToDGVButton.Size = new System.Drawing.Size(40, 40);
            this.AddPlantToDGVButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPlantToDGVButton.TabIndex = 38;
            this.AddPlantToDGVButton.TabStop = false;
            this.AddPlantToDGVButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RemovePlantFromDGVButton
            // 
            this.RemovePlantFromDGVButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePlantFromDGVButton.Image = global::ProjectsManager.Properties.Resources.minus;
            this.RemovePlantFromDGVButton.Location = new System.Drawing.Point(11, 62);
            this.RemovePlantFromDGVButton.Name = "RemovePlantFromDGVButton";
            this.RemovePlantFromDGVButton.Size = new System.Drawing.Size(40, 40);
            this.RemovePlantFromDGVButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemovePlantFromDGVButton.TabIndex = 39;
            this.RemovePlantFromDGVButton.TabStop = false;
            this.RemovePlantFromDGVButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Asterisk1);
            this.groupBox1.Controls.Add(this.ByUserComboBox);
            this.groupBox1.Controls.Add(this.ProgramNOTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProgramTextBox);
            this.groupBox1.Controls.Add(this.CarComboBox);
            this.groupBox1.Controls.Add(this.ProgramDatePicker);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.VisorComboBox);
            this.groupBox1.Controls.Add(this.AccompanyingComboBox);
            this.groupBox1.Controls.Add(this.DriverComboBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(128, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 134);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات البرنامج";
            // 
            // Asterisk1
            // 
            this.Asterisk1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Asterisk1.AutoSize = true;
            this.Asterisk1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asterisk1.ForeColor = System.Drawing.Color.Red;
            this.Asterisk1.Location = new System.Drawing.Point(353, 23);
            this.Asterisk1.Name = "Asterisk1";
            this.Asterisk1.Size = new System.Drawing.Size(19, 19);
            this.Asterisk1.TabIndex = 44;
            this.Asterisk1.Text = "*";
            this.Asterisk1.Visible = false;
            // 
            // ByUserComboBox
            // 
            this.ByUserComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ByUserComboBox.Enabled = false;
            this.ByUserComboBox.FormattingEnabled = true;
            this.ByUserComboBox.Location = new System.Drawing.Point(57, 76);
            this.ByUserComboBox.Name = "ByUserComboBox";
            this.ByUserComboBox.Size = new System.Drawing.Size(164, 21);
            this.ByUserComboBox.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.VisitTextBox);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.InsertStatusComboBox);
            this.groupBox2.Controls.Add(this.CancelLinkLabel);
            this.groupBox2.Controls.Add(this.plantChoose1);
            this.groupBox2.Controls.Add(this.SaveLinkLabel);
            this.groupBox2.Controls.Add(this.AddPlantToDGVButton);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.VisitNoteTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(128, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 131);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اضافة زيارة إلى جدول الزيارات";
            // 
            // VisitTextBox
            // 
            this.VisitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitTextBox.Location = new System.Drawing.Point(218, 35);
            this.VisitTextBox.Name = "VisitTextBox";
            this.VisitTextBox.Size = new System.Drawing.Size(155, 60);
            this.VisitTextBox.TabIndex = 52;
            this.VisitTextBox.Text = "";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(344, 101);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 13);
            this.label31.TabIndex = 51;
            this.label31.Text = "إدراج";
            // 
            // InsertStatusComboBox
            // 
            this.InsertStatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InsertStatusComboBox.FormattingEnabled = true;
            this.InsertStatusComboBox.Items.AddRange(new object[] {
            "",
            "الاتصال (أخر تحديث)",
            "المطلوب (أخر تحديث)",
            "تقرير الصيانة (أخر تحديث)"});
            this.InsertStatusComboBox.Location = new System.Drawing.Point(221, 98);
            this.InsertStatusComboBox.Name = "InsertStatusComboBox";
            this.InsertStatusComboBox.Size = new System.Drawing.Size(123, 21);
            this.InsertStatusComboBox.TabIndex = 50;
            this.InsertStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.InsertStatusComboBox_SelectedIndexChanged);
            // 
            // CancelLinkLabel
            // 
            this.CancelLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelLinkLabel.AutoSize = true;
            this.CancelLinkLabel.Location = new System.Drawing.Point(90, 106);
            this.CancelLinkLabel.Name = "CancelLinkLabel";
            this.CancelLinkLabel.Size = new System.Drawing.Size(26, 13);
            this.CancelLinkLabel.TabIndex = 49;
            this.CancelLinkLabel.TabStop = true;
            this.CancelLinkLabel.Text = "إلغاء";
            this.CancelLinkLabel.Visible = false;
            this.CancelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // plantChoose1
            // 
            this.plantChoose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plantChoose1.Location = new System.Drawing.Point(379, 19);
            this.plantChoose1.MaximumSize = new System.Drawing.Size(509, 42);
            this.plantChoose1.Name = "plantChoose1";
            this.plantChoose1.Size = new System.Drawing.Size(509, 42);
            this.plantChoose1.TabIndex = 48;
            // 
            // SaveLinkLabel
            // 
            this.SaveLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveLinkLabel.AutoSize = true;
            this.SaveLinkLabel.Location = new System.Drawing.Point(125, 106);
            this.SaveLinkLabel.Name = "SaveLinkLabel";
            this.SaveLinkLabel.Size = new System.Drawing.Size(28, 13);
            this.SaveLinkLabel.TabIndex = 41;
            this.SaveLinkLabel.TabStop = true;
            this.SaveLinkLabel.Text = "حفظ";
            this.SaveLinkLabel.Visible = false;
            this.SaveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveLinkLabel_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.MoveDownButton);
            this.groupBox3.Controls.Add(this.MoveUPButton);
            this.groupBox3.Controls.Add(this.RemovePlantFromDGVButton);
            this.groupBox3.Location = new System.Drawing.Point(128, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(935, 161);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "جدول الزيارات الحركة";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(57, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(831, 126);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveDownButton.BackgroundImage = global::ProjectsManager.Properties.Resources.up_down2;
            this.MoveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveDownButton.FlatAppearance.BorderSize = 0;
            this.MoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDownButton.Location = new System.Drawing.Point(894, 87);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(35, 35);
            this.MoveDownButton.TabIndex = 49;
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // MoveUPButton
            // 
            this.MoveUPButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveUPButton.BackgroundImage = global::ProjectsManager.Properties.Resources.up_down1;
            this.MoveUPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveUPButton.FlatAppearance.BorderSize = 0;
            this.MoveUPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUPButton.Location = new System.Drawing.Point(894, 46);
            this.MoveUPButton.Name = "MoveUPButton";
            this.MoveUPButton.Size = new System.Drawing.Size(35, 35);
            this.MoveUPButton.TabIndex = 48;
            this.MoveUPButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MoveUPButton.UseVisualStyleBackColor = true;
            this.MoveUPButton.Click += new System.EventHandler(this.MoveUPButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.DeleteButton,
            this.PrintButton,
            this.ExitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1075, 39);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = global::ProjectsManager.Properties.Resources.save;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.SaveButton.Size = new System.Drawing.Size(61, 36);
            this.SaveButton.Text = "حفظ";
            this.SaveButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = global::ProjectsManager.Properties.Resources.garbage_1;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(36, 36);
            this.DeleteButton.Text = "حذف البرنامج";
            this.DeleteButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintButton.Image = global::ProjectsManager.Properties.Resources.print;
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.PrintButton.Size = new System.Drawing.Size(61, 36);
            this.PrintButton.Text = "طباعة";
            this.PrintButton.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitButton.Image = global::ProjectsManager.Properties.Resources.exit_1;
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.ExitButton.Size = new System.Drawing.Size(61, 36);
            this.ExitButton.Text = "اغلاق";
            this.ExitButton.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = global::ProjectsManager.Properties.Resources.map_location;
            this.pictureBox6.Location = new System.Drawing.Point(22, 121);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 47;
            this.pictureBox6.TabStop = false;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 551);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DescriptionLabel);
            this.Name = "ProgramForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعداد برنامج حركة الورشات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiceProgram_FormClosing);
            this.Load += new System.EventHandler(this.ServiceProgram_Load);
            this.Shown += new System.EventHandler(this.ProgramWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.AddPlantToDGVButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePlantFromDGVButton)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ProgramDatePicker;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.ComboBox VisorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AccompanyingComboBox;
        private System.Windows.Forms.ComboBox DriverComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ProgramNOTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox VisitNoteTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProgramTextBox;
        private System.Windows.Forms.ComboBox CarComboBox;
        private System.Windows.Forms.PictureBox AddPlantToDGVButton;
        private System.Windows.Forms.PictureBox RemovePlantFromDGVButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ComboBox ByUserComboBox;
        private System.Windows.Forms.Label Asterisk1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.LinkLabel SaveLinkLabel;
        private PlantChoose plantChoose1;
        private System.Windows.Forms.LinkLabel CancelLinkLabel;
        private System.Windows.Forms.Button MoveUPButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox InsertStatusComboBox;
        private System.Windows.Forms.RichTextBox VisitTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}