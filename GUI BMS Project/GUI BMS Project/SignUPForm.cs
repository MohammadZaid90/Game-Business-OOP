using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using GUI_BMS_Project.BL;
using GUI_BMS_Project.DL;

namespace GUI_BMS_Project
{
    public partial class SignUPForm : Form
    {
        public SignUPForm()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (textName.Text != "" && textPassword.Text != "" && textRole.Text != "")
            {
                string name = textName.Text;
                string Passw = textPassword.Text;
                string roll = textRole.Text;
                MUserBL U3 = new MUserBL(name, Passw, roll);
                MUserBL user = MUserDL.userList.Find(u => u.UserName == name && u.Password == Passw);
                if (user != null)
                {
                    lblShow_Click(sender, e);
                    Thread.Sleep(600);
                    lblShow_Click(sender, e);
                }
                else
                {
                    MUserBL U1 = new MUserBL(name, Passw, roll);
                    MUserDL.addUserIntoList(U1);
                    MUserDL.storeUserIntoFile();
                    MessageBox.Show("Sign Up Successfully");
                    textName.Text = string.Empty;
                    textPassword.Text = string.Empty;
                    textRole.Text = string.Empty;
                }
            }
            else
            {
                lblShow.Text = "Please Provide Information !!!";
                lblShow.Visible = true;
            }
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            lblShow.Visible = true;
            textName.Text = string.Empty;
            textPassword.Text = string.Empty;
            textRole.Text = string.Empty;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignINForm SI1 = new SignINForm();
            SI1.Show();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
