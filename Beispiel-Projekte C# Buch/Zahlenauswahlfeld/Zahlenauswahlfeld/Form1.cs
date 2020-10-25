using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zahlenauswahlfeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numEingabe_ValueChanged(object sender, EventArgs e)
        {
            lblAusgabe.Text = "Wert: " + numEingabe.Value;
        }
    }
}
