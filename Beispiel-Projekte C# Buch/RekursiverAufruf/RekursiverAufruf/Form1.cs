using System;
using System.Drawing;
using System.Windows.Forms;

namespace RekursiverAufruf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSchleife_Click(object sender, EventArgs e)
        {
            double x = 22;
            lblAnzeige.Text = "x: " + x + "\n";

            while (x > 0.1)
            {
                x = x / 2;
                lblAnzeige.Text += "x: " + x + "\n";
            }
        }

        private void cmdRekursion_Click(object sender, EventArgs e)
        {
            double x = 22;
            lblAnzeige.Text = "x: " + x + "\n";
            Halbieren(ref x);
            lblAnzeige.Text += "x: " + x + "\n";
        }

        private void Halbieren(ref double z)
        {
            z = z / 2;
            if (z > 0.1)
            {
                lblAnzeige.Text += "z: " + z + "\n";
                Halbieren(ref z);
            }
        }
    }
}
