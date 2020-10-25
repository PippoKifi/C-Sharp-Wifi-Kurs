using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eigenschaftsmethode
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
            lblAnzeige.Text = "Geschwindigkeit: " +
                vespa.Geschwindigkeit;
            vespa.beschleunigen(120);
            // vespa.Geschwindigkeit = 50;
            lblAnzeige.Text += "\nGeschwindigkeit: " +
                vespa.Geschwindigkeit;
        }
    }
}
