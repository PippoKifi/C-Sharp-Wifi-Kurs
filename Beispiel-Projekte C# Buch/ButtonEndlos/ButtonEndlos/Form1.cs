using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonEndlos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0;

        private void cmdEreignis1_Click(object sender, EventArgs e)
        {
            cmdEreignis2_Click(sender, e);
        }

        private void cmdEreignis2_Click(object sender, EventArgs e)
        {
            x++;

            if (x < 1000)
                cmdEreignis1_Click(sender, e);
            else
                lblA.Text = ":" + x;
        }
    }
}
