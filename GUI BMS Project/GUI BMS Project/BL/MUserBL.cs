using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_BMS_Project.DL;

namespace GUI_BMS_Project.BL
{
    class MUserBL
    {
        private string userName;
        private string password;
        private string role;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public MUserBL(string userName, string password, string role)
        {
            this.UserName = userName;
            this.Password = password;
            this.Role = role;
        }

        public MUserBL(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
            this.Role = "NA";
        }

        /*public bool isAdmin()
        {
            if(role == "Admin")
            {
                return true;
            }
            else if(role == "Customer")
            {
                return true;
            }
            return false;
        }*/


        public static string isvalidUser(MUserBL existingUser)
        {
            foreach (MUserBL user in MUserDL.userList)
            {
                if (user.UserName == existingUser.UserName && user.Password == existingUser.Password)
                {
                    return user.Role;
                }
            }
            return "User NOT Found!!!";
        }
    }
}
