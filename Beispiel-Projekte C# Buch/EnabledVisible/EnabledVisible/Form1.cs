using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnabledVisible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEingabe_TextChanged(object sender, EventArgs e)
        {
            if (txtEingabe1.Text != "" &&
                    txtEingabe2.Text != "")
            {
                cmdRechnen1.Enabled = true;
                cmdRechnen2.Visible = true;
            }
            else
            {
                cmdRechnen1.Enabled = false;
                cmdRechnen2.Visible = false;
            }
        }

        private void cmdRechnen_Click(object sender, EventArgs e)
        {
            try
            {
                lblAusgabe.Text = "Ergebnis: " +
                    (Convert.ToInt32(txtEingabe1.Text) +
                    Convert.ToInt32(txtEingabe2.Text));
            }
            catch
            {
                lblAusgabe.Text = "0";
            }
        }
    }
}
