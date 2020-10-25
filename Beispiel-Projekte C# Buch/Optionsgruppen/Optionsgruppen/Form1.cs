using System;
using System.Drawing;
using System.Windows.Forms;

namespace Optionsgruppen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string AusgabeUrlaubsort = "Berlin";
        string AusgabeUnterkunft = "Pension";

        private void optUrlaubsort_CheckedChanged(object sender, EventArgs e)
        {
            // Urlaubsort
            if (optBerlin.Checked)
                AusgabeUrlaubsort = "Berlin";
            else if (optParis.Checked)
                AusgabeUrlaubsort = "Paris";
            else
                AusgabeUrlaubsort = "Rom";

            lblAnzeige.Text = AusgabeUrlaubsort +
                ", " + AusgabeUnterkunft;
        }

        private void optUnterkunft_CheckedChanged(object sender, EventArgs e)
        {
            // Unterkunft
            if (optAppartement.Checked)
                AusgabeUnterkunft = "Appartement";
            else if (optPension.Checked)
                AusgabeUnterkunft = "Pension";
            else
                AusgabeUnterkunft = "Hotel";

            lblAnzeige.Text = AusgabeUrlaubsort +
                ", " + AusgabeUnterkunft;
        }
    }
}
