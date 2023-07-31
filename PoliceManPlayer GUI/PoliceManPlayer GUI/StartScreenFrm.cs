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
    public partial class StartScreenFrm : Form
    {
        public StartScreenFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maze1Frm mf = new Maze1Frm();
            mf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructionFrm If = new InstructionFrm();
            If.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
