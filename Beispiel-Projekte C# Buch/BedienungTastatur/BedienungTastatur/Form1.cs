using System;
using System.Drawing;
using System.Windows.Forms;

namespace BedienungTastatur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBestellen_Click(object sender, EventArgs e)
        {
            txtEingabe1.Text = "Bestellen gedrückt";
        }
    }
}
