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
    public partial class ClientDepositeAmountFrm : Form
    {
        int idx = 0;
        public ClientDepositeAmountFrm(int x)
        {
            InitializeComponent();
            idx = x;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            if (AdminDL.adminUserList[idx].Deposite == 0)
            {
                if (txtAccountNo.Text != "" && TxtAmount.Text != "" && txtCurrency.Text != "")
                {
                    if (int.Parse(TxtAmount.Text) > 0)
                    {
                        int dep = int.Parse(TxtAmount.Text);

                        string curr = txtCurrency.Text;
                        if (txtAccountNo.Text == AdminDL.adminUserList[idx].AccountNo && txtCurrency.Text == AdminDL.adminUserList[idx].Currency)
                        {
                            Customer cust = new Customer(dep, curr);
                            AdminDL.adminUserList[idx].Deposite = dep;
                            AdminDL.adminUserList[idx].Currency = curr;
                            AdminDL.addAdminUserIntoList(cust);
                            AdminDL.storeClientIntoFile();

                            MessageBox.Show("SuccessFully Proceed !!! Your Amount will Be Deposite When Admin Check it......");

                            txtAccountNo.Text = string.Empty;
                            txtCurrency.Text = string.Empty;
                            TxtAmount.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid Account Number or Currency Name Please Check Your Details First... !!!");
                            txtAccountNo.Text = string.Empty;
                            txtCurrency.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Deposite must be greater or Equal to 0 !!! Enter Again.....");
                        TxtAmount.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Please Provide Information !!!");
                }
            }
            else
            {
                MessageBox.Show("Your last amount is not deposited by Admin yet...Please visit to Admin and Deposite Your Last Amount First !!!");
                this.Hide();
                ClientForm cf = new ClientForm(idx);
                cf.Show();
            }
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm cf = new ClientForm(idx);
            cf.Show();
        }
    }
}
