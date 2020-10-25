using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vererbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug();
            PKW fiat = new PKW();

            vespa.beschleunigen(35);
            lblAnzeige.Text = vespa.ausgabe();

            lblAnzeige.Text += "\n" + fiat.ausgabe();
            fiat.einsteigen(3);
            fiat.beschleunigen(30);
            lblAnzeige.Text += "\n" + fiat.ausgabe();
        }
    }
}
