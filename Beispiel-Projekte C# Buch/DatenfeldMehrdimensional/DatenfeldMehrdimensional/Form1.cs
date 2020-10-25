using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatenfeldMehrdimensional
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
            int[,] a;
            a = new int[7, 3];
            int i, k;

            lstSpalte0.Items.Clear();
            lstSpalte1.Items.Clear();
            lstSpalte2.Items.Clear();

            for (i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (k = 0; k <= a.GetUpperBound(1); k++)
                    a[i, k] = r.Next(20, 31);

                lstSpalte0.Items.Add(a[i, 0]);
                lstSpalte1.Items.Add(a[i, 1]);
                lstSpalte2.Items.Add(a[i, 2]);
            }
        }

        private void lstSpalte0_Click(object sender, EventArgs e)
        {
            lstSpalte1.SelectedIndex = -1;
            lstSpalte2.SelectedIndex = -1;
            lblAnzeige.Text = "Indizes: " +
                lstSpalte0.SelectedIndex + ", 0";
        }

        private void lstSpalte1_Click(object sender, EventArgs e)
        {
            lstSpalte0.SelectedIndex = -1;
            lstSpalte2.SelectedIndex = -1;
            lblAnzeige.Text = "Indizes: " +
                lstSpalte1.SelectedIndex + ", 1";
        }

        private void lstSpalte2_Click(object sender, EventArgs e)
        {
            lstSpalte0.SelectedIndex = -1;
            lstSpalte1.SelectedIndex = -1;
            lblAnzeige.Text = "Indizes: " +
                lstSpalte2.SelectedIndex + ", 2";
        }

        private void cmdInit_Click(object sender, EventArgs e)
        {
            int[] a = { 0, 5, -2, 7 };

            double[,] b = { { 6.2, 2.0, -1.8 }, { 9.3, 3.6, -2.3 } };

            int[, ,] c = {{{9, -3, 2}, {2, 1, -5}},
                 {{3, 9, 8}, {6, 3, -8}}};

            lblAnzeige.Text =
                b[1, 2] + "    " + c[1, 1, 2];
        }
    }
}
