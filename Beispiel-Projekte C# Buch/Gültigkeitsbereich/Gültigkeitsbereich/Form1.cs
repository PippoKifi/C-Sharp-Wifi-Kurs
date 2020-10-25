using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gültigkeitsbereich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Mx = 0;

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 0;
            Mx = Mx + 1;
            x = x + 1;
            lblAnzeige.Text = "x: " +
                x + "  Mx: " + Mx;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int Mx = 0;
            Mx = Mx + 1;
            lblAnzeige.Text = "Mx: " + Mx;
        }
    }
}
