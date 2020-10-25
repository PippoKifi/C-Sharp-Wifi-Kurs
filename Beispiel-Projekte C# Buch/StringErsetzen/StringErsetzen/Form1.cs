using System;
using System.Drawing;
using System.Windows.Forms;

namespace StringErsetzen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdErsetzen_Click(object sender, EventArgs e)
        {
            string eingabe, suchen, ersetzen, anzeige;

            eingabe = txtEingabe.Text;
            suchen = txtSuchen.Text;
            ersetzen = txtErsetzen.Text;

            anzeige = eingabe.Replace(suchen, ersetzen);
            lblAnzeige.Text = anzeige;
        }
    }
}
