using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜDatenfeldMehrdimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            int[, ,] c = new int[6, 3, 4];
            int i, j, k, MinWert;

            lblFeld.Text = "";
            for (i = 0; i <= c.GetUpperBound(0); i++)
            {
                for (j = 0; j <= c.GetUpperBound(1); j++)
                {
                    lblFeld.Text += "( ";
                    for (k = 0; k <= c.GetUpperBound(2); k++)
                    {
                        c[i, j, k] = r.Next(20, 31);
                        lblFeld.Text += c[i, j, k] + " ";
                    }
                    lblFeld.Text += ") ";
                }
                lblFeld.Text += "\n";
            }

            MinWert = c[0, 0, 0];
            for (i = 0; i <= c.GetUpperBound(0); i++)
                for (j = 0; j <= c.GetUpperBound(1); j++)
                    for (k = 0; k <= c.GetUpperBound(2); k++)
                        if (c[i, j, k] < MinWert)
                            MinWert = c[i, j, k];

            lblA.Text = "Minimum: " + MinWert +
                ", an Position:" + "\n";
            for (i = 0; i <= c.GetUpperBound(0); i++)
                for (j = 0; j <= c.GetUpperBound(1); j++)
                    for (k = 0; k <= c.GetUpperBound(2); k++)
                        if (c[i, j, k] == MinWert)
                            lblA.Text += "Zeile " + i +
                                ", Gruppe " + j +
                                ", Element " + k + "\n";
        }
    }
}
