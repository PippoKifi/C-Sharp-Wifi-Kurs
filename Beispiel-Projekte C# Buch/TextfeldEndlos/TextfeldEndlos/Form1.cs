using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextfeldEndlos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x;

        private void txtEingabe1_TextChanged(object sender, EventArgs e)
        {
            txtEingabe2_TextChanged(sender, e);
        }

        private void txtEingabe2_TextChanged(object sender, EventArgs e)
        {
            x++;

            if (x < 1000)
                txtEingabe1_TextChanged(sender, e);
            else
                lblA.Text = ":" + x;
        }
    }
}
