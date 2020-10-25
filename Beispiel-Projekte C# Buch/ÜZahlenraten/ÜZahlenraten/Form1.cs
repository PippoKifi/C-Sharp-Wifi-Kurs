using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜZahlenraten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int zahl = -1;

        private void cmdErzeugen_Click(object sender, EventArgs e)
        {
            zahl = r.Next(1, 101);
        }

        private void cmdPrüfen_Click(object sender, EventArgs e)
        {
            int eingabe;

            if (zahl == -1)
                lblA.Text = "Zuerst eine Zahl erzeugen";
            else
            {
                eingabe = Convert.ToInt32(txtEingabe.Text);

                if (eingabe > zahl)
                    lblA.Text = "Die Zahl " + eingabe +
                        " ist zu groß";
                else if (eingabe < zahl)
                    lblA.Text = "Die Zahl " + eingabe +
                        " ist zu klein";
                else
                    lblA.Text = eingabe +
                        " ist die richtige Zahl";
            }
        }
    }
}
