using System;
using System.Drawing;
using System.Windows.Forms;

namespace StringGrundlagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLänge_Click(object sender, EventArgs e)
        {
            string eingabe, anzeige;
            eingabe = txtEingabe.Text;

            anzeige = "Länge: " + eingabe.Length;
            lblAnzeige.Text = anzeige;
            /* lblAnzeige.Text = "Länge: " +
               txtEingabe.Text.Length; */
        }

        private void cmdZeichen_Click(object sender, EventArgs e)
        {
            string eingabe, anzeige;
            char zeichen;
            int i;
            eingabe = txtEingabe.Text;

            anzeige = "Zeichen:" + "\n";
            for (i = 0; i < eingabe.Length; i++)
            {
                zeichen = eingabe[i];
                anzeige += i + ": " + zeichen + "\n";
            }
            lblAnzeige.Text = anzeige;
        }

        private void cmdTrimmen_Click(object sender, EventArgs e)
        {
            string eingabe, getrimmt, anzeige;
            eingabe = txtEingabe.Text;

            getrimmt = eingabe.Trim(' ', ';', '#');
            anzeige = "Getrimmt: |" + getrimmt + "|";
            lblAnzeige.Text = anzeige;
        }

        private void cmdSplitten_Click(object sender, EventArgs e)
        {
            string eingabe = txtEingabe.Text;
            string[] teil;
            int i;

            teil = eingabe.Split(';');
            lblAnzeige.Text = "Worte:" + "\n";
            for (i = 0; i < teil.Length; i++)
                lblAnzeige.Text += "Wort " +
                    i + ": " + teil[i] + "\n";
        }

        private void cmdSucheEins_Click(object sender, EventArgs e)
        {
            string eingabe, such, anzeige;
            int position;

            eingabe = txtEingabe.Text;
            such = txtSuche.Text;
            position = eingabe.IndexOf(such);

            anzeige = "Suchtext bei Zeichen: " + position;
            lblAnzeige.Text = anzeige;
        }

        private void cmdSucheAlle_Click(object sender, EventArgs e)
        {
            string eingabe, such, anzeige;
            int position, suchstart = 0, anzahl = 0;

            eingabe = txtEingabe.Text;
            such = txtSuche.Text;

            anzeige = "Suchtext bei Zeichen:" + "\n";
            do
            {
                position = eingabe.IndexOf(such, suchstart);
                suchstart = position + 1;
                if (position != -1)
                {
                    anzeige += position + "\n";
                    anzahl++;
                }
            }
            while (position != -1);

            anzeige += "Anzahl: " + anzahl;
            lblAnzeige.Text = anzeige;
        }
    }
}
