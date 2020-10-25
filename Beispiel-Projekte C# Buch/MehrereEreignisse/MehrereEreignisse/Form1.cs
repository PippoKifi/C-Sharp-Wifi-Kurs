using System;
using System.Drawing;
using System.Windows.Forms;

namespace MehrereEreignisse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void optFarbeGewechselt(object sender, EventArgs e)
        {
            if (optFarbeRot.Checked)
                lblAnzeige.Text = "Rot";
            else if (optFarbeGrün.Checked)
                lblAnzeige.Text = "Grün";
            else
                lblAnzeige.Text = "Blau";
        }
    }
}
