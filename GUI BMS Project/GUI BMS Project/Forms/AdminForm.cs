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
using GUI_BMS_Project.Forms;

namespace GUI_BMS_Project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudClientFrm ccf = new CrudClientFrm();
            ccf.Show();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignINForm SI = new SignINForm();
            SI.Show();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckBalance ccf = new CheckBalance();
            ccf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDepositeFrm adf = new AdminDepositeFrm();
            adf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignINForm sif = new SignINForm();
            sif.Show();
        }

        private void lblmenu_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
            {
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
            }
            else
            {
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminChangePasswordFrm acpf = new AdminChangePasswordFrm();
            acpf.Show();
        }
    }
}
