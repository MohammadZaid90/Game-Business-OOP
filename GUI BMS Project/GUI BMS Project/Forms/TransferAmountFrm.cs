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
    public partial class TransferAmountFrm : Form
    {
        int idx = 0;
        int rm = 0;
        int c = 0;
        public TransferAmountFrm(int x)
        {
            InitializeComponent();
            idx = x;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm cf = new ClientForm(idx);
            cf.Show();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (txtTrans.Text != "")
            {
                string accNo = txtTrans.Text;
                foreach (Admin ad in AdminDL.adminUserList)
                {
                    if (accNo == ad.AccountNo && accNo != AdminDL.adminUserList[idx].AccountNo)
                    {
                        lbltitle.Visible = true;
                        lblaccno.Visible = true;
                        label8.Visible = true;
                        label4.Visible = true;
                        label8.Text = ad.Name;
                        label4.Text = ad.AccountNo;
                        label2.Visible = true;
                        txttransAmount.Visible = true;
                        if (txttransAmount.Text != "")
                        {
                            int amount = int.Parse(txttransAmount.Text);
                            if (amount > 0 && AdminDL.adminUserList[idx].AccBalance > amount)
                            {
                                rm = AdminDL.adminUserList[idx].AccBalance - amount;
                                AdminDL.adminUserList[idx].AccBalance = rm;
                                int tr = ad.AccBalance + amount;
                                ad.AccBalance = tr;
                                AdminDL.storeClientIntoFile();
                                label6.Visible = true;
                                lbltrans.Visible = true;
                                lbltrans.Text = rm.ToString();
                                MessageBox.Show("Transaction complete Successfully !!!");

                                label6.Visible = false;
                                lbltrans.Visible = false;
                                lbltitle.Visible = false;
                                lblaccno.Visible = false;
                                label8.Visible = false;
                                label4.Visible = false;
                                label2.Visible = false;
                                txttransAmount.Visible = false;
                                txtTrans.Text = string.Empty;
                                txttransAmount.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("Your amount is not Enough For this transaction !!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Amount !!!");
                        }
                    }
                    else
                    {
                        c++;
                    }
                }

                if (c == AdminDL.adminUserList.Count)
                {
                    MessageBox.Show("Please Enter Valid Account Number !!!");
                    c = 0;
                }
            }
            else
            {
                MessageBox.Show("Please Provide Information !!!");
            }
        }
    }
}
