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
    public partial class ClientShowDepositeFrm : Form
    {
        int idx = 0;
        public ClientShowDepositeFrm(int x)
        {
            InitializeComponent();
            idx = x;

            if(AdminDL.adminUserList[idx].Deposite <= 0)
            {
                lbltitle.Visible = true;
                label3.Visible = true;
                label3.Text = AdminDL.adminUserList[idx].Deposite.ToString();
                label2.Visible = true;
                label2.Text = "You can Deposite Your Amount....";
            }
            else
            {
                lbltitle.Visible = true;
                label3.Visible = true;
                label3.Text = AdminDL.adminUserList[idx].Deposite.ToString();
                label2.Visible = true;
                label2.Text = "Please Go To Admin and Deposite Your Last amount....";
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
