namespace ProjectsManager
{
    partial class LicenseForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ActivationStatusLabel = new System.Windows.Forms.Label();
            this.HowToActivateLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ExportKeyButton = new System.Windows.Forms.Button();
            this.ExportKeyLabel = new System.Windows.Forms.Label();
            this.ImportKeyLabel = new System.Windows.Forms.Label();
            this.ImportKeyButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuccessPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(223, 26);
            this.WelcomeLabel.TabIndex = 11;
            this.WelcomeLabel.Text = "شكراً لاستخدامك برنامج مدير المشاريع\r\nهذا البرنامج يخضع لقواعد حماية الملكية الفك" +
    "رية";
            // 
            // ActivationStatusLabel
            // 
            this.ActivationStatusLabel.AutoSize = true;
            this.ActivationStatusLabel.Location = new System.Drawing.Point(12, 314);
            this.ActivationStatusLabel.Name = "ActivationStatusLabel";
            this.ActivationStatusLabel.Size = new System.Drawing.Size(144, 13);
            this.ActivationStatusLabel.TabIndex = 10;
            this.ActivationStatusLabel.Text = "عدد مرات التشغيل المتبقية : ";
            // 
            // HowToActivateLabel
            // 
            this.HowToActivateLabel.AutoSize = true;
            this.HowToActivateLabel.Location = new System.Drawing.Point(12, 54);
            this.HowToActivateLabel.Name = "HowToActivateLabel";
            this.HowToActivateLabel.Size = new System.Drawing.Size(121, 39);
            this.HowToActivateLabel.TabIndex = 9;
            this.HowToActivateLabel.Text = "للتفعيل التواصل عبر \r\nwael.ghazie@gmail.com\r\nMobile: 0962263238\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pmak";
            this.openFileDialog1.Filter = "Activation Key|*.pmak";
            this.openFileDialog1.Title = "يرجى تحديد ملف التفعيل";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.DefaultExt = "pmrk";
            this.saveFileDialog1.FileName = "Key";
            this.saveFileDialog1.Filter = "Request Key|*.pmrk";
            this.saveFileDialog1.Title = "تصدير المفتاح الخاص - الرجاء اختيار مكان الحفظ";
            // 
            // ExportKeyButton
            // 
            this.ExportKeyButton.Location = new System.Drawing.Point(108, 143);
            this.ExportKeyButton.Name = "ExportKeyButton";
            this.ExportKeyButton.Size = new System.Drawing.Size(25, 23);
            this.ExportKeyButton.TabIndex = 12;
            this.ExportKeyButton.Text = "..";
            this.ExportKeyButton.UseVisualStyleBackColor = true;
            this.ExportKeyButton.Click += new System.EventHandler(this.ExportKeyButton_Click);
            // 
            // ExportKeyLabel
            // 
            this.ExportKeyLabel.AutoSize = true;
            this.ExportKeyLabel.Location = new System.Drawing.Point(70, 127);
            this.ExportKeyLabel.Name = "ExportKeyLabel";
            this.ExportKeyLabel.Size = new System.Drawing.Size(101, 13);
            this.ExportKeyLabel.TabIndex = 13;
            this.ExportKeyLabel.Text = "تصدير المفتاح الخاص";
            // 
            // ImportKeyLabel
            // 
            this.ImportKeyLabel.AutoSize = true;
            this.ImportKeyLabel.Location = new System.Drawing.Point(250, 127);
            this.ImportKeyLabel.Name = "ImportKeyLabel";
            this.ImportKeyLabel.Size = new System.Drawing.Size(102, 13);
            this.ImportKeyLabel.TabIndex = 15;
            this.ImportKeyLabel.Text = "استيراد ملف التفعيل";
            // 
            // ImportKeyButton
            // 
            this.ImportKeyButton.Location = new System.Drawing.Point(289, 143);
            this.ImportKeyButton.Name = "ImportKeyButton";
            this.ImportKeyButton.Size = new System.Drawing.Size(25, 23);
            this.ImportKeyButton.TabIndex = 14;
            this.ImportKeyButton.Text = "..";
            this.ImportKeyButton.UseVisualStyleBackColor = true;
            this.ImportKeyButton.Click += new System.EventHandler(this.ImportKeyButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(343, 309);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "اغلاق";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(15, 180);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(403, 13);
            this.InfoLabel.TabIndex = 18;
            this.InfoLabel.Text = "InfoLabel";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectsManager.Properties.Resources.diploma;
            this.pictureBox1.Location = new System.Drawing.Point(361, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // SuccessPictureBox
            // 
            this.SuccessPictureBox.Image = global::ProjectsManager.Properties.Resources.success;
            this.SuccessPictureBox.Location = new System.Drawing.Point(190, 208);
            this.SuccessPictureBox.Name = "SuccessPictureBox";
            this.SuccessPictureBox.Size = new System.Drawing.Size(45, 42);
            this.SuccessPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SuccessPictureBox.TabIndex = 20;
            this.SuccessPictureBox.TabStop = false;
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(430, 344);
            this.ControlBox = false;
            this.Controls.Add(this.SuccessPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ImportKeyLabel);
            this.Controls.Add(this.ImportKeyButton);
            this.Controls.Add(this.ExportKeyLabel);
            this.Controls.Add(this.ExportKeyButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ActivationStatusLabel);
            this.Controls.Add(this.HowToActivateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LicenseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ترخيص البرنامج";
            this.Load += new System.EventHandler(this.LicenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label ActivationStatusLabel;
        private System.Windows.Forms.Label HowToActivateLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ExportKeyButton;
        private System.Windows.Forms.Label ExportKeyLabel;
        private System.Windows.Forms.Label ImportKeyLabel;
        private System.Windows.Forms.Button ImportKeyButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SuccessPictureBox;
    }
}