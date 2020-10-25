using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜHalbierung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(txtEingabe.Text);

            while (d >= 0.001)
            {
                d = d / 2;
                lblA.Text += d + "\n";
            }
        }
    }
}
