using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜGültigkeitsbereich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x = 0.0;

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double y = 0.0;
            y = y + 0.1;
            x = x + 0.1;
            lblA.Text = "x: " + x + "\n" + "y: " + y;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double z = 0.0;
            z = z + 0.1;
            x = x + 0.1;
            lblA.Text = "x: " + x + "\n" + "z: " + z;
        }
    }
}
