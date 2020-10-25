using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜMethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdMittelwert1_Click(object sender, EventArgs e)
        {
            double[] a = { 3, 9.3, -7.2 };
            lblA.Text = "Ergebnis: " + mittelwert(a);
        }

        private void cmdMittelwert2_Click(object sender, EventArgs e)
        {
            double[] b = { -5, 6.2, 8.5, -5, 9 };
            lblB.Text = "Ergebnis: " + mittelwert(b);
        }

        private double mittelwert(double[] x)
        {
            int i;
            double wert = 0;

            for (i = 0; i < x.Length; i++)
                wert += x[i];
            wert /= x.Length;
            return wert;
        }

        private void cmdFelder_Click(object sender, EventArgs e)
        {
            int i;
            double[] a = { 3, 9.3, -7.2 };
            double[] b = { -5, 6.2, 8.5, -5, 9 };
            double[] c;

            vereinigen(a, b, out c);
            lblA.Text = "";
            for (i = 0; i < c.Length; i++)
                lblA.Text += c[i] + " ";

            vereinigen(b, a, out c);
            lblB.Text = "";
            for (i = 0; i < c.Length; i++)
                lblB.Text += c[i] + " ";
        }

        private void vereinigen(double[] x, double[] y, out double[] z)
        {
            int i;
            z = new double[x.Length + y.Length];

            for (i = 0; i < x.Length; i++)
                z[i] = x[i];
            for (i = 0; i < y.Length; i++)
                z[i + x.Length] = y[i];
        }
    }
}
