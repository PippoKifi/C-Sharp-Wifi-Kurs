using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kontrollkästchen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPrüfen_Click(object sender, EventArgs e)
        {
            if (chkSchalter.Checked)
                lblTest1.Text = "An";
            else
                lblTest1.Text = "Aus";
        }

        private void chkSchalter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSchalter.Checked)
                lblTest2.Text = "An";
            else
                lblTest2.Text = "Aus";
        }

        private void cmdUmschalten_Click(object sender, EventArgs e)
        {
            chkSchalter.Checked = !chkSchalter.Checked;
        }
    }
}
