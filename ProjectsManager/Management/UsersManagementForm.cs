using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.DirectoryServices.AccountManagement;

namespace ProjectsManager
{
    public partial class UsersManagementForm : Form
    {
        public UsersManagementForm()
        {
            InitializeComponent();
        }

        DataTable Data;

        User SelectedUser;
        bool NewDomainUser = false;
        bool NewUser = false;

        private void UsersManagement_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            Data = new DataTable();
            SelectedUser = new User();

            //استخراج معلومات اتصال المجال من جدول اعدادات البرنامج في قاعدة البيانات
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [DomainController],[OU],[Domain],[DomainSuffix],[Username],[Password] FROM [" + Settings1.Default.DatabaseName + "].[dbo].[appsettings]", Connection);
                SqlDataReader Reader;
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            DomainControllerTextBox.Text = Reader.GetString(0);
                        if (!Reader.IsDBNull(1))
                            OUTextBox.Text = Reader.GetString(1);
                        if (!Reader.IsDBNull(2))
                            DomainTextBox.Text = Reader.GetString(2);
                        if (!Reader.IsDBNull(3))
                            DomainSuffixTextBox.Text = Reader.GetString(3);
                        if (!Reader.IsDBNull(4))
                            DomainUsernameTextBox.Text = Reader.GetString(4);
                        if (!Reader.IsDBNull(5))
                            DomainPasswordTextBox.Text = Encryption.Decrypt(Reader.GetString(5));
                    }
            }

            RefreshDGV();
        }

        private void LoadDataForSelectedUser()
        {
            if (dataGridView1.DataSource != null && dataGridView1.SelectedCells.Count > 0)
            {
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();
                    SqlCommand Command = new SqlCommand(@"SELECT [id],[displayname],[username],[password],[read],[modify],[create],[delete],[ManageUsers],[isdomainuser] 
                    FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[users] where [id]=" + dataGridView1.SelectedCells[0].Value, Connection);
                    SqlDataReader Reader;
                    Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                        while (Reader.Read())
                        {
                            if (!Reader.IsDBNull(0))
                                SelectedUser.UserID = Reader.GetInt32(0);
                            if (!Reader.IsDBNull(1))
                                SelectedUser.DisplayName = Reader.GetString(1);
                            if (!Reader.IsDBNull(2))
                                SelectedUser.UserName = Reader.GetString(2);
                            if (!Reader.IsDBNull(3))
                            {
                                PasswordTextBox.Text = Encryption.Decrypt(Reader.GetString(3));
                                ConfirmPasswordTextBox.Text = Encryption.Decrypt(Reader.GetString(3));
                            }
                            if (!Reader.IsDBNull(4))
                                if (Reader.GetBoolean(4))
                                    ReadCheckBox.Checked = true;
                                else
                                    ReadCheckBox.Checked = false;
                            if (!Reader.IsDBNull(5))
                                if (Reader.GetBoolean(5))
                                    ModifyCheckBox.Checked = true;
                                else
                                    ModifyCheckBox.Checked = false;
                            if (!Reader.IsDBNull(6))
                                if (Reader.GetBoolean(6))
                                    CreateCheckBox.Checked = true;
                                else
                                    CreateCheckBox.Checked = false;
                            if (!Reader.IsDBNull(7))
                                if (Reader.GetBoolean(7))
                                    DeleteCheckBox.Checked = true;
                                else
                                    DeleteCheckBox.Checked = false;
                            if (!Reader.IsDBNull(8))
                                if (Reader.GetBoolean(8))
                                    ManageCheckBox.Checked = true;
                                else
                                    ManageCheckBox.Checked = false;
                            if (!Reader.IsDBNull(9))
                                SelectedUser.IsDomainUser = Reader.GetBoolean(9);
                        }

                    DispalyNameTextBox.Text = SelectedUser.DisplayName;
                    UserNameTextBox.Text = SelectedUser.UserName;
                }
            }
        }

        private void EnableEditing()
        {
            ReadCheckBox.Enabled = true;
            ModifyCheckBox.Enabled = true;
            CreateCheckBox.Enabled = true;
            DeleteCheckBox.Enabled = true;
            ManageCheckBox.Enabled = true;

            SaveChangesButton.Visible = true;
            CancelChangesButton.Visible = true;
            ModifyLinkLabel.Enabled = false;
            NewUserButton.Enabled = false;
            DeleteUserButton.Enabled = false;

            if (SelectedUser.IsDomainUser)
            {
                DispalyNameTextBox.Visible = false; UserNameTextBox.Visible = false; PasswordTextBox.Visible = false; ConfirmPasswordTextBox.Visible = false;
                label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false;
                
            }
            else if (!SelectedUser.IsDomainUser)
            {
                DispalyNameTextBox.Visible = true; UserNameTextBox.Visible = true; PasswordTextBox.Visible = true; ConfirmPasswordTextBox.Visible = true;
                label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true;
            }
            dataGridView1.Enabled = false;
        }

        private void DisableEditing()
        {
            ReadCheckBox.Enabled = false;
            ModifyCheckBox.Enabled = false;
            CreateCheckBox.Enabled = false;
            DeleteCheckBox.Enabled = false;
            ManageCheckBox.Enabled = false;

            SaveChangesButton.Visible = false;
            CancelChangesButton.Visible = false;
            ModifyLinkLabel.Enabled = true;
            NewUserButton.Enabled = true;
            DeleteUserButton.Enabled = true;
            
            DispalyNameTextBox.Visible = false; UserNameTextBox.Visible = false; PasswordTextBox.Visible = false; ConfirmPasswordTextBox.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            dataGridView1.Enabled = true;
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //تعديل
            if (SelectedUser.UserName != "admin")
            {
                EnableEditing();
            }
            else
                MessageBox.Show("لا يمكن تعديل المستخدم : admin", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //حفظ

            if (SelectedUser.IsDomainUser)
            {
                SaveUserData();
                DisableEditing();
                RefreshDGV();
            }
            else if (!SelectedUser.IsDomainUser)
            {
                if (DispalyNameTextBox.Text == "" || UserNameTextBox.Text == "" || PasswordTextBox.Text == "" || PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
                { MessageBox.Show("يرجى تعبئة كافة البيانات والتأكد من مطابقة كلمة السر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    if (UserNameTextBox.Text.ToLower() == "admin" || DispalyNameTextBox.Text.ToLower() == "admin")
                    { MessageBox.Show("يرجى اختيار اسم مختلف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else
                    {
                        SaveUserData();
                        DisableEditing();
                    }
                    RefreshDGV();
                }
            }
        }

        private void SaveUserData()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                if (NewUser) //يوزر جديد
                {
                    Command.CommandText = @"insert into [" + Settings1.Default.DatabaseName + @"].[dbo].[users] 
                    ([displayname],[username],[password],[read],[modify],[create],[delete],[ManageUsers],[isdomainuser])  values 
                    (@displayname,@username,@password,@read,@modify,@create,@delete,@ManageUsers,0)";

                    Command.Parameters.Add("@displayname", SqlDbType.NVarChar).Value = DispalyNameTextBox.Text;
                    Command.Parameters.Add("@username", SqlDbType.NVarChar).Value = UserNameTextBox.Text;
                    Command.Parameters.Add("@password", SqlDbType.NVarChar).Value = Encryption.Encrypt(PasswordTextBox.Text);
                    Command.Parameters.Add("@read", SqlDbType.Bit).Value = ReadCheckBox.Checked;
                    Command.Parameters.Add("@modify", SqlDbType.Bit).Value = ModifyCheckBox.Checked;
                    Command.Parameters.Add("@create", SqlDbType.Bit).Value = CreateCheckBox.Checked;
                    Command.Parameters.Add("@delete", SqlDbType.Bit).Value = DeleteCheckBox.Checked;
                    Command.Parameters.Add("@ManageUsers", SqlDbType.Bit).Value = ManageCheckBox.Checked;
                    Command.Parameters.Add("@id", SqlDbType.Int).Value = SelectedUser.UserID;

                    NewUser = false;
                }
                else     //يوزر قديم 
                {
                    Command.CommandText = @"UPDATE [" + Settings1.Default.DatabaseName + @"].[dbo].[users] SET 
                    [displayname]=@displayname, [username]=@username, [password]=@password, 
                    [read]=@read, [modify]=@modify ,[create]=@create, [delete]=@delete, [ManageUsers]=@ManageUsers
                    where [id]=" + SelectedUser.UserID;
                    
                    Command.Parameters.Add("@displayname",SqlDbType.NVarChar).Value = DispalyNameTextBox.Text;
                    Command.Parameters.Add("@username",SqlDbType.NVarChar).Value = UserNameTextBox.Text;
                    Command.Parameters.Add("@password",SqlDbType.NVarChar).Value = Encryption.Encrypt(PasswordTextBox.Text);
                    Command.Parameters.Add("@read",SqlDbType.Bit).Value = ReadCheckBox.Checked;
                    Command.Parameters.Add("@modify",SqlDbType.Bit).Value = ModifyCheckBox.Checked;
                    Command.Parameters.Add("@create",SqlDbType.Bit).Value = CreateCheckBox.Checked;
                    Command.Parameters.Add("@delete",SqlDbType.Bit).Value = DeleteCheckBox.Checked;
                    Command.Parameters.Add("@ManageUsers",SqlDbType.Bit).Value = ManageCheckBox.Checked;
                    Command.Parameters.Add("@id",SqlDbType.Int).Value = SelectedUser.UserID;
                }

                Command.ExecuteNonQuery();
                Command.Parameters.Clear();
                NotifyMessage nm = new NotifyMessage("تم الحفظ بنجاح", NotifyMessage.NotifyMessageIcon.Saved);
                nm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //الغاء
            NewUser = false;

            DisableEditing();            
            LoadDataForSelectedUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //جديد
            NewUser = true;

            EnableEditing();

            ReadCheckBox.Checked = false;
            ModifyCheckBox.Checked = false; 
            CreateCheckBox.Checked = false;
            CreateCheckBox.Checked = false;
            DeleteCheckBox.Checked = false;
            ManageCheckBox.Checked = false;
            DispalyNameTextBox.Text = "";
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";
        }

        private void RefreshDGV()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                dataGridView1.DataSource = null;
                Data.Clear();

                SqlCommand Command = new SqlCommand(@"SELECT [id] ,[displayname] as [الاسم الكامل] ,[username] AS [اسم المستخدم],[sid] AS [SID],[userprincipalname] as [User Principal Name],[isdomainuser] as [مستخدم مجال؟]
                FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[users]", Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(Data);
                dataGridView1.DataSource = Data;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //حذف

            if (Convert.ToString(dataGridView1.SelectedCells[2].Value) != "admin")
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    DialogResult DR = MessageBox.Show("هل أنت متأكد من حذف المستخدم:\n" + dataGridView1.SelectedCells[2].Value, "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        using (SqlConnection Connection = AppConnection.GetConnection())
                        {
                            Connection.Open();
                            SqlCommand Command = new SqlCommand(@"DELETE FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[users] WHERE [id]=" + dataGridView1.SelectedCells[0].Value, Connection);
                            Command.ExecuteNonQuery();
                            MessageBox.Show("تم حذف المستخدم \n" + dataGridView1.SelectedCells[2].Value);
                        }
                    }
                }
            }
            else
            { MessageBox.Show("لا يمكن حذف المستخدم : admin", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            
            RefreshDGV();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Focused)
                LoadDataForSelectedUser();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Focused)
                ConfirmPasswordTextBox.Text = "";
        }

        private void ConnectToADbutton_Click(object sender, EventArgs e)
        {
            if (DomainControllerTextBox.Text != "" && OUTextBox.Text != "" && DomainTextBox.Text != "" && DomainSuffixTextBox.Text != "" && DomainUsernameTextBox.Text != "" && DomainPasswordTextBox.Text != "")
            {
                progressBar1.Visible = true;
                ConnectToADbutton.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
            }
            else
            { MessageBox.Show("يرجى ادخال كافة البيانات"); }
        }

        private void ConnecttoAD()
        {
            //Reader.Close();
            ConnectToADbutton.Enabled = false;
            SaveDomainInfoButton.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void SaveADSettings()
        {
            //حفظ اعدادات الاتصال بالمجال
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand(
                @"UPDATE [projectsmanager].[dbo].[appsettings] SET 
                [DomainController] = @DomainController,[OU] = @OU,[Domain] = @Domain,[DomainSuffix] = @DomainSuffix
                ,[Username] = @Username,[Password] = @Password WHERE [DatabaseName] = " + Settings1.Default.DatabaseName, Connection);
                Command.Parameters.Add("@DomainController", SqlDbType.NVarChar).Value = DomainControllerTextBox.Text;
                Command.Parameters.Add("@OU", SqlDbType.NVarChar).Value = OUTextBox.Text;
                Command.Parameters.Add("@Domain", SqlDbType.NVarChar).Value = DomainTextBox.Text;
                Command.Parameters.Add("@DomainSuffix", SqlDbType.NVarChar).Value = DomainSuffixTextBox.Text;
                Command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = DomainUsernameTextBox.Text;
                Command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Encryption.Encrypt(DomainPasswordTextBox.Text);
                Command.ExecuteNonQuery();
                Command.Parameters.Clear();
                MessageBox.Show("تم حفظ معلومات المجال في قاعدة البيانات", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // create your domain context and define the OU container to search in
                PrincipalContext ctx = new PrincipalContext(ContextType.Domain, DomainControllerTextBox.Text, "OU=" + OUTextBox.Text + ",DC=" + DomainTextBox.Text + ",DC=" + DomainSuffixTextBox.Text, DomainUsernameTextBox.Text, DomainPasswordTextBox.Text);

                // define a "query-by-example" principal - here, we search for a UserPrincipal (user)
                UserPrincipal qbeUser = new UserPrincipal(ctx);

                // create your principal searcher passing in the QBE principal    
                PrincipalSearcher srch = new PrincipalSearcher(qbeUser);

                
                using (SqlConnection Connection = AppConnection.GetConnection())
                {
                    Connection.Open();

                    // find all matches
                    foreach (var found in srch.FindAll())
                    {
                        //هل المستخدم المقروء من المجال موجود مسبقا ضمن جدول المستخدمين ضمن قاعدة البيانات

                        SqlCommand Command = new SqlCommand(@"SELECT [id] FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[users] where [sid]='" + found.Sid + "'", Connection);
                        SqlDataReader Reader;
                        Reader = Command.ExecuteReader();
                        if (!Reader.HasRows)            //المستخدم غير موجود 
                        { NewDomainUser = true; }
                        Reader.Close();

                        if (NewDomainUser)
                        {
                            Command.CommandText = @"insert into [" + Settings1.Default.DatabaseName + @"].[dbo].[users] 
                            ([displayname],[username],[read],[modify],[create],[delete],[ManageUsers],[sid],[userprincipalname],[isdomainuser])  values 
                            (@displayname,@username,@read,@modify,@create,@delete,@ManageUsers,@sid,@userprincipalname,@isdomainuser)";

                            Command.Parameters.Add("@displayname", SqlDbType.NVarChar).Value = found.DisplayName.Replace("'", "''");
                            Command.Parameters.Add("@username", SqlDbType.NVarChar).Value = found.SamAccountName.Replace("'", "''");
                            Command.Parameters.Add("@read", SqlDbType.Bit).Value = 1;
                            Command.Parameters.Add("@modify", SqlDbType.Bit).Value = 0;
                            Command.Parameters.Add("@create", SqlDbType.Bit).Value = 0;
                            Command.Parameters.Add("@delete", SqlDbType.Bit).Value = 0;
                            Command.Parameters.Add("@ManageUsers", SqlDbType.Bit).Value = 0;
                            Command.Parameters.Add("@sid", SqlDbType.NVarChar).Value = found.Sid;
                            Command.Parameters.Add("@userprincipalname", SqlDbType.NVarChar).Value = found.UserPrincipalName.Replace("'", "''");
                            Command.Parameters.Add("@isdomainuser", SqlDbType.Bit).Value = 1;

                            Command.ExecuteNonQuery();
                            NewDomainUser = false;
                            MessageBox.Show("تمت اضافة المستخدم\n" + found.DisplayName + "\n" + "من المجال إلى قاعدة بيانات البرنامج" + "\n يرجى تعديل صلاحيات المستخدم", "اضافة مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception exp)
            { MessageBox.Show("Error\n" + exp.Message + "\n" + exp.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
            ConnectToADbutton.Enabled = true;
            RefreshDGV();
        }

        private void SaveADinfo_Click(object sender, EventArgs e)
        {
            SaveADSettings();
        }



    }
}
