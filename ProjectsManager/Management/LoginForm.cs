using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace ProjectsManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public User user;

        public bool Authorized = false;
        public bool CloseApplication = false;

        int LoginTries;

        const int AW_HOR_POSITIVE = 1;
        const int AW_HOR_NEGATIVE = 2;
        const int AW_VER_POSITIVE = 4;
        const int AW_VER_NEGATIVE = 8;
        const int AW_HIDE = 65536;
        const int AW_ACTIVATE = 131072;
        const int AW_SLIDE = 262144;
        const int AW_BLEND = 524288;
        const int AW_CENTER = 0x00000010;

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        protected override void OnLoad(EventArgs e)
        {
            //Animate Window
            base.OnLoad(e);
            AnimateWindow(Handle, 500, AW_BLEND);
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            PasswordTextBox.Text = "";
            user = new User();
            Authorized = false;
            label5.Text = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName.ToUpper();
            label4.Text = "";
            LoginTries = 0;
            UserNameTextBox.Text = Settings1.Default.ApplicationUsername;

            if (Settings1.Default.LoginAsADUser)
                if (LoginAsADUser())
                    Close();
            
            DatabaseLabel.Text = Settings1.Default.DatabaseName;
            label6.ForeColor = Color.WhiteSmoke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAsNormalUser();
        }

        private void LoginAsNormalUser()
        {
            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[username],[password],[read],[modify],[create],[delete],[ManageUsers],[displayname] 
                FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[users] where [username]='" + UserNameTextBox.Text + "' and [isdomainuser]=0", Connection);
                SqlDataReader Reader;
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            user.UserID = Reader.GetInt32(0);
                        if (!Reader.IsDBNull(1))
                            user.UserName = Reader.GetString(1);
                        if (!Reader.IsDBNull(2))
                            user.Password = Encryption.Decrypt(Reader.GetString(2));
                        if (!Reader.IsDBNull(3))
                            user.ReadPermission = Reader.GetBoolean(3);
                        if (!Reader.IsDBNull(4))
                            user.ModifyPermission = Reader.GetBoolean(4);
                        if (!Reader.IsDBNull(5))
                            user.CreatePermission = Reader.GetBoolean(5);
                        if (!Reader.IsDBNull(6))
                            user.DeletePermission = Reader.GetBoolean(6);
                        if (!Reader.IsDBNull(7))
                            user.ManageUsers = Reader.GetBoolean(7);
                        if (!Reader.IsDBNull(8))
                            user.DisplayName = Reader.GetString(8);
                    }

                if (user.UserName == UserNameTextBox.Text)
                {
                    if (user.Password == PasswordTextBox.Text)
                    {
                        this.Authorized = true;

                        //Developer Options
                        Settings1.Default.ApplicationUsername = UserNameTextBox.Text;
                        Settings1.Default.ApplicationPassword = Encryption.Encrypt(PasswordTextBox.Text);
                        Settings1.Default.Save();

                        Close();
                        PasswordTextBox.Text = "";
                        return;
                    }
                    else
                    {
                        label4.Text = "كلمة السر خطأ";
                        PasswordTextBox.Focus();
                    }
                }
                else
                {
                    label4.Text = "اسم المستخدم خطأ أو غير موجود";
                    UserNameTextBox.Focus();
                }

                LoginTries++;
                if (LoginTries >= 10)
                { Authorized = false; Close(); }
                PasswordTextBox.Text = "";
            }
        }

        private bool LoginAsADUser()            //Login as Active Directory User
        {
            //بحث عن معرف المستخدم المطابق لمعرف موجود ضمن جدول المستخدمين في قاعدة البيانات
            //search for user in DB who has SID equals current windows SID

            //get current user SID from local machine - Windows // using System.Security.Principal;
            WindowsIdentity WindowsUser = WindowsIdentity.GetCurrent();
            SecurityIdentifier SID = WindowsUser.User;

            using (SqlConnection Connection = AppConnection.GetConnection())
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT [id],[username],[password],[read],[modify],[create],[delete],[ManageUsers],[displayname] 
                FROM [" + Settings1.Default.DatabaseName + @"].[dbo].[users] where [sid]='" + Convert.ToString(SID) + "'", Connection);
                SqlDataReader Reader;
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        if (!Reader.IsDBNull(0))
                            user.UserID = Reader.GetInt32(0);
                        if (!Reader.IsDBNull(1))
                            user.UserName = Reader.GetString(1);
                        if (!Reader.IsDBNull(2))
                            user.Password = Encryption.Decrypt(Reader.GetString(2));
                        if (!Reader.IsDBNull(3))
                            user.ReadPermission = Reader.GetBoolean(3);
                        if (!Reader.IsDBNull(4))
                            user.ModifyPermission = Reader.GetBoolean(4);
                        if (!Reader.IsDBNull(5))
                            user.CreatePermission = Reader.GetBoolean(5);
                        if (!Reader.IsDBNull(6))
                            user.DeletePermission = Reader.GetBoolean(6);
                        if (!Reader.IsDBNull(7))
                            user.ManageUsers = Reader.GetBoolean(7);
                        if (!Reader.IsDBNull(8))
                            user.DisplayName = Reader.GetString(8);
                    }
                    this.Authorized = true;
                    Settings1.Default.LoginAsADUser = true; 
                    Settings1.Default.Save(); 
                    return true;
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على المستخدم ضمن قاعدة البيانات ", "لا يمكن تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                LoginAsNormalUser();

            label5.Text = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName.ToUpper();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                LoginAsNormalUser();

            label5.Text = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseApplication = true;
            Close();
        }

        private void label6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PasswordTextBox.Text = Encryption.Decrypt(Settings1.Default.ApplicationPassword);

            LoginAsNormalUser();
        }

        private void LoginWindow_Shown(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
                UserNameTextBox.Focus();
            else
                PasswordTextBox.Focus();

            if (Settings1.Default.AutoLogin)
            {
                PasswordTextBox.Text = Encryption.Decrypt(Settings1.Default.ApplicationPassword);
                LoginAsNormalUser();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }





    }
}
