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
    public partial class ClientDetails : Form
    {
        int idx = 0;
        public ClientDetails(int x)
        {
            InitializeComponent();
            idx = x;
    
            label3.Visible = true;
            label3.Text = AdminDL.adminUserList[x].Name;

            label4.Visible = true;
            label4.Text = AdminDL.adminUserList[x].AccountNo;

            label2.Visible = true;
            label2.Text = AdminDL.adminUserList[x].Currency;
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
