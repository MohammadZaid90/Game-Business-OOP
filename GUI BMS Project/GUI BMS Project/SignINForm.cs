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

namespace GUI_BMS_Project.DL
{
    public partial class SignINForm : Form
    {
        public SignINForm()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != "" && TxtPassword.Text != "")
            {
                string name = TxtName.Text;
                string pas = TxtPassword.Text;
                MUserBL user1 = new MUserBL(name, pas);
                MUserBL user2 = MUserDL.userList.Find(u => u.UserName == name && u.Password == pas && (u.Role == "Admin" || u.Role == "admin") || (u.Role == "Client" || u.Role == "client"));
                if (user2 != null)
                {
                    lblWarning.Hide();
                    if ((user2.Role == "Admin" || user2.Role == "admin") && TxtPassword.Text == user2.Password && TxtName.Text == user2.UserName)
                    {
                        MessageBox.Show("SignIn Successfully !!!");
                        this.Hide();
                        AdminForm f1 = new AdminForm();
                        f1.Show();
                    }

                    if ((user2.Role == "Client" || user2.Role == "client") && TxtPassword.Text == user2.Password && TxtName.Text == user2.UserName)
                    {
                        MessageBox.Show("Sign In Successfully !!!");
                        this.Hide();
                        CnicCheck cc = new CnicCheck();
                        cc.Show();
                    }
                    else
                    {
                        lblWarning_Click(sender, e);
                    }
                }
                else
                {
                    lblWarning_Click(sender, e);
                }
            }
            else
            {
                lblWarning.Text = "Provide UserNAme and Password";
                lblWarning.Visible = true;
            }
        }

        private void lblWarning_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "⚠ Invalid Username and Password ⚠";
            lblWarning.Visible = true;
            TxtName.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUPForm SF1 = new SignUPForm();
            SF1.Show();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if(TxtPassword.UseSystemPasswordChar == true)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }

            else if (TxtPassword.UseSystemPasswordChar == false)
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
