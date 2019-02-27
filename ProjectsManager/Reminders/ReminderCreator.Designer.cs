namespace ProjectsManager
{
    partial class ReminderCreator
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.ToUserComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RegardingPlantCheckBox = new System.Windows.Forms.CheckBox();
            this.Asterisk1 = new System.Windows.Forms.Label();
            this.Asterisk2 = new System.Windows.Forms.Label();
            this.Asterisk3 = new System.Windows.Forms.Label();
            this.plantChoose1 = new ProjectsManager.PlantChoose();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان التذكير";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(99, 218);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(509, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "الأهمية";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(0, 262);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(689, 101);
            this.textBox2.TabIndex = 3;
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Location = new System.Drawing.Point(422, 82);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(121, 21);
            this.PriorityComboBox.TabIndex = 4;
            // 
            // ToUserComboBox
            // 
            this.ToUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToUserComboBox.FormattingEnabled = true;
            this.ToUserComboBox.Location = new System.Drawing.Point(99, 81);
            this.ToUserComboBox.Name = "ToUserComboBox";
            this.ToUserComboBox.Size = new System.Drawing.Size(182, 21);
            this.ToUserComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "إلى";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "وقت التذكير";
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
            this.toolStrip1.Size = new System.Drawing.Size(689, 39);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = global::ProjectsManager.Properties.Resources.push_pin;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.SaveButton.Size = new System.Drawing.Size(79, 54);
            this.SaveButton.Text = "حفظ";
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitButton.Image = global::ProjectsManager.Properties.Resources.exit_1;
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.ExitButton.Size = new System.Drawing.Size(79, 54);
            this.ExitButton.Text = "إلغاء";
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectsManager.Properties.Resources.alarm_clock;
            this.pictureBox1.Location = new System.Drawing.Point(627, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "نص التذكير";
            // 
            // RegardingPlantCheckBox
            // 
            this.RegardingPlantCheckBox.AutoSize = true;
            this.RegardingPlantCheckBox.Location = new System.Drawing.Point(99, 147);
            this.RegardingPlantCheckBox.Name = "RegardingPlantCheckBox";
            this.RegardingPlantCheckBox.Size = new System.Drawing.Size(130, 17);
            this.RegardingPlantCheckBox.TabIndex = 36;
            this.RegardingPlantCheckBox.Text = "بخصوص وحدة معالجة :";
            this.RegardingPlantCheckBox.UseVisualStyleBackColor = true;
            this.RegardingPlantCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Asterisk1
            // 
            this.Asterisk1.AutoSize = true;
            this.Asterisk1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asterisk1.ForeColor = System.Drawing.Color.Red;
            this.Asterisk1.Location = new System.Drawing.Point(614, 216);
            this.Asterisk1.Name = "Asterisk1";
            this.Asterisk1.Size = new System.Drawing.Size(19, 19);
            this.Asterisk1.TabIndex = 51;
            this.Asterisk1.Text = "*";
            this.Asterisk1.Visible = false;
            // 
            // Asterisk2
            // 
            this.Asterisk2.AutoSize = true;
            this.Asterisk2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asterisk2.ForeColor = System.Drawing.Color.Red;
            this.Asterisk2.Location = new System.Drawing.Point(287, 82);
            this.Asterisk2.Name = "Asterisk2";
            this.Asterisk2.Size = new System.Drawing.Size(19, 19);
            this.Asterisk2.TabIndex = 52;
            this.Asterisk2.Text = "*";
            this.Asterisk2.Visible = false;
            // 
            // Asterisk3
            // 
            this.Asterisk3.AutoSize = true;
            this.Asterisk3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asterisk3.ForeColor = System.Drawing.Color.Red;
            this.Asterisk3.Location = new System.Drawing.Point(614, 170);
            this.Asterisk3.Name = "Asterisk3";
            this.Asterisk3.Size = new System.Drawing.Size(19, 19);
            this.Asterisk3.TabIndex = 53;
            this.Asterisk3.Text = "*";
            this.Asterisk3.Visible = false;
            // 
            // plantChoose1
            // 
            this.plantChoose1.Location = new System.Drawing.Point(99, 170);
            this.plantChoose1.MaximumSize = new System.Drawing.Size(509, 42);
            this.plantChoose1.Name = "plantChoose1";
            this.plantChoose1.Size = new System.Drawing.Size(509, 42);
            this.plantChoose1.TabIndex = 33;
            this.plantChoose1.Visible = false;
            // 
            // ReminderCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 363);
            this.ControlBox = false;
            this.Controls.Add(this.Asterisk3);
            this.Controls.Add(this.Asterisk2);
            this.Controls.Add(this.Asterisk1);
            this.Controls.Add(this.RegardingPlantCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plantChoose1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToUserComboBox);
            this.Controls.Add(this.PriorityComboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReminderCreator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إنشاء تذكير";
            this.Load += new System.EventHandler(this.ReminderCreator_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.ComboBox ToUserComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PlantChoose plantChoose1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox RegardingPlantCheckBox;
        private System.Windows.Forms.Label Asterisk1;
        private System.Windows.Forms.Label Asterisk2;
        private System.Windows.Forms.Label Asterisk3;
    }
}