using System;
using System.Drawing;
using System.Windows.Forms;

namespace Verkettungsoperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeige_Click(object sender, EventArgs e)
        {
            string a, b;
            double d;
            int x;

            b = "Hallo";
            d = 4.6;
            x = -5;
            a = b + " Welt " + d + " " + x + " " + 12;
            lblAnzeige.Text = a;
            // lblAnzeige.Text = x;
        }
    }
}
