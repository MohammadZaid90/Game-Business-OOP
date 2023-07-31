using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GUI_BMS_Project.BL;

namespace GUI_BMS_Project.DL
{
    class MUserDL
    {
        public static List<MUserBL> userList = new List<MUserBL>();
        public static string path = "Credentials.txt";
        public static void addUserIntoList(MUserBL user)
        {
            bool flag = true;
            foreach (MUserBL us in userList)
            {
                if (us.UserName == user.UserName && us.Password == user.UserName)
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                userList.Add(user);
                storeUserIntoFile();
            }
        }

        public static MUserBL SignIn(MUserBL user)
        {
            foreach (MUserBL storedUser in userList)
            {
                if (storedUser.UserName == user.UserName && storedUser.Password == user.Password)
                {
                    return storedUser;
                }
            }
            return null;
        }

        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }

                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        public static bool readDataFromFile()
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string userName = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    MUserBL user = new MUserBL(userName, password, role);
                    userList.Add(user);
                }
                fileVariable.Close();
                return true;
            }
            else
                return false;
        }

        public static void storeUserIntoFile()
        {
            StreamWriter file = new StreamWriter(path);
            foreach (MUserBL user in userList)
            {
                file.WriteLine(user.UserName + "," + user.Password + "," + user.Role);
            }
            file.Flush();
            file.Close();
        }
    }
}
