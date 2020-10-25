using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rechenoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 5;
            x++;
            ++x;
            x = x + 1;
            lblA.Text = "Ergebnis: " + x;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblA.Text = "Ergebnis: " + x++;
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblA.Text = "Ergebnis: " + ++x;
        }

        private void cmdModulo1_Click(object sender, EventArgs e)
        {
            lblA.Text = "Ergebnis: " + (19 % 4);
        }

        private void cmdModulo2_Click(object sender, EventArgs e)
        {
            lblA.Text = "Ergebnis: " + (19.5 % 4.2);
        }
    }
}
