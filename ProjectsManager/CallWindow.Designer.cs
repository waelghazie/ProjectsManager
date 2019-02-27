namespace ProjectsManager
{
    partial class CallWindow
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
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CallTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.ByUserLabel = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ScheduleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DaysComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Asterisk3 = new System.Windows.Forms.Label();
            this.Asterisk4 = new System.Windows.Forms.Label();
            this.plantChoose1 = new ProjectsManager.PlantChoose();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "وقت الاتصال";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // CallTextBox
            // 
            this.CallTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CallTextBox.Location = new System.Drawing.Point(0, 300);
            this.CallTextBox.Multiline = true;
            this.CallTextBox.Name = "CallTextBox";
            this.CallTextBox.Size = new System.Drawing.Size(703, 83);
            this.CallTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ملخص الاتصال";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectsManager.Properties.Resources.smartphone_7;
            this.pictureBox1.Location = new System.Drawing.Point(641, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.ExitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(703, 39);
            this.toolStrip1.TabIndex = 30;
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
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitButton.Image = global::ProjectsManager.Properties.Resources.exit_1;
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.ExitButton.Size = new System.Drawing.Size(61, 36);
            this.ExitButton.Text = "خروج";
            this.ExitButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ByUserLabel
            // 
            this.ByUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ByUserLabel.Location = new System.Drawing.Point(501, 263);
            this.ByUserLabel.Name = "ByUserLabel";
            this.ByUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ByUserLabel.Size = new System.Drawing.Size(190, 13);
            this.ByUserLabel.TabIndex = 31;
            this.ByUserLabel.Text = "ByUser";
            this.ByUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(363, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "وقت الاضافة";
            // 
            // ScheduleLinkLabel
            // 
            this.ScheduleLinkLabel.AutoSize = true;
            this.ScheduleLinkLabel.Location = new System.Drawing.Point(101, 187);
            this.ScheduleLinkLabel.Name = "ScheduleLinkLabel";
            this.ScheduleLinkLabel.Size = new System.Drawing.Size(216, 13);
            this.ScheduleLinkLabel.TabIndex = 34;
            this.ScheduleLinkLabel.TabStop = true;
            this.ScheduleLinkLabel.Text = "هل تود جدولة الوحدة ضمن المواعيد النشطة ؟";
            this.ScheduleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DaysComboBox
            // 
            this.DaysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DaysComboBox.FormattingEnabled = true;
            this.DaysComboBox.Items.AddRange(new object[] {
            "3",
            "6",
            "12",
            "30"});
            this.DaysComboBox.Location = new System.Drawing.Point(176, 13);
            this.DaysComboBox.Name = "DaysComboBox";
            this.DaysComboBox.Size = new System.Drawing.Size(77, 21);
            this.DaysComboBox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "جدولة لمدة مجال";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "يوم اعتباراً من تاريخ اليوم";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DaysComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(100, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 73);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // Asterisk3
            // 
            this.Asterisk3.AutoSize = true;
            this.Asterisk3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asterisk3.ForeColor = System.Drawing.Color.Red;
            this.Asterisk3.Location = new System.Drawing.Point(550, 142);
            this.Asterisk3.Name = "Asterisk3";
            this.Asterisk3.Size = new System.Drawing.Size(19, 19);
            this.Asterisk3.TabIndex = 49;
            this.Asterisk3.Text = "*";
            this.Asterisk3.Visible = false;
            // 
            // Asterisk4
            // 
            this.Asterisk4.AutoSize = true;
            this.Asterisk4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asterisk4.ForeColor = System.Drawing.Color.Red;
            this.Asterisk4.Location = new System.Drawing.Point(90, 279);
            this.Asterisk4.Name = "Asterisk4";
            this.Asterisk4.Size = new System.Drawing.Size(19, 19);
            this.Asterisk4.TabIndex = 50;
            this.Asterisk4.Text = "*";
            this.Asterisk4.Visible = false;
            // 
            // plantChoose1
            // 
            this.plantChoose1.Location = new System.Drawing.Point(35, 128);
            this.plantChoose1.MaximumSize = new System.Drawing.Size(509, 42);
            this.plantChoose1.Name = "plantChoose1";
            this.plantChoose1.Size = new System.Drawing.Size(509, 42);
            this.plantChoose1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(501, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "تسجيل المعلومات من قبل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 383);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plantChoose1);
            this.Controls.Add(this.Asterisk4);
            this.Controls.Add(this.Asterisk3);
            this.Controls.Add(this.ScheduleLinkLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.ByUserLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CallTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CallWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اتصال جديد";
            this.Load += new System.EventHandler(this.CallWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox CallTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.Label ByUserLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ScheduleLinkLabel;
        private System.Windows.Forms.ComboBox DaysComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Asterisk3;
        private System.Windows.Forms.Label Asterisk4;
        private System.Windows.Forms.Label label2;
        public PlantChoose plantChoose1;
    }
}