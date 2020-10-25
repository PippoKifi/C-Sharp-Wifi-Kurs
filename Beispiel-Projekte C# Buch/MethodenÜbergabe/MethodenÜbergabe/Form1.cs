using System;
using System.Drawing;
using System.Windows.Forms;

namespace MethodenÜbergabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdKopie_Click(object sender, EventArgs e)
        {
            int x, y;
            x = 5;
            y = 12;
            lblA.Text =
                "Vorher: x: " + x + ", y: " + y;
            TauscheKopie(x, y);
            lblA.Text +=
                "\nNachher: x: " + x + ", y: " + y;
        }

        private void cmdReferenz_Click(object sender, EventArgs e)
        {
            int x, y;
            x = 5;
            y = 12;
            lblA.Text =
                "Vorher: x: " + x + ", y: " + y;
            TauscheReferenz(ref x, ref y);
            lblA.Text +=
                "\nNachher: x: " + x + ", y: " + y;
        }

        private void TauscheKopie(int a, int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        private void TauscheReferenz(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        private void cmdEinDimFeld_Click(object sender, EventArgs e)
        {
            int[] p = { 6, 7, 2 };

            Verdoppeln(p);
            lblA.Text = "";
            foreach (int z in p)
                lblA.Text += z + " ";
        }

        private void Verdoppeln(int[] x)
        {
            int i;
            for (i = 0; i < x.Length; i++)
                x[i] = x[i] * 2;
        }

        private void cmdDreiDimFeld_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double[, ,] x = new double[2, 5, 3];
            int i, j, k;

            for (i = 0; i <= x.GetUpperBound(0); i++)
                for (j = 0; j <= x.GetUpperBound(1); j++)
                    for (k = 0; k <= x.GetUpperBound(2); k++)
                        x[i, j, k] = r.NextDouble();

            Mittelwert(x);
        }

        private void Mittelwert(double[, ,] z)
        {
            double summe = 0;
            int i, j, k;

            for (i = 0; i <= z.GetUpperBound(0); i++)
                for (j = 0; j <= z.GetUpperBound(1); j++)
                    for (k = 0; k <= z.GetUpperBound(2); k++)
                        summe += z[i, j, k];

            lblA.Text = "Mittelwert: " + summe / z.Length;
        }

        private void cmdOut_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 12;
            b = 3;
            Addieren(a, b, out c);
            lblA.Text = "Ergebnis: " + c;
        }

        private void Addieren(int x, int y, out int z)
        {
            z = x + y;
        }
    }
}
