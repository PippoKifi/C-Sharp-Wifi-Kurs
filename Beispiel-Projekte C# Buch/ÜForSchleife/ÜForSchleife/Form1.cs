using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜForSchleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSchleife1_Click(object sender, EventArgs e)
        {
            double d;
            lblA.Text = "";

            for (d = 35; d >= 20; d = d - 2.5)
                lblA.Text += d + "\n";
        }

        private void cmdSchleife2_Click(object sender, EventArgs e)
        {
            int count = 0;
            double d, summe = 0.0, mw;
            lblA.Text = "";

            for (d = 35; d >= 20; d = d - 2.5)
            {
                lblA.Text += d + "\n";
                count = count + 1;
                summe = summe + d;
            }

            mw = summe / count;
            lblA.Text += "Summe: " + summe + "\n";
            lblA.Text += "Mittelwert: " + mw;
        }
    }
}
