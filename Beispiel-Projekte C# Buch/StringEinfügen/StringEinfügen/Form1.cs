using System;
using System.Drawing;
using System.Windows.Forms;

namespace StringEinfügen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdEinfügen_Click(object sender, EventArgs e)
        {
            string eingabe, einfügen, anzeige;
            eingabe = txtEingabe.Text;
            einfügen = txtEinfügen.Text;

            anzeige = eingabe.Insert(
                (int)numEinfügen.Value, einfügen);
            lblAnzeige.Text = anzeige;
        }

        private void txtEingabe_TextChanged(object sender, EventArgs e)
        {
            string eingabe;
            eingabe = txtEingabe.Text;
            numEinfügen.Maximum = eingabe.Length;
        }
    }
}
