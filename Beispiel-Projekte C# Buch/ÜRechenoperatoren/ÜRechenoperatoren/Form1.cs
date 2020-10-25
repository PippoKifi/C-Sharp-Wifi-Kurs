using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜRechenoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double x;
            x = 3 * -2.5 + 4 * 2;
            lblA.Text = "Ergebnis: " + x;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double x;
            x = 3 * (-2.5 + 4) * 2;
            lblA.Text = "Ergebnis: " + x;
        }
    }
}
