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

namespace GUI_BMS_Project.Forms
{
    public partial class CnicCheck : Form
    {
        public CnicCheck()
        {
            InitializeComponent();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignINForm si = new SignINForm();
            si.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtCnicCheck.Text != "")
            {
                int c = 0;
                for (int i = 0; i < AdminDL.adminUserList.Count; i++)
                {
                    if (AdminDL.adminUserList[i].Cnic == txtCnicCheck.Text)
                    {
                        this.Hide();
                        ClientForm cf = new ClientForm(i);
                        cf.Show();
                    }
                    else
                    {
                        c++;
                    }
                }
                if(c == AdminDL.adminUserList.Count)
                {
                    MessageBox.Show("Please Enter Valid Cnic !!!");
                    txtCnicCheck.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please Provide Information !!!");
            }
        }
    }
}
