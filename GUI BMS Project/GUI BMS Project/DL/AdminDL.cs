using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GUI_BMS_Project.BL;

namespace GUI_BMS_Project.DL
{
    class AdminDL
    {
        public static List<Admin> adminUserList = new List<Admin>();
        public static string path = "Client.txt";
        public static void addAdminUserIntoList(Admin User)
        {
            if (User.Name != null && User.Cnic != null)
            {
                adminUserList.Add(User);
            }
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

        public static bool deleteuserRecords(string name, string accnum, string path)
        {
            for (int x = 0; x < AdminDL.adminUserList.Count; x++)
            {
                if (name == AdminDL.adminUserList[x].Name && accnum == AdminDL.adminUserList[x].AccountNo)
                {
                    AdminDL.adminUserList[x].Name = null;
                    AdminDL.adminUserList[x].Cnic = null;
                    AdminDL.adminUserList[x].Age = 0;
                    AdminDL.adminUserList[x].AccountNo = null;
                    AdminDL.adminUserList[x].Deposite = 0;
                    AdminDL.adminUserList[x].AccBalance = 0;
                    AdminDL.adminUserList[x].Nationality = null;
                    AdminDL.adminUserList[x].Currency = null;
                    storeClientIntoFile();
                    return true;
                }
            }
            return false;
        }

        public static bool UpdateUserRecord(string name, string accnum, string path)
        {
            foreach (Admin adm in adminUserList)
            {
                if (name == adm.Name && accnum == adm.AccountNo)
                {
                    Console.WriteLine("\nEnter the New Name: ");
                    string newname = Console.ReadLine();
                    adm.Name = newname;

                    Console.WriteLine("Enter the New CNIC: ");
                    string cnic = Console.ReadLine();
                    adm.Cnic = cnic;

                    Console.WriteLine("Enter the New Age: ");
                    int age = int.Parse(Console.ReadLine());
                    adm.Age = age;

                    Console.WriteLine("Enter the New Nationality: ");
                    string nationality = Console.ReadLine();
                    adm.Nationality = nationality;

                    Console.WriteLine("Enter the New Currency you Want in your Account: ");
                    string currency = Console.ReadLine();
                    adm.Currency = currency;

                    AdminDL.storeClientIntoFile();
                    return true;
                }

            }
            return false;
        }

        public static bool EditPassword(string name, string password, string path)
        {
            for (int x = 0; x < MUserDL.userList.Count; x++)
            {
                if (name == MUserDL.userList[x].Role && password == MUserDL.userList[x].Password)
                {
                    Console.WriteLine("Enter a new Password: ");
                    string pass = Console.ReadLine();
                    MUserDL.userList[x].Password = pass;
                    Console.WriteLine("\nYour New Password is: ");
                    Console.WriteLine(MUserDL.userList[x].Password);
                    string nam = MUserDL.userList[x].UserName;
                    string role = MUserDL.userList[x].Role;
                    MUserDL.storeUserIntoFile();
                    return true;
                }
            }
            return false;
        }

        public static void ReadClientDataFromFile()
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] fields = record.Split(',');
                    if (fields.Length >= 8)
                    {
                        string name = fields[0].Trim();
                        string cnic = fields[1].Trim();
                        int age = int.Parse(fields[2].Trim());
                        string account = fields[3].Trim();
                        int balance = int.Parse(fields[4].Trim());
                        int deposit = int.Parse(fields[5].Trim());
                        string nation = fields[6].Trim();
                        string currency = fields[7].Trim();
                        Admin adm = new Admin(name, cnic, age, account, balance, deposit, nation, currency);
                        adminUserList.Add(adm);
                    }
                }
                fileVariable.Close();
            }
        }


        public static void storeClientIntoFile()
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Admin adm in adminUserList)
            {
                if (adm.Name != "" && adm.Cnic != null && adm.Nationality != null)
                {
                    file.WriteLine(adm.Name + "," + adm.Cnic + "," + adm.Age + "," + adm.AccountNo + "," + adm.AccBalance + "," + adm.Deposite + "," + adm.Nationality + "," + adm.Currency);
                }
            }
            file.Flush();
            file.Close();
        }
    }
}
