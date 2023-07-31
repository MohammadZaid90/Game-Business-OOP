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
    public partial class WithDrawFrm : Form
    {
        int idx = 0;
        int balance;
        public WithDrawFrm(int x)
        {
            InitializeComponent();
            idx = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtwithDraw.Text != "")
            {
                balance = AdminDL.adminUserList[idx].AccBalance;
                if (int.Parse(txtwithDraw.Text) < balance && int.Parse(txtwithDraw.Text) > 0)
                {
                    balance = balance - int.Parse(txtwithDraw.Text);
                    AdminDL.adminUserList[idx].AccBalance = balance;
                    AdminDL.storeClientIntoFile();
                    label6.Visible = true;
                    lblwithDraw.Visible = true;
                    lblwithDraw.Text = balance.ToString();
                    MessageBox.Show("Amount WithDraw Successfully !!!");
                    lblwithDraw.Visible = false;
                    label6.Visible = false;
                    txtwithDraw.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Your Amount is not Enough for this Transaction !!!");
                    txtwithDraw.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Amount !!!");
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
