using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectsManager
{
    class DeleteItem
    {
        public static bool DeleteInstitute(int InstituteID) //Send to Recyclebin or Delete from DB
        {
            int RowsAffected = 0; //number of plants related to institute ID
            string InstituteName = "";
            bool DeletedInstitute = false;

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [institute] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants_view] where [institute_id]=" + InstituteID, Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        RowsAffected++;
                        InstituteName = Reader.GetString(0);
                    }
                Reader.Close();

                Command.CommandText = @"SELECT [del] From [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] where [id]=" + InstituteID;
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                        DeletedInstitute = Reader.GetBoolean(0);
                Reader.Close();
            }

            if (RowsAffected > 0 && !DeletedInstitute)
            {
                DialogResult DR = MessageBox.Show("توجد عدة وحدات مرتبطة بهذه المنشأة وبالتالي سيتم حذف الوحدات المرتبطة. هل تود المتابعة؟" + " \n " + "عناصر مرتبطة عدد" +  Convert.ToString(RowsAffected) + "\n" + InstituteName, "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (DR == DialogResult.Yes)
                    if (RecycleBinInstitute(InstituteID))
                    {
                        NotifyMessage nm = new NotifyMessage("تم حذف المنشأة \n" + InstituteName, NotifyMessage.NotifyMessageIcon.Recycle);
                        nm.Show();

                        return true;
                    }
            }
            if (RowsAffected <= 0 && !DeletedInstitute)
            {
                DialogResult DR = MessageBox.Show("هل أنت متأكد من حذف المنشأة؟ \n" + InstituteName, "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                    if (RecycleBinInstitute(InstituteID))
                        return true;
            }
            if (RowsAffected > 0 && DeletedInstitute)
            {
                DialogResult DR = MessageBox.Show("توجد عدة وحدات مرتبطة بهذه المنشأة وبالتالي سيتم حذف الوحدات المرتبطة. هل تود الحذف بشكل نهائي؟" + " \n " + Convert.ToString(RowsAffected) + " سجلات صيانة مرتبطة  \n" + InstituteName, "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (DR == DialogResult.Yes)
                    if (DeleteInstituteFromDB(InstituteID, InstituteName))
                        return true;
            }
            if (RowsAffected <= 0 && DeletedInstitute)
            {
                DialogResult DR = MessageBox.Show("هل أنت متأكد من حذف المنشأة بشكل نهائي؟ \n" + InstituteName, "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                    if (DeleteInstituteFromDB(InstituteID, InstituteName))
                        return true;
            }
            return false;
        }

        private static bool RecycleBinInstitute(int InstituteID) //Send Institute to Recyclebin
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] SET [del]='True' where [id]=" + Convert.ToString(InstituteID);
                Command.ExecuteNonQuery();

                Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] SET [del]='True' where [institute]=" + Convert.ToString(InstituteID);
                Command.ExecuteNonQuery();

                return true;
            }
        }

        private static bool DeleteInstituteFromDB(int InstituteID, string InstituteName) //Delete from DB
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandText = @"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] 
                where [id]=" + Convert.ToString(InstituteID);
                Command.ExecuteNonQuery();

                Command.CommandText = @"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] 
                where [institute]=" + Convert.ToString(InstituteID);
                Command.ExecuteNonQuery();

                NotifyMessage nm = new NotifyMessage("تم حذف المنشأة \n" + InstituteName,NotifyMessage.NotifyMessageIcon.Deleted);
                nm.Show();

                return true;
            }
        }
        
        public static bool DeletePlant(int PlantID)
        {
            bool DeletedPlant = false;
            string PlantName = "";

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [name],[del] From [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] where [id]=" + PlantID, Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        PlantName = Reader.GetString(0);
                        DeletedPlant = Reader.GetBoolean(1);
                        
                    }
                Reader.Close();

                if (!DeletedPlant)
                {
                    DialogResult DR = MessageBox.Show("هل أنت متأكد من حذف وحدة المعالجة؟ \n" + PlantName, "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        Command.CommandText = @"update [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] set [del]='True' where [id]=" + PlantID;
                        Command.ExecuteNonQuery();
                        NotifyMessage nw = new NotifyMessage("تم حذف الوحدة" + "\n" + PlantName,NotifyMessage.NotifyMessageIcon.Recycle);
                        nw.Show();
                        return true;
                    }
                }
                else if (DeletedPlant)
                {
                    DialogResult DR = MessageBox.Show("هل أنت متأكد من حذف وحدة المعالجة بشكل نهائي؟ \n" + PlantName, "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        Command.CommandText = @"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] WHERE [id]=" + PlantID;
                        Command.ExecuteNonQuery();
                        NotifyMessage nw = new NotifyMessage("تم حذف الوحدة" + "\n" + PlantName,NotifyMessage.NotifyMessageIcon.Deleted);
                        nw.Show();
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool DeleteProgram(int ProgramID)
        {
            int RowsAffected = 0;

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT * FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantService] where ([ServiceText] is not null or [ServiceText]!='' or [ServiceNote] is not null or [ServiceNote]!='') and [ProgramID]=" + ProgramID, Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                        RowsAffected++;
            }
            if (RowsAffected > 0)
            {
                DialogResult DR = MessageBox.Show("هذا البرنامج مرتبط بزيارات لها تقارير صيانة , إذا تم حذف هذا البرنامج لن يمكنك استعادة تقارير الصيانة المرتبطة بهذه الزيارة. هل تود المتابعة؟" + " \n " + Convert.ToString(RowsAffected) + " سجلات صيانة مرتبطة ", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (DR == DialogResult.Yes)
                    if (ExecuteDeleteProgram(ProgramID))
                        return true;
            }
            else
            {
                DialogResult DR = MessageBox.Show("هل أنت متأكد من حذف البرنامج؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                    if (ExecuteDeleteProgram(ProgramID))
                        return true;
            }
            return false;
        }

        private static bool ExecuteDeleteProgram(int ProgramID)
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandText = @"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[PlantService]
                WHERE [ProgramID]=" + ProgramID;
                Command.ExecuteNonQuery();
                Command.CommandText = @"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[Programs]
                WHERE [id]=" + ProgramID;
                Command.ExecuteNonQuery();
                
                NotifyMessage nm = new NotifyMessage("تم حذف البرنامج",NotifyMessage.NotifyMessageIcon.Deleted);
                nm.Show();

                return true;
            }
        }

        public static bool DeleteCustomer(int CustomerID)
        {
            bool DeletedCustomer = false;
            int RelatedInstitutes = 0;
            string CustomerName = "";

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"Select * FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] WHERE [customer]=" + CustomerID, Connection);
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                        RelatedInstitutes++;
                Reader.Close();

                Command.CommandText = @"Select [name],[del] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] where [id]=" + CustomerID;
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        CustomerName = Reader.GetString(0);
                        DeletedCustomer = Reader.GetBoolean(1);
                    }
                Reader.Close();

                if (RelatedInstitutes > 0 && !DeletedCustomer)
                {
                    DialogResult DR = MessageBox.Show("توجد منشأة/منشأت مرتبطة بهذا الزبون وبالتالي سيتم حذف كافة العناصر التابعة. هل تود المتابعة؟" + " \n " + "العناصر المرتبطة عدد" + Convert.ToString(RelatedInstitutes) + "\n" + CustomerName, "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                    if (DR == DialogResult.Yes)
                        if (RecycleBinCustomer(CustomerID))
                        {
                            NotifyMessage nm = new NotifyMessage("تم حذف إرسال الزبون والعناصر التابعة إلى العناصر المحذوفة \n" + CustomerName, NotifyMessage.NotifyMessageIcon.Recycle);
                            nm.Show();
                            return true;
                        }
                }
                if (RelatedInstitutes > 0 && DeletedCustomer)
                {
                    DialogResult DR = MessageBox.Show("توجد منشأة/منشأت مرتبطة بهذا الزبون وبالتالي سيتم حذف  كافة العناصر التابعة بشكل نهائي. هل تود المتابعة؟" + " \n " + Convert.ToString(RelatedInstitutes) + " منشأت مرتبطة  \n" + CustomerName, "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                    if (DR == DialogResult.Yes)
                        if (DeleteCustomerFromDB(CustomerID))
                        {
                            NotifyMessage nm = new NotifyMessage("تم حذف الزبون والعناصر التابعة بشكل نهائي \n" + CustomerName, NotifyMessage.NotifyMessageIcon.Recycle);
                            nm.Show();
                            return true;
                        }
                }
                if (RelatedInstitutes == 0 && !DeletedCustomer)
                {
                    DialogResult DR = MessageBox.Show("سيتم حذف الزبون. هل تود المتابعة ؟" + "\n" + CustomerName, "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                    if (DR == DialogResult.Yes)
                        if (RecycleBinCustomer(CustomerID))
                        {
                            NotifyMessage nm = new NotifyMessage("تم حذف المنشأة \n" + CustomerName, NotifyMessage.NotifyMessageIcon.Recycle);
                            nm.Show();
                            return true;
                        }
                }
                if (RelatedInstitutes == 0 && DeletedCustomer)
                {
                    DialogResult DR = MessageBox.Show("سيتم حذف الزبون بشكل نهائي. هل تود المتابعة؟" + "\n" + CustomerName, "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                    if (DR == DialogResult.Yes)
                        if (DeleteCustomerFromDB(CustomerID))
                        {
                            NotifyMessage nm = new NotifyMessage("تم حذف الزبون \n" + CustomerName, NotifyMessage.NotifyMessageIcon.Recycle);
                            nm.Show();
                            return true;
                        }
                }
            }
            return false;
        }

        private static bool RecycleBinCustomer(int CustomerID) //Send to RecycleBin
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] SET [del]=1 where [id]=" + CustomerID.ToString();
                Command.ExecuteNonQuery();

                List<int> RelatedInstitutes = new List<int>(); //Get Related Institutes ID(s) to current customer
                Command.CommandText = @"Select [id] from [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] where [customer]=" + CustomerID.ToString();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                        RelatedInstitutes.Add(Reader.GetInt32(0));
                Reader.Close();

                Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] SET [del]=1 where [customer]=" + CustomerID.ToString();
                Command.ExecuteNonQuery();

                foreach (int InstituteID in RelatedInstitutes)
                {
                    Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] SET [del]=1 where [institute]=" + InstituteID.ToString();
                    Command.ExecuteNonQuery();
                }
                return true;
            }
        }

        private static bool DeleteCustomerFromDB(int CustomerID) //Delete from Database - no restore
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = @"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[customers] where [id]=" + CustomerID.ToString();
                Command.ExecuteNonQuery();

                List<int> RelatedInstitutes = new List<int>();         //Get Related Institutes ID(s) to current customer
                Command.CommandText = @"Select [id] from [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] where [customer]=" + CustomerID.ToString();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                        RelatedInstitutes.Add(Reader.GetInt32(0));
                Reader.Close();

                Command.CommandText = @"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[institutes] where [customer]=" + CustomerID.ToString();
                Command.ExecuteNonQuery();

                foreach (int InstituteID in RelatedInstitutes)
                {
                    Command.CommandText = @"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[plants] where [institute]=" + InstituteID.ToString();
                    Command.ExecuteNonQuery();
                }
                return true;
            }

        }
    }
}
