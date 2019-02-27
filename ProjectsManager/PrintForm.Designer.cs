namespace ProjectsManager
{
    partial class PrintForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PlantServiceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsmanagerDataSet = new ProjectsManager.projectsmanagerDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProgramsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProgramsViewTableAdapter = new ProjectsManager.projectsmanagerDataSetTableAdapters.ProgramsViewTableAdapter();
            this.PlantServiceViewTableAdapter = new ProjectsManager.projectsmanagerDataSetTableAdapters.PlantServiceViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PlantServiceViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsmanagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramsViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlantServiceViewBindingSource
            // 
            this.PlantServiceViewBindingSource.DataMember = "PlantServiceView";
            this.PlantServiceViewBindingSource.DataSource = this.projectsmanagerDataSet;
            // 
            // projectsmanagerDataSet
            // 
            this.projectsmanagerDataSet.DataSetName = "projectsmanagerDataSet";
            this.projectsmanagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "projectsmanagerDataSet_PlantServiceView";
            reportDataSource1.Value = this.PlantServiceViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectsManager.Reports.PlantServiceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportViewer1.Size = new System.Drawing.Size(599, 443);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProgramsViewBindingSource
            // 
            this.ProgramsViewBindingSource.DataMember = "ProgramsView";
            this.ProgramsViewBindingSource.DataSource = this.projectsmanagerDataSet;
            // 
            // ProgramsViewTableAdapter
            // 
            this.ProgramsViewTableAdapter.ClearBeforeFill = true;
            // 
            // PlantServiceViewTableAdapter
            // 
            this.PlantServiceViewTableAdapter.ClearBeforeFill = true;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 443);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "معاينة قبل الطباعة";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlantServiceViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsmanagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramsViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProgramsViewBindingSource;
        private projectsmanagerDataSet projectsmanagerDataSet;
        private ProjectsManager.projectsmanagerDataSetTableAdapters.ProgramsViewTableAdapter ProgramsViewTableAdapter;
        private System.Windows.Forms.BindingSource PlantServiceViewBindingSource;
        private ProjectsManager.projectsmanagerDataSetTableAdapters.PlantServiceViewTableAdapter PlantServiceViewTableAdapter;





    }
}