using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceManPlayer_GUI
{
    public partial class InstructionFrm : Form
    {
        public InstructionFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartScreenFrm ssf = new StartScreenFrm();
            ssf.Show();
        }
    }
}
