using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜLogischeOperatoren
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
            p = 4 > 3 && -4 > -3;
            lblA.Text = "Ergebnis: " + p;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            bool p;
            p = 4 > 3 || -4 > -3;
            lblA.Text = "Ergebnis: " + p;
        }
    }
}
