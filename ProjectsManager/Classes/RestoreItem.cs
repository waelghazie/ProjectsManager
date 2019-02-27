using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectsManager
{
    class RestoreItem
    {
        public static bool RestoreInstitute(int InstituteID)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                DialogResult DR = MessageBox.Show("هل تريد استعادة هذه المنشأة والوحدات المرتبطة بها ؟", "استعادة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DR == DialogResult.Yes)
                {
                    SqlCommand Command = new SqlCommand(@"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] SET [del]='False' where [id]=" + InstituteID, Connection);
                    Command.ExecuteNonQuery();

                    Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] SET [del]='False' where [institute]=" + InstituteID;
                    Command.ExecuteNonQuery();

                    NotifyMessage nm = new NotifyMessage("تمت استعادة المنشأة \n",NotifyMessage.NotifyMessageIcon.Restored);
                    nm.Show();

                    return true;
                }
                return false;
            }
        }

        public static bool RestorePlant(int PlantID)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                DialogResult DR = MessageBox.Show("هل تريد استعادة هذه الوحدة ؟", "استعادة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DR == DialogResult.Yes)
                {
                    SqlCommand Command = new SqlCommand(@"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] SET [del]='False' where [id]=" + PlantID, Connection);
                    Command.ExecuteNonQuery();

                    NotifyMessage nm = new NotifyMessage("تمت استعادة الوحدة \n",NotifyMessage.NotifyMessageIcon.Restored);
                    nm.Show();

                    return true;
                }
                return false;
            }
        }

        public static bool RestoreCustomer(int CustomerID)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                DialogResult DR = MessageBox.Show("سيتم استعادة هذا الزبون من الحذف وكافة العناصر المرتبطة، هل تود المتابعة؟", "استعادة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DR == DialogResult.Yes)
                {
                    SqlCommand Command = new SqlCommand(@"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] SET [del]=0 where [id]=" + CustomerID, Connection);
                    Command.ExecuteNonQuery();

                    List<int> RelatedInstitutes = new List<int>();         //Get Related Institutes ID(s) to current customer
                    Command.CommandText = @"Select [id] from [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] where [customer]=" + CustomerID.ToString();
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                            RelatedInstitutes.Add(Reader.GetInt32(0));
                    Reader.Close();

                    Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] SET [del]=0 where [customer]=" + CustomerID.ToString();
                    Command.ExecuteNonQuery();

                    foreach (int InstituteID in RelatedInstitutes)
                    {
                        Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] SET [del]=0 where [institute]=" + InstituteID;
                        Command.ExecuteNonQuery();
                    }

                    NotifyMessage nm = new NotifyMessage("تمت استعادة الزبون وكافة العناصر المرتبطة \n", NotifyMessage.NotifyMessageIcon.Restored);
                    nm.Show();

                    return true;
                }
                return false;
            }


        }



    }
}
