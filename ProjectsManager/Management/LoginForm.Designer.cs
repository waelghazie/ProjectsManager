namespace ProjectsManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new ProjectsManager.ProtectedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.QuickLoginLabel = new System.Windows.Forms.Label();
            this.ExitAppButton = new System.Windows.Forms.Button();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.PasswordStatusLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DatabaseLabel);
            this.panel1.Controls.Add(this.QuickLoginLabel);
            this.panel1.Controls.Add(this.ExitAppButton);
            this.panel1.Controls.Add(this.LanguageLabel);
            this.panel1.Controls.Add(this.PasswordStatusLabel);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UserNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 297);
            this.panel1.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(11, 261);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "اغلاق";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(177, 148);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBox.Size = new System.Drawing.Size(166, 20);
            this.PasswordTextBox.TabIndex = 14;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ProjectsManager.Properties.Resources.user_img;
            this.pictureBox1.Location = new System.Drawing.Point(388, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseLabel.Location = new System.Drawing.Point(388, 171);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatabaseLabel.Size = new System.Drawing.Size(118, 19);
            this.DatabaseLabel.TabIndex = 22;
            this.DatabaseLabel.Text = "DatabaseLabel";
            this.DatabaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuickLoginLabel
            // 
            this.QuickLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuickLoginLabel.AutoSize = true;
            this.QuickLoginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuickLoginLabel.Location = new System.Drawing.Point(-1, 0);
            this.QuickLoginLabel.Name = "QuickLoginLabel";
            this.QuickLoginLabel.Size = new System.Drawing.Size(83, 13);
            this.QuickLoginLabel.TabIndex = 21;
            this.QuickLoginLabel.Text = "QuickLoginLabel";
            this.QuickLoginLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.QuickLogingLabel_MouseDoubleClick);
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitAppButton.Location = new System.Drawing.Point(431, 261);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(75, 23);
            this.ExitAppButton.TabIndex = 17;
            this.ExitAppButton.Text = "خروج";
            this.ExitAppButton.UseVisualStyleBackColor = true;
            this.ExitAppButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LanguageLabel.Location = new System.Drawing.Point(92, 151);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LanguageLabel.Size = new System.Drawing.Size(81, 15);
            this.LanguageLabel.TabIndex = 20;
            this.LanguageLabel.Text = "LanguageLabel";
            // 
            // PasswordStatusLabel
            // 
            this.PasswordStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordStatusLabel.AutoSize = true;
            this.PasswordStatusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PasswordStatusLabel.Location = new System.Drawing.Point(237, 174);
            this.PasswordStatusLabel.Name = "PasswordStatusLabel";
            this.PasswordStatusLabel.Size = new System.Drawing.Size(109, 13);
            this.PasswordStatusLabel.TabIndex = 19;
            this.PasswordStatusLabel.Text = "PasswordStatusLabel";
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.Location = new System.Drawing.Point(11, 146);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 15;
            this.LoginButton.Text = "دخول";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "كلمة السر";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "اسم المستخدم";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameTextBox.Location = new System.Drawing.Point(177, 102);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.UserNameTextBox.TabIndex = 13;
            this.UserNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserNameTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "أهلاً بك ، يرجى ادخال اسم المستخدم وكلمة السر";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 297);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج ادارة المشاريع";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginWindow_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private ProtectedTextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Label QuickLoginLabel;
        private System.Windows.Forms.Button ExitAppButton;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Label PasswordStatusLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label1;

    }
}