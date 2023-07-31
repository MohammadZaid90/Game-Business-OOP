using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_BMS_Project.DL;

namespace GUI_BMS_Project
{
    public partial class CheckBalance : Form
    {
        public CheckBalance()
        {
            InitializeComponent();
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string n = TxtName.Text;
            string a = txtAccountNo.Text;
            SignINForm frm = new SignINForm();
            int c = 0;
            label4.Visible = false;

            for (int i = 0; i < AdminDL.adminUserList.Count; i++)
            {
                if (AdminDL.adminUserList[i].Name == n && AdminDL.adminUserList[i].AccountNo == a)
                {
                    txtBalance.Text = AdminDL.adminUserList[i].AccBalance.ToString();
                    label4.Text = AdminDL.adminUserList[i].Name;
                    label4.Visible = true;
                    label5.Visible = true;
                }
                else
                {
                    c++;
                }
            }
            if (c == AdminDL.adminUserList.Count)
            {
                MessageBox.Show("Enter Valid Name/Account !!!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAccountNo.Text = string.Empty;
            txtBalance.Text = string.Empty;
            TxtName.Text = string.Empty;

            label5.Visible = false;
            label4.Visible = false;
        }
    }
}
