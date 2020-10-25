using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            string nachname, vorname,
                strasse, plz, ort;
            int alter;
            double gehalt;

            nachname = "Clever";
            vorname = "Claus";
            strasse = "Bergstraße 34";
            plz = "09445";
            ort = "Brunnstadt";
            alter = 32;
            gehalt = 2852.55;

            lblA.Text = "Adresse: " + "\n" + vorname +
                " " + nachname + "\n" + strasse +
                "\n" + plz + " " + ort + "\n" +
                "\n" + "Alter: " + alter +
                "\n" + "Gehalt: " + gehalt;
        }
    }
}
