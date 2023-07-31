using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_BMS_Project.DL;

namespace GUI_BMS_Project.BL
{
    class Admin
    {
        private string name;
        private string cnic;
        private int age;
        private string accountNo;
        private int accBalance;
        private string nationality;
        private string currency;
        private int deposite;

        //private variables------------------------------------

        public Admin(int deposite, string currency)
        {
            this.Deposite = deposite;
            this.Currency = currency;
        }

        public Admin(string name, string cnic, int age, string acountNo, int accBalance, int deposite, string nationality, string currency)
        {
            this.Name = name;
            this.Cnic = cnic;
            this.Age = age;
            this.AccountNo = acountNo;
            this.AccBalance = accBalance;
            this.Deposite = deposite;
            this.Nationality = nationality;
            this.Currency = currency;
        }

        //Constructors=----------------------------------------

        public virtual string Name { get => name; set => name = value; }
        public virtual string Cnic { get => cnic; set => cnic = value; }
        public virtual int Age { get => age; set => age = value; }
        public virtual string AccountNo { get => accountNo; set => accountNo = value; }
        public virtual int AccBalance { get => accBalance; set => accBalance = value; }
        public virtual string Nationality { get => nationality; set => nationality = value; }
        public virtual string Currency { get => currency; set => currency = value; }
        public virtual int Deposite { get => deposite; set => deposite = value; }
    }
}
