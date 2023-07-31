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
    public partial class ClientChangePassForm : Form
    {
        int idx = 0;
        public ClientChangePassForm(int x)
        {
            InitializeComponent();
            idx = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            if(textoldName.Text != "" && textoldPassword.Text != "" && textoldRole.Text != "")
            {
                foreach(MUserBL us in MUserDL.userList)
                {
                    if(textoldRole.Text.ToLower() == "client" && textoldName.Text == us.UserName && textoldPassword.Text == us.Password)
                    {
                        NewUN.Visible = true;
                        NewP.Visible = true;
                        txtNewName.Visible = true;
                        txtNewPassword.Visible = true;

                        if(txtNewName.Text != "" && txtNewPassword.Text != "")
                        {
                            label2.Visible = true;
                            label7.Visible = true;
                            label10.Visible = true;
                            label11.Visible = true;
                            label12.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;
                            label15.Visible = true;

                            label7.Text = us.UserName;
                            label11.Text = us.Password;

                            us.UserName = txtNewName.Text;
                            us.Password = txtNewPassword.Text;

                            label12.Text = us.UserName;
                            label15.Text = us.Password;

                            MUserDL.storeUserIntoFile();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter New Password And UserName !!!");
                        }
                    }
                    else
                    {
                        c++;
                    }
                }

                if(c == MUserDL.userList.Count)
                {
                    MessageBox.Show("No Such Account Found... Enter Valid Information !!!");
                    textoldName.Text = string.Empty;
                    textoldPassword.Text = string.Empty;
                    textoldRole.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please Provide InFormation !!!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            NewUN.Visible = false;
            NewP.Visible = false;
            txtNewName.Visible = false;
            txtNewPassword.Visible = false;

            label2.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;

            textoldName.Text = string.Empty;
            textoldPassword.Text = string.Empty;
            textoldRole.Text = string.Empty;

            txtNewName.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
        }
    }
}
