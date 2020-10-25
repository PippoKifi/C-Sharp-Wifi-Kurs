using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArgumenteOptional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7, d = 9;
            lblAnzeige.Text =
                "Ergebnis: " + Addiere(a, b, c, d);
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7;
            lblAnzeige.Text =
                "Ergebnis: " + Addiere(a, b, c);
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            double a = 4.5;
            int b = 7;
            lblAnzeige.Text =
                "Ergebnis: " + Addiere(a, b);
        }

        private double Addiere(double x, int y, double z = 0, int q = 0)
        {
            return x + y + z + q;
        }
    }
}
