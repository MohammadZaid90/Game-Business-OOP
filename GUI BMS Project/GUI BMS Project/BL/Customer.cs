using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_BMS_Project.DL;

namespace GUI_BMS_Project.BL
{
    class Customer:Admin
    {
        public Customer(int deposite, string currency) : base(deposite, currency)
        {
        }

        /*public Customer(string currency, double trans) : base(currency)
        {
            this.transfer = trans;
        }*/



        public override string AccountNo { get => base.AccountNo; set => base.AccountNo = value; }
        public override int AccBalance { get => base.AccBalance; set => base.AccBalance = value; }
        public override int Deposite { get => base.Deposite; set => base.Deposite = value; }
    }
}
