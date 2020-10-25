using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜSteuertabelle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            double gehalt, steuersatz, steuerbetrag, netto;

            lblA.Text = "";
            for (gehalt = 5000; gehalt <= 35000; gehalt = gehalt + 3000)
            {
                if (gehalt <= 12000)
                    steuersatz = 12;
                else if (gehalt <= 20000)
                    steuersatz = 15;
                else if (gehalt <= 30000)
                    steuersatz = 20;
                else
                    steuersatz = 25;

                steuerbetrag = gehalt * steuersatz / 100;
                netto = gehalt - steuerbetrag;

                lblA.Text += gehalt + " €, " +
                    steuersatz + " %, " +
                    steuerbetrag + " €, " +
                    netto + " €" + "\n";
            }
        }
    }
}
