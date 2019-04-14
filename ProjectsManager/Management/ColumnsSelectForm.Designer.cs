namespace ProjectsManager
{
    partial class ColumnsSelectForm
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
            this.InstituteName = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InstituteProfession = new System.Windows.Forms.CheckBox();
            this.InstituteSector = new System.Windows.Forms.CheckBox();
            this.InstituteAddress = new System.Windows.Forms.CheckBox();
            this.InstituteManager = new System.Windows.Forms.CheckBox();
            this.InstituteCustomer = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PlantLastVisit = new System.Windows.Forms.CheckBox();
            this.PlantContractType = new System.Windows.Forms.CheckBox();
            this.PlantDetails = new System.Windows.Forms.CheckBox();
            this.PlantLastStatus = new System.Windows.Forms.CheckBox();
            this.PlantContractor = new System.Windows.Forms.CheckBox();
            this.PlantInstituteName = new System.Windows.Forms.CheckBox();
            this.PlantTechPerson = new System.Windows.Forms.CheckBox();
            this.PlantName = new System.Windows.Forms.CheckBox();
            this.PlantCustomerName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstituteName
            // 
            this.InstituteName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstituteName.AutoSize = true;
            this.InstituteName.Checked = true;
            this.InstituteName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InstituteName.Location = new System.Drawing.Point(77, 19);
            this.InstituteName.Name = "InstituteName";
            this.InstituteName.Size = new System.Drawing.Size(88, 17);
            this.InstituteName.TabIndex = 0;
            this.InstituteName.Text = "اسم المنشأة";
            this.InstituteName.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.InstituteProfession);
            this.groupBox1.Controls.Add(this.InstituteSector);
            this.groupBox1.Controls.Add(this.InstituteAddress);
            this.groupBox1.Controls.Add(this.InstituteManager);
            this.groupBox1.Controls.Add(this.InstituteCustomer);
            this.groupBox1.Controls.Add(this.InstituteName);
            this.groupBox1.Location = new System.Drawing.Point(15, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المنشأت";
            // 
            // InstituteProfession
            // 
            this.InstituteProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstituteProfession.AutoSize = true;
            this.InstituteProfession.Location = new System.Drawing.Point(60, 159);
            this.InstituteProfession.Name = "InstituteProfession";
            this.InstituteProfession.Size = new System.Drawing.Size(105, 17);
            this.InstituteProfession.TabIndex = 5;
            this.InstituteProfession.Text = "اختصاص المنشأة";
            this.InstituteProfession.UseVisualStyleBackColor = true;
            // 
            // InstituteSector
            // 
            this.InstituteSector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstituteSector.AutoSize = true;
            this.InstituteSector.Location = new System.Drawing.Point(102, 131);
            this.InstituteSector.Name = "InstituteSector";
            this.InstituteSector.Size = new System.Drawing.Size(63, 17);
            this.InstituteSector.TabIndex = 4;
            this.InstituteSector.Text = "التصنيف";
            this.InstituteSector.UseVisualStyleBackColor = true;
            // 
            // InstituteAddress
            // 
            this.InstituteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstituteAddress.AutoSize = true;
            this.InstituteAddress.Location = new System.Drawing.Point(108, 103);
            this.InstituteAddress.Name = "InstituteAddress";
            this.InstituteAddress.Size = new System.Drawing.Size(57, 17);
            this.InstituteAddress.TabIndex = 3;
            this.InstituteAddress.Text = "العنوان";
            this.InstituteAddress.UseVisualStyleBackColor = true;
            // 
            // InstituteManager
            // 
            this.InstituteManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstituteManager.AutoSize = true;
            this.InstituteManager.Location = new System.Drawing.Point(79, 75);
            this.InstituteManager.Name = "InstituteManager";
            this.InstituteManager.Size = new System.Drawing.Size(86, 17);
            this.InstituteManager.TabIndex = 2;
            this.InstituteManager.Text = "مدير المنشأة";
            this.InstituteManager.UseVisualStyleBackColor = true;
            // 
            // InstituteCustomer
            // 
            this.InstituteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstituteCustomer.AutoSize = true;
            this.InstituteCustomer.Location = new System.Drawing.Point(88, 47);
            this.InstituteCustomer.Name = "InstituteCustomer";
            this.InstituteCustomer.Size = new System.Drawing.Size(77, 17);
            this.InstituteCustomer.TabIndex = 1;
            this.InstituteCustomer.Text = "اسم الزبون";
            this.InstituteCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.PlantLastVisit);
            this.groupBox2.Controls.Add(this.PlantContractType);
            this.groupBox2.Controls.Add(this.PlantDetails);
            this.groupBox2.Controls.Add(this.PlantLastStatus);
            this.groupBox2.Controls.Add(this.PlantContractor);
            this.groupBox2.Controls.Add(this.PlantInstituteName);
            this.groupBox2.Controls.Add(this.PlantTechPerson);
            this.groupBox2.Controls.Add(this.PlantName);
            this.groupBox2.Controls.Add(this.PlantCustomerName);
            this.groupBox2.Location = new System.Drawing.Point(192, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 252);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "وحدات المعالجة";
            // 
            // PlantLastVisit
            // 
            this.PlantLastVisit.AutoSize = true;
            this.PlantLastVisit.Enabled = false;
            this.PlantLastVisit.Location = new System.Drawing.Point(102, 217);
            this.PlantLastVisit.Name = "PlantLastVisit";
            this.PlantLastVisit.Size = new System.Drawing.Size(63, 17);
            this.PlantLastVisit.TabIndex = 8;
            this.PlantLastVisit.Text = "أخر زيارة";
            this.PlantLastVisit.UseVisualStyleBackColor = true;
            // 
            // PlantContractType
            // 
            this.PlantContractType.AutoSize = true;
            this.PlantContractType.Location = new System.Drawing.Point(97, 194);
            this.PlantContractType.Name = "PlantContractType";
            this.PlantContractType.Size = new System.Drawing.Size(68, 17);
            this.PlantContractType.TabIndex = 7;
            this.PlantContractType.Text = "نوع العقد";
            this.PlantContractType.UseVisualStyleBackColor = true;
            // 
            // PlantDetails
            // 
            this.PlantDetails.AutoSize = true;
            this.PlantDetails.Location = new System.Drawing.Point(74, 169);
            this.PlantDetails.Name = "PlantDetails";
            this.PlantDetails.Size = new System.Drawing.Size(91, 17);
            this.PlantDetails.TabIndex = 6;
            this.PlantDetails.Text = "تفاصيل الوحدة";
            this.PlantDetails.UseVisualStyleBackColor = true;
            // 
            // PlantLastStatus
            // 
            this.PlantLastStatus.AutoSize = true;
            this.PlantLastStatus.Location = new System.Drawing.Point(80, 144);
            this.PlantLastStatus.Name = "PlantLastStatus";
            this.PlantLastStatus.Size = new System.Drawing.Size(85, 17);
            this.PlantLastStatus.TabIndex = 5;
            this.PlantLastStatus.Text = "الحالة الأخيرة";
            this.PlantLastStatus.UseVisualStyleBackColor = true;
            // 
            // PlantContractor
            // 
            this.PlantContractor.AutoSize = true;
            this.PlantContractor.Location = new System.Drawing.Point(79, 94);
            this.PlantContractor.Name = "PlantContractor";
            this.PlantContractor.Size = new System.Drawing.Size(86, 17);
            this.PlantContractor.TabIndex = 4;
            this.PlantContractor.Text = "متعهد الوحدة";
            this.PlantContractor.UseVisualStyleBackColor = true;
            // 
            // PlantInstituteName
            // 
            this.PlantInstituteName.AutoSize = true;
            this.PlantInstituteName.Location = new System.Drawing.Point(77, 19);
            this.PlantInstituteName.Name = "PlantInstituteName";
            this.PlantInstituteName.Size = new System.Drawing.Size(88, 17);
            this.PlantInstituteName.TabIndex = 3;
            this.PlantInstituteName.Text = "اسم المنشأة";
            this.PlantInstituteName.UseVisualStyleBackColor = true;
            // 
            // PlantTechPerson
            // 
            this.PlantTechPerson.AutoSize = true;
            this.PlantTechPerson.Location = new System.Drawing.Point(72, 119);
            this.PlantTechPerson.Name = "PlantTechPerson";
            this.PlantTechPerson.Size = new System.Drawing.Size(93, 17);
            this.PlantTechPerson.TabIndex = 2;
            this.PlantTechPerson.Text = "مسؤول الوحدة";
            this.PlantTechPerson.UseVisualStyleBackColor = true;
            // 
            // PlantName
            // 
            this.PlantName.AutoSize = true;
            this.PlantName.Checked = true;
            this.PlantName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlantName.Location = new System.Drawing.Point(85, 69);
            this.PlantName.Name = "PlantName";
            this.PlantName.Size = new System.Drawing.Size(80, 17);
            this.PlantName.TabIndex = 0;
            this.PlantName.Text = "اسم الوحدة";
            this.PlantName.UseVisualStyleBackColor = true;
            // 
            // PlantCustomerName
            // 
            this.PlantCustomerName.AutoSize = true;
            this.PlantCustomerName.Location = new System.Drawing.Point(88, 44);
            this.PlantCustomerName.Name = "PlantCustomerName";
            this.PlantCustomerName.Size = new System.Drawing.Size(77, 17);
            this.PlantCustomerName.TabIndex = 1;
            this.PlantCustomerName.Text = "اسم الزبون";
            this.PlantCustomerName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "اختيار الحقول المراد عرضها:";
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(289, 314);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "اغلاق";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ColumnsSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(376, 349);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColumnsSelectForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اختيار الحقول";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox InstituteName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox InstituteSector;
        private System.Windows.Forms.CheckBox InstituteAddress;
        private System.Windows.Forms.CheckBox InstituteManager;
        private System.Windows.Forms.CheckBox InstituteCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox InstituteProfession;
        private System.Windows.Forms.CheckBox PlantContractType;
        private System.Windows.Forms.CheckBox PlantDetails;
        private System.Windows.Forms.CheckBox PlantLastStatus;
        private System.Windows.Forms.CheckBox PlantContractor;
        private System.Windows.Forms.CheckBox PlantInstituteName;
        private System.Windows.Forms.CheckBox PlantTechPerson;
        private System.Windows.Forms.CheckBox PlantCustomerName;
        private System.Windows.Forms.CheckBox PlantName;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.CheckBox PlantLastVisit;
    }
}