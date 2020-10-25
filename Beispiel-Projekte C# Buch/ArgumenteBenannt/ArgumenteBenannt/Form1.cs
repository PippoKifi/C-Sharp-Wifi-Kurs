using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArgumenteBenannt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            Rechteck("rot", 4, 6, "Punkte");
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            Rechteck("rot", rand: "Striche", breite: 2, laenge: 5);
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            Rechteck("gelb", 7);
        }

        private void cmdAnzeigen4_Click(object sender, EventArgs e)
        {
            Rechteck("blau", rand: "Haarlinie");
        }

        private void Rechteck(string farbe, int laenge = 1,
            int breite = 1, string rand = "Linie")
        {
            lblAnzeige.Text = "Farbe: " + farbe +
                ", Länge: " + laenge +
                ", Breite: " + breite +
                ", Rand: " + rand;
        }
    }
}
