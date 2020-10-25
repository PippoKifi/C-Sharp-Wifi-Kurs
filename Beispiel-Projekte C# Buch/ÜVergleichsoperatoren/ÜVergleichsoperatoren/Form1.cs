using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜVergleichsoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            bool p;
            p = 12 - 3 >= 4 * 2.5;
            lblA.Text = "Ergebnis: " + p;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            bool p;
            p = "Maier" != "Mayer";
            lblA.Text = "Ergebnis: " + p;
        }
    }
}
