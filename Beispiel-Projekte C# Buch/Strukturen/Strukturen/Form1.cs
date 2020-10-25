using System;
using System.Drawing;
using System.Windows.Forms;

namespace Strukturen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            /* Objekte ohne Daten */
            kontakt x, y;

            /* Zuweisung */
            x.plz = 43024;
            x.ort = "Aachen";
            x.strasse = "Hunsrückweg";
            x.hausnummer = 104;
            x.tel.vorwahl = "0466";
            x.tel.nummer = 532626;
            x.fax.vorwahl = "0466";
            x.fax.nummer = 532627;

            /* Kopie aller Werte */
            y = x;

            /* Ausgabe */
            lblA.Text = y.aus();

            /* Objekte mit Daten */
            kontakt z = new kontakt(
                43035, "Düren", "Eifelweg", 12,
                new telefon("0463", 887743),
                new telefon("0463", 887744));
            lblA.Text += "\n\n" + z.aus();
        }
    }
}
