using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vergleichsoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdVergleich1_Click(object sender, EventArgs e)
        {
            lblA.Text = "Ergebnis: " + (5 > 3);
        }

        private void cmdVergleich2_Click(object sender, EventArgs e)
        {
            lblA.Text = "Ergebnis: " + (3 == 3.2);
        }

        private void cmdVergleich3_Click(object sender, EventArgs e)
        {
            lblA.Text = "Ergebnis: " + (5 + 3 * 2 >= 12);
        }

        private void cmdVergleich4_Click(object sender, EventArgs e)
        {
            lblA.Text = "Ergebnis: " + ("Maier" == "Mayer");
        }
    }
}
