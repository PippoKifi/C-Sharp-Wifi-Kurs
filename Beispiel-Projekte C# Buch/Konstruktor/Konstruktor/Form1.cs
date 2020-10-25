using System;
using System.Drawing;
using System.Windows.Forms;

namespace Konstruktor
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
            Fahrzeug schwalbe = new Fahrzeug("Moped");
            Fahrzeug yamaha = new Fahrzeug(50);
            Fahrzeug honda = new Fahrzeug("Motorrad", 75);

            lblAnzeige.Text = vespa.ausgabe() + "\n" +
                schwalbe.ausgabe() + "\n" +
                yamaha.ausgabe() + "\n" +
                honda.ausgabe();
        }
    }
}
