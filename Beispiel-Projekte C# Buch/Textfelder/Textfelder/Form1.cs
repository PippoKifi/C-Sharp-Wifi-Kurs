using System;
using System.Drawing;
using System.Windows.Forms;

namespace Textfelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAusgabe_Click(object sender, EventArgs e)
        {
            lblAusgabe.Text = "Sie haben '" +
                txtEingabe.Text + "' eingegeben";
        }

        private void cmdRechnen_Click(object sender, EventArgs e)
        {
            double wert;
            wert = Convert.ToDouble(txtEingabe.Text);
            wert = wert * 2;
            lblAusgabe.Text = "Ergebnis: " + wert;
        }
    }
}
