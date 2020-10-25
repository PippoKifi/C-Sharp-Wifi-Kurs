using System;
using System.Drawing;
using System.Windows.Forms;

namespace StringFormatieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeige_Click(object sender, EventArgs e)
        {
            int i;
            string format;
            string ausgabe;
            string[] stadt = {"München", "Berlin",
                "Bonn", "Bremerhaven", "Ulm"};

            lstA.Items.Clear();
            lblA.Text = "";
            format = "{0,-15}{1,9:0.0000}{2,12:#,##0.0}";

            for (i = 0; i < 5; i++)
            {
                ausgabe = String.Format(format,
                    stadt[i], i / 7.0, i * 1e4 / 7);
                lstA.Items.Add(ausgabe);
                lblA.Text += ausgabe + "\n";
            }
        }
    }
}
