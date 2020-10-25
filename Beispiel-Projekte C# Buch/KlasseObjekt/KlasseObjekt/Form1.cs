using System;
using System.Drawing;
using System.Windows.Forms;

namespace KlasseObjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa;
            vespa = new Fahrzeug();

            lblAnzeige.Text = vespa.ausgabe();
            vespa.beschleunigen(20);
            lblAnzeige.Text += "\n" + vespa.ausgabe();
            // lblAnzeige.Text = vespa.geschwindigkeit;
        }
    }
}
