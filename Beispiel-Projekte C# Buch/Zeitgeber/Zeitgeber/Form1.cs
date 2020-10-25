using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeitgeber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            timAnzeige.Enabled = true;
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            timAnzeige.Enabled = false;
        }

        private void timAnzeige_Tick(object sender, EventArgs e)
        {
            lblAnzeige.Text += "x";
        }
    }
}
