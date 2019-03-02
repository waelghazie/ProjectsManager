namespace ProjectsManager
{
    partial class Reminder
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReminderText = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.Label();
            this.FromUser = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowTimer = new System.Windows.Forms.Timer(this.components);
            this.SnoozeTimer = new System.Windows.Forms.Timer(this.components);
            this.HideTimer = new System.Windows.Forms.Timer(this.components);
            this.RegardingPlant = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 241);
            this.panel1.TabIndex = 8;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectsManager.Properties.Resources.alarm_icon;
            this.pictureBox1.Location = new System.Drawing.Point(268, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RegardingPlant, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ReminderText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Priority, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FromUser, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.54887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.45113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 200);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // ReminderText
            // 
            this.ReminderText.BackColor = System.Drawing.Color.White;
            this.ReminderText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReminderText.Location = new System.Drawing.Point(7, 25);
            this.ReminderText.Multiline = true;
            this.ReminderText.Name = "ReminderText";
            this.ReminderText.ReadOnly = true;
            this.ReminderText.Size = new System.Drawing.Size(237, 63);
            this.ReminderText.TabIndex = 1;
            this.ReminderText.Text = "Text";
            this.ReminderText.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(7, 144);
            this.Priority.Name = "Priority";
            this.Priority.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Priority.Size = new System.Drawing.Size(237, 23);
            this.Priority.TabIndex = 4;
            this.Priority.Text = "Priority";
            this.Priority.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // FromUser
            // 
            this.FromUser.Location = new System.Drawing.Point(7, 115);
            this.FromUser.Name = "FromUser";
            this.FromUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromUser.Size = new System.Drawing.Size(237, 23);
            this.FromUser.TabIndex = 5;
            this.FromUser.Text = "From User";
            this.FromUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FromUser.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(7, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(237, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(164, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "غفوة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(277, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "إنهاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // ShowTimer
            // 
            this.ShowTimer.Interval = 10;
            this.ShowTimer.Tick += new System.EventHandler(this.ShowTimer_Tick);
            // 
            // SnoozeTimer
            // 
            this.SnoozeTimer.Tick += new System.EventHandler(this.SnoozeTimer_Tick);
            // 
            // HideTimer
            // 
            this.HideTimer.Interval = 10;
            this.HideTimer.Tick += new System.EventHandler(this.HideTimer_Tick);
            // 
            // RegardingPlant
            // 
            this.RegardingPlant.Location = new System.Drawing.Point(7, 169);
            this.RegardingPlant.Name = "RegardingPlant";
            this.RegardingPlant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RegardingPlant.Size = new System.Drawing.Size(237, 23);
            this.RegardingPlant.TabIndex = 13;
            this.RegardingPlant.Text = "RegardingPlant";
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 241);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reminder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "تذكير";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Reminder_Load);
            this.Shown += new System.EventHandler(this.Reminder_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reminder_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ReminderText;
        private System.Windows.Forms.Label Priority;
        private System.Windows.Forms.Label FromUser;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer ShowTimer;
        private System.Windows.Forms.Timer SnoozeTimer;
        private System.Windows.Forms.Timer HideTimer;
        private System.Windows.Forms.Label RegardingPlant;

    }
}