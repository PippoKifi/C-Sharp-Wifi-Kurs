using System;
using System.Drawing;
using System.Windows.Forms;

namespace Optionen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPrüfen_Click(object sender, EventArgs e)
        {
            if (optFarbeRot.Checked)
                lblAnzeige1.Text = "Rot";
            else if (optFarbeGrün.Checked)
                lblAnzeige1.Text = "Grün";
            else
                lblAnzeige1.Text = "Blau";
        }

        private void optFarbeRot_CheckedChanged(object sender, EventArgs e)
        {
            if (optFarbeRot.Checked)
                lblAnzeige2.Text = "Rot";
        }

        private void optFarbeGrün_CheckedChanged(object sender, EventArgs e)
        {
            if (optFarbeGrün.Checked)
                lblAnzeige2.Text = "Grün";
        }

        private void optFarbeBlau_CheckedChanged(object sender, EventArgs e)
        {
            if (optFarbeBlau.Checked)
                lblAnzeige2.Text = "Blau";
        }

        private void cmdSchalter_Click(object sender, EventArgs e)
        {
            optFarbeRot.Checked = true;
        }
    }
}
