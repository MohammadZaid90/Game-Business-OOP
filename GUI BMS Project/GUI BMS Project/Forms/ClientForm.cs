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
    public partial class ClientForm : Form
    {
        int index = 0;
        public ClientForm(int x)
        {
            InitializeComponent();
            index = x;
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignINForm si = new SignINForm();
            si.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientDetails cd = new ClientDetails(index);
            cd.Show();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckbalanceForm cbf = new CheckbalanceForm(index);
            cbf.Show();
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithDrawFrm wF = new WithDrawFrm(index);
            wF.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferAmountFrm taf = new TransferAmountFrm(index);
            taf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientDepositeAmountFrm cdaf = new ClientDepositeAmountFrm(index);
            cdaf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignINForm sif = new SignINForm();
            sif.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientShowDepositeFrm csdf = new ClientShowDepositeFrm(index);
            csdf.Show();
        }

        private void lblmenu_Click(object sender, EventArgs e)
        {
            if(panel4.Visible == false)
            {
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
                panel9.Visible = true;
                panel10.Visible = true;
                panel11.Visible = true;
            }
            else
            {
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientChangePassForm ccpf = new ClientChangePassForm(index);
            ccpf.Show();
        }
    }
}
