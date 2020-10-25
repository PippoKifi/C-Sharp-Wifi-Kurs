using System;
using System.Drawing;
using System.Windows.Forms;

namespace StringTeilzeichenkette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            string eingabe, anzeige;

            eingabe = txtEingabe.Text;
            anzeige = eingabe.Substring(
                (int)numPosition.Value,
                (int)numLänge.Value);

            lblAnzeige.Text = anzeige;
        }

        private void txtEingabe_TextChanged(object sender, EventArgs e)
        {
            string eingabe = txtEingabe.Text;
            numPosition.Maximum = eingabe.Length - 1;
            numLänge.Maximum = eingabe.Length;
        }

        private void numPosition_ValueChanged(object sender, EventArgs e)
        {
            string eingabe = txtEingabe.Text;
            numLänge.Maximum =
                eingabe.Length - numPosition.Value;
        }
    }
}
