using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace test
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public string source;
        private TableLogOnInfo LogInfo = new TableLogOnInfo();

        private void Form8_Load(object sender, EventArgs e)
        {


            LogInfo.ConnectionInfo.ServerName = Settings1.Default.Server;
            LogInfo.ConnectionInfo.DatabaseName = Settings1.Default.Database;
            LogInfo.ConnectionInfo.IntegratedSecurity = true;

            active_plants_report1.Database.Tables[0].ApplyLogOnInfo(LogInfo);

            if (source == "active plants")
                crystalReportViewer1.ReportSource = active_plants_report1;
            if (source == "institutes")
                crystalReportViewer1.ReportSource = institutes_view_report1;
            if (source == "plants")
                crystalReportViewer1.ReportSource = plants_view_report1;

            active_plants_report1.Refresh();
            plants_view_report1.Refresh();
            institutes_view_report1.Refresh();
        }
    }
}
