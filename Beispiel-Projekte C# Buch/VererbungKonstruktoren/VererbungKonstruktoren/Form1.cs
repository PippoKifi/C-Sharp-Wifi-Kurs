using System;
using System.Drawing;
using System.Windows.Forms;

namespace VererbungKonstruktoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            PKW fiat = new PKW("Limousine", 50, 2);
            PKW peugeot = new PKW();
            lblAnzeige.Text = fiat.ausgabe() +
                "\n" + peugeot.ausgabe();
        }
    }
}
