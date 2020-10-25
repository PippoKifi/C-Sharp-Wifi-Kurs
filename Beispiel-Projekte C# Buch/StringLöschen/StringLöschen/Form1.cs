using System;
using System.Drawing;
using System.Windows.Forms;

namespace StringLöschen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLöschen_Click(object sender, EventArgs e)
        {
            string eingabe, anzeige;
            eingabe = txtEingabe.Text;

            anzeige = eingabe.Remove(
                (int)numPosition.Value,
                (int)numAnzahl.Value);
            lblAnzeige.Text = anzeige;
        }

        private void txtEingabe_TextChanged(object sender, EventArgs e)
        {
            string eingabe = txtEingabe.Text;
            numAnzahl.Maximum = eingabe.Length;
            numPosition.Maximum = eingabe.Length - 1;
        }

        private void numPosition_ValueChanged(object sender, EventArgs e)
        {
            string eingabe = txtEingabe.Text;
            numAnzahl.Maximum =
                eingabe.Length - numPosition.Value;
        }
    }
}
