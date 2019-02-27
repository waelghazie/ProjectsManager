using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using Microsoft.Reporting;

namespace ProjectsManager
{
    public partial class PrintForm : Form
    {
        public PrintForm(int ProgramID, List<ReportParameter> parameters)
        {
            this.parameters = parameters;
            this.ProgramID = ProgramID;
            
            InitializeComponent();
        }

        int ProgramID;
        List<ReportParameter> parameters;

        private void PrintForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();

                    //Print Specific PlantServiceView(s) related to program 
                    SqlCommand Command = new SqlCommand(@"SELECT [InstituteName],[PlantName],[VisitText],[VisitNote],[address],[CustomerName],[RecordOrderNO],[VisitID]  
                    FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantServiceView] where [ProgramID]=" + ProgramID, Connection);
                    {
                        SqlDataAdapter Adapter = new SqlDataAdapter(Command);

                        Adapter.Fill(projectsmanagerDataSet, "PlantServiceView");

                        
                        this.reportViewer1.LocalReport.SetParameters(parameters);
                        this.reportViewer1.RefreshReport();
                    }
                }
            }
            catch (Exception exp)
            { MessageBox.Show(exp.Message); }
        }
    }
}
