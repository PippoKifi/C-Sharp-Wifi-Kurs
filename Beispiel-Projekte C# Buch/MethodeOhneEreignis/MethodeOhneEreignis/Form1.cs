using System;
using System.Drawing;
using System.Windows.Forms;

namespace MethodeOhneEreignis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string AusgabeUrlaubsort = "Berlin";
        string AusgabeUnterkunft = "Pension";

        private void optUrlaubsort(object sender, EventArgs e)
        {
            // Urlaubsort
            if (optBerlin.Checked)
                AusgabeUrlaubsort = "Berlin";
            else if (optParis.Checked)
                AusgabeUrlaubsort = "Paris";
            else
                AusgabeUrlaubsort = "Rom";

            Anzeigen();
        }

        private void optUnterkunft(object sender, EventArgs e)
        {
            // Unterkunft
            if (optAppartement.Checked)
                AusgabeUnterkunft = "Appartement";
            else if (optPension.Checked)
                AusgabeUnterkunft = "Pension";
            else
                AusgabeUnterkunft = "Hotel";

            Anzeigen();
        }

        private void Anzeigen()
        {
            lblAnzeige.Text = AusgabeUrlaubsort +
                ", " + AusgabeUnterkunft;
        }

    }
}
