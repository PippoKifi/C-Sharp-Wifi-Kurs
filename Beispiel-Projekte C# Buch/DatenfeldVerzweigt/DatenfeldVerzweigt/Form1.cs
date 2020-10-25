using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatenfeldVerzweigt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void cmdAnzeige_Click(object sender, EventArgs e)
        {
            double[][] a = new double[5][];
            int i, k, anz = 0;

            a[0] = new double[2];
            a[1] = new double[4];
            a[2] = new double[2];
            a[3] = new double[3];
            a[4] = new double[1];

            lblA.Text = "";
            for (i = 0; i < a.Length; i++)
            {
                for (k = 0; k < a[i].Length; k++)
                {
                    a[i][k] = Math.Round(r.NextDouble(), 3);
                    lblA.Text += a[i][k] + "  ";
                }
                anz += a[i].Length;
                lblA.Text += "\n";
            }

            lblA.Text += "Anzahl: " + anz;
        }
    }
}
