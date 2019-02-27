using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectsManager
{
    public class User
    {
        public string UserName, Password, DisplayName;
        public int UserID;
        public bool ReadPermission, ModifyPermission, CreatePermission, DeletePermission, ManageUsers;
        public bool IsDomainUser;

        /// <summary>
        /// Create New User Object
        /// </summary>
        public User()
        {  }
        
        /// <summary>
        /// Create New User Object
        /// </summary>
        /// <param name="UserName">UserName in DB</param>
        /// <param name="UserID">User ID in DB</param>
        /// <param name="ReadPermission">Can read data</param>
        /// <param name="ModifyPermission">Can modify and write data</param>
        /// <param name="CreatePermission">Can create new objects</param>
        /// <param name="DeletePermission">Can delete objects</param>
        /// <param name="ModifyUsersPermission">Can manage users</param>
        public User(string UserName, string Password, string DisplayName, int UserID, bool ReadPermission, bool ModifyPermission, bool CreatePermission, bool DeletePermission, bool ManageUsers, bool IsDomainUser)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.DisplayName = DisplayName;
            this.UserID = UserID;
            this.ReadPermission = ReadPermission;
            this.ModifyPermission = ModifyPermission;
            this.CreatePermission = CreatePermission;
            this.DeletePermission = DeletePermission;
            this.ManageUsers = ManageUsers;
            this.IsDomainUser = IsDomainUser;
        }

        /// <summary>
        /// Create New User Object
        /// </summary>
        /// <param name="ReadPermission">Can read data</param>
        /// <param name="ModifyPermission">Can modify and write data</param>
        /// <param name="CreatePermission">Can create new objects</param>
        /// <param name="DeletePermission">Can delete objects</param>
        /// <param name="ModifyUsersPermission">Can manage users</param>
        public User(bool ReadPermission, bool ModifyPermission, bool CreatePermission, bool DeletePermission, bool ManageUsers)
        {
            this.ReadPermission = ReadPermission;
            this.ModifyPermission = ModifyPermission;
            this.CreatePermission = CreatePermission;
            this.DeletePermission = DeletePermission;
            this.ManageUsers = ManageUsers;

        }


    }
}
