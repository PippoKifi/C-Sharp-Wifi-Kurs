using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReferenzenVergleicheTypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdReferenzZuweisen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Moped", 50);
            Fahrzeug schwalbe;
            schwalbe = vespa;
            MessageBox.Show(vespa.ausgabe()
                + " / " + schwalbe.ausgabe());
            vespa.beschleunigen(35);
            MessageBox.Show(vespa.ausgabe()
                + " / " + schwalbe.ausgabe());
        }

        private void cmdReferenzenVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            Fahrzeug schwalbe = new Fahrzeug("Roller", 35);

            if (ReferenceEquals(vespa, schwalbe))
                MessageBox.Show("Die beiden Objekt" +
                    "verweise zeigen auf dasselbe Objekt");
            else
                MessageBox.Show("Die beiden Objekt" +
                    "verweise zeigen nicht auf dasselbe Objekt");
        }

        private void cmdObjekteVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            Fahrzeug schwalbe = new Fahrzeug("Roller", 35);

            if (vespa.Equals(schwalbe))
                MessageBox.Show("Die beiden Objekte" +
                    " sind gleich");
            else
                MessageBox.Show("Die beiden Objekte" +
                " sind nicht gleich");
        }

        private void cmdKlasseErmitteln_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);

            MessageBox.Show("Objekt vespa ist vom Typ " + vespa.GetType().ToString());
            MessageBox.Show("Die Klasse heißt " + typeof(Fahrzeug));

            MessageBox.Show("Der Button ist vom Typ " + cmdKlasseErmitteln.GetType().ToString());
            MessageBox.Show("Die Klasse heißt " + typeof(Button));
        }

        private void cmdKlasseVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);

            if (vespa is Fahrzeug)
                MessageBox.Show("Objekt vespa ist vom Typ Fahrzeug");

            if (cmdKlasseErmitteln is Button)
                MessageBox.Show("Objekt cmdKlasseErmitteln" +
                    " ist vom Typ Button");
        }
    }
}
