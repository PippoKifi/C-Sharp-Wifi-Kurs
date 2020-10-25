using System;
using System.Drawing;
using System.Windows.Forms;

namespace ForSchleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSchleife1_Click(object sender, EventArgs e)
        {
            int i;
            lblA1.Text = "";

            for (i = 3; i <= 7; i++)
            {
                lblA1.Text += i + "\n";
            }
        }

        private void cmdSchleife2_Click(object sender, EventArgs e)
        {
            int i;
            lblA2.Text = "";

            for (i = 3; i <= 11; i = i + 2)
                lblA2.Text += i + "\n";
        }

        private void cmdSchleife3_Click(object sender, EventArgs e)
        {
            int i;
            lblA3.Text = "";

            for (i = 7; i >= 3; i--)
                lblA3.Text += i + "\n";
        }

        private void cmdSchleife4_Click(object sender, EventArgs e)
        {
            double d;
            lblA4.Text = "";

            for (d = 3.5; d <= 7.5; d = d + 1.5)
                lblA4.Text += d + "\n";
        }

        private void cmdSchleife5_Click(object sender, EventArgs e)
        {
            int i;
            lblA5.Text = "";

            for (i = 3; i <= 20; i++)
            {
                if (i >= 5 && i <= 7)
                    continue;
                if (i >= 11)
                    break;
                lblA5.Text += i + "\n";
            }
        }
    }
}
