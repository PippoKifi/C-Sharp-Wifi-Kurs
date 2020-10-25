using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArgumenteBeliebig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double a = 4.5, b = 7.2, c = 10.3, d = 9.2;
            lblAnzeige.Text =
                "Ergebnis: " + Mittelwert(a, b, c, d);
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double a = 4.5, b = 7.2;
            lblAnzeige.Text =
                "Ergebnis: " + Mittelwert(a, b);
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text =
                "Ergebnis: " + Mittelwert();
        }

        private double Mittelwert(params double[] x)
        {
            int i;
            double summe = 0;
            if (x.Length == 0)
                return 0;

            for (i = 0; i < x.Length; i++)
                summe += x[i];

            return summe / x.Length;
        }
    }
}
