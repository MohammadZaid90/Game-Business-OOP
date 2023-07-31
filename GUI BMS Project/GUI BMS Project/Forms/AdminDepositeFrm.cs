using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_BMS_Project.BL;
using GUI_BMS_Project.DL;

namespace GUI_BMS_Project.Forms
{
    public partial class AdminDepositeFrm : Form
    {
        public AdminDepositeFrm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int c = 0; 
            if(TxtName.Text != "" && txtAccountNo.Text != "")
            {
                foreach(Admin ad in AdminDL.adminUserList)
                {
                    if(TxtName.Text == ad.Name && txtAccountNo.Text == ad.AccountNo && ad.Deposite > 0)
                    {
                        label5.Visible = true;
                        label6.Visible = true;
                        label4.Visible = true;
                        label3.Visible = true;
                        label4.Text = ad.Name;
                        label6.Text = ad.Deposite.ToString();
                        int depBal = ad.AccBalance + ad.Deposite;
                        ad.AccBalance = depBal;
                        string curr = ad.Currency;
                        ad.Currency = curr;
                        ad.Deposite = 0;
                        AdminDL.storeClientIntoFile();
                        MessageBox.Show("Amount Deposited SuccessFully !!!");

                        label5.Visible = false;
                        label6.Visible = false;
                        label4.Visible = false;
                        label3.Visible = false;
                        txtAccountNo.Text = string.Empty;
                        TxtName.Text = string.Empty;
                    }
                    else
                    {
                        c++;
                    }
                }
                if(c == AdminDL.adminUserList.Count)
                {
                    txtAccountNo.Text = string.Empty;
                    TxtName.Text = string.Empty;
                    MessageBox.Show("Enter Valid Strings or Client may not be deposite any Amount yet.....");
                    c = 0;
                }
            }
            else
            {
                MessageBox.Show("Please Provide Information !!!");
            }
        }
        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm();
            af.Show();
        }
    }
}
