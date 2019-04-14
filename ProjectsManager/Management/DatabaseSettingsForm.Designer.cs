namespace ProjectsManager
{
    partial class DataSettingsForm
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
            this.label12 = new System.Windows.Forms.Label();
            this.HoursComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PhotosPathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseButton2 = new System.Windows.Forms.Button();
            this.BackupPathTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "ساعة";
            // 
            // HoursComboBox
            // 
            this.HoursComboBox.DisplayMember = "1";
            this.HoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursComboBox.FormattingEnabled = true;
            this.HoursComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.HoursComboBox.Location = new System.Drawing.Point(152, 201);
            this.HoursComboBox.Name = "HoursComboBox";
            this.HoursComboBox.Size = new System.Drawing.Size(51, 21);
            this.HoursComboBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "عمل نسخة احتياطية كل ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "الاعدادات الخاصة بقاعدة البيانات الحالية:";
            // 
            // PhotosPathTextBox
            // 
            this.PhotosPathTextBox.Location = new System.Drawing.Point(26, 98);
            this.PhotosPathTextBox.Name = "PhotosPathTextBox";
            this.PhotosPathTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhotosPathTextBox.Size = new System.Drawing.Size(303, 20);
            this.PhotosPathTextBox.TabIndex = 2;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(335, 98);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(29, 23);
            this.BrowseButton.TabIndex = 17;
            this.BrowseButton.Text = ". .";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "مسار المجلد الرئيسي للصور (مسار شبكة UNC Path):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "مسار المجلد للنسخ الاحتياطي (مسار شبكة UNC Path):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BrowseButton2
            // 
            this.BrowseButton2.Location = new System.Drawing.Point(335, 153);
            this.BrowseButton2.Name = "BrowseButton2";
            this.BrowseButton2.Size = new System.Drawing.Size(29, 23);
            this.BrowseButton2.TabIndex = 12;
            this.BrowseButton2.Text = ". .";
            this.BrowseButton2.UseVisualStyleBackColor = true;
            this.BrowseButton2.Click += new System.EventHandler(this.BrowseButton2_Click);
            // 
            // BackupPathTextBox
            // 
            this.BackupPathTextBox.Location = new System.Drawing.Point(26, 155);
            this.BackupPathTextBox.Name = "BackupPathTextBox";
            this.BackupPathTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackupPathTextBox.Size = new System.Drawing.Size(303, 20);
            this.BackupPathTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 366);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "حفظ";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(300, 366);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "إغلاق";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DataSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(387, 399);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.HoursComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PhotosPathTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BrowseButton2);
            this.Controls.Add(this.BackupPathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataSettingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اعدادات قاعدة البيانات";
            this.Load += new System.EventHandler(this.DataSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox HoursComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PhotosPathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrowseButton2;
        private System.Windows.Forms.TextBox BackupPathTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
    }
}