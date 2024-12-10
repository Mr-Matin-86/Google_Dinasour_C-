using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleDinasour
{
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PCBcactus_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PCBcactus.Left -= 5;
            if (PCBcactus.Right < 0)
            {
                PCBcactus.Left = 1500;
            }
            if ((PCBDani.Right >= PCBcactus.Left) && (PCBDani.Bottom >= PCBcactus.Top) && (PCBDani.Left <= PCBcactus.Right))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                MessageBox.Show("باختی");
                PCBcactus.Left = 1500;
                timer1.Enabled = true;
            }
        }

        private void FRMMain_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void PNLTop_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void FRMMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FRMMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 32)
            {
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PCBDani.Top -= 5;
            if (PCBDani.Bottom < PNLTop.Bottom)
            {
                timer2.Enabled = false;
                timer3.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            PCBDani.Top += 5;
            if (PCBDani.Bottom == PNLDown.Top)
            {
                timer3.Enabled = false;
            }
        }

        private void PNLDown_Paint(object sender, PaintEventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
