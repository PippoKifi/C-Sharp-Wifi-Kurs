using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ereigniskette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdEreignis1_Click(object sender, EventArgs e)
        {
            lblAnzeige1.Text = "Eins";
        }

        private void cmdEreignis2_Click(object sender, EventArgs e)
        {
            lblAnzeige2.Text = "Zwei";
        }

        private void cmdEreignis3_Click(object sender, EventArgs e)
        {
            cmdEreignis1_Click(sender, e);
            cmdEreignis2_Click(sender, e);
        }

        private void cmdLöschen_Click(object sender, EventArgs e)
        {
            lblAnzeige1.Text = "";
            lblAnzeige2.Text = "";
        }
    }
}
