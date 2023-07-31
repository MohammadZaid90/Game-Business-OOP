using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_BMS_Project.BL;

namespace GUI_BMS_Project.DL
{
    class CustomerDL
    {
        public static bool ChangeClientPassword(string rol, string usname, string password, string path)
        {
            foreach (MUserBL us in MUserDL.userList)
            {
                if (rol.ToLower() == "customer" && usname == us.UserName && password == us.Password)
                {
                    Console.WriteLine("Enter the UserName: ");
                    string uName = Console.ReadLine();

                    Console.WriteLine("Enter a new Password: ");
                    string pass = Console.ReadLine();

                    Console.WriteLine("Your Old UserName Was: " + us.UserName);
                    Console.WriteLine("Your Old Password Was: " + us.Password);

                    us.UserName = uName;
                    us.Password = pass;

                    Console.WriteLine("\nYour New User Name is: " + us.UserName);
                    Console.WriteLine("\nYour New Password is: " + us.Password);
                    string role = us.Role;
                    MUserDL.storeUserIntoFile();
                    return true;
                    //break;
                }
            }
            return false;
        }
    }
}
