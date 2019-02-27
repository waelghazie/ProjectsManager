using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class ColumnsSelectForm : Form
    {
        public ColumnsSelectForm()
        {
            InitializeComponent();
        }

         String InstituteColumnFilter;
         String PlantColumnFilter;


        private void Button1_Click(object sender, EventArgs e)
        {
            if (InstituteName.Checked)
                InstituteColumnFilter += @",[name] as [اسم المنشأة]";
            if (InstituteCustomer.Checked)
                InstituteColumnFilter += @",[customer] as [الزبون]";
            if (InstituteManager.Checked)
                InstituteColumnFilter += @",[manager] as [مدير المنشأة]";
            if(InstituteAddress.Checked)
                InstituteColumnFilter += @",[address] as [العنوان]";
            if(InstituteSector.Checked)
                InstituteColumnFilter += @",[Sector] as [التصنيف]";
            if(InstituteProfession.Checked)
                InstituteColumnFilter += @",[Profession] as [الاختصاص]";

            

            if (PlantCustomerName.Checked)
                PlantColumnFilter += @",[customer] as [الزبون]";
            if (PlantInstituteName.Checked)
                PlantColumnFilter += @",[institute] as [المنشأة]";
            if(PlantName.Checked)
                PlantColumnFilter += @",[plant] as [اسم الوحدة]";
            if(PlantContractor.Checked)
                PlantColumnFilter += @",[contractor] as [متعهد الوحدة]";
            if(PlantTechPerson.Checked)
                PlantColumnFilter += @",[technician] as [مشرف الوحدة]";
            if(PlantLastStatus.Checked)
                PlantColumnFilter += @",[LastStatus] as [الحالة الأخيرة]";
            if(PlantDetails.Checked)
                PlantColumnFilter += @",[PlantDetails] as [تفاصيل الوحدة]";
            if (PlantContractType.Checked)
                PlantColumnFilter += @",[contract_type] as [نوع العقد]";
            //if (PlantLastVisit.Checked)
             //   PlantColumnFilter += @",[LastVisit] as [أخر زيارة]";

            Settings1.Default.InstituteColumnFilter = this.InstituteColumnFilter;
            Settings1.Default.PlantColumnFilter = this.PlantColumnFilter;

            Settings1.Default.Save();
        }
    }
}
