using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRechnen_Click(object sender, EventArgs e)
        {
            int x, y, z;

            try
            {
                x = Convert.ToInt32(txtEingabe1.Text);
                y = Convert.ToInt32(txtEingabe2.Text);
                z = x / y;
                lblAusgabe.Text = "Ergebnis: " + z;
            }
            catch (Exception ex)
            {
                lblAusgabe.Text =
                    "Fehler: " + ex.Message;
            }
        }
    }
}
