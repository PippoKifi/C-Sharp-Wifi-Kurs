using System;
using System.Drawing;
using System.Windows.Forms;

namespace Konstanten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MaxWert = 75;
        const string Eintrag = "Picture";

        enum Farbe : int
        {
            Rot = 1,
            Gelb = 2,
            Blau = 3
        }

        private void cmdKonstanten_Click(object sender, EventArgs e)
        {
            const int MaxWert = 55;
            const int MinWert = 5;
            lblAnzeige.Text = (MaxWert - MinWert) / 2 +
                "\n" + Eintrag;
        }

        private void cmdEnumeration1_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "Farbe: " + Farbe.Gelb +
                 " " + (int)Farbe.Gelb;
        }

        private void cmdEnumeration2_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "Sonntag: " +
                DayOfWeek.Sunday + " " +
                (int)DayOfWeek.Sunday + "\n" +
                "Samstag: " +
                DayOfWeek.Saturday + " " +
                (int)DayOfWeek.Saturday;
        }
    }
}
