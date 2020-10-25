using System;
using System.Drawing;
using System.Windows.Forms;

namespace Syntaxfehler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeige_Click(object sender, EventArgs e)
        {
            int i;
            if (txtEingabe.Txt = "")
                return;

            i = Convert.ToInt(txtEingabe.Text);

            if (i > 0)
                lblAnzeige.Text = "positiv";
            else if  i < 0
                lblAnzeige.Text = "negativ"
            else
                lblAnzeige = "gleich 0";
        }
    }
}
