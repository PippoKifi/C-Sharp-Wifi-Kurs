using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜSteuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBerechnen_Click(object sender, EventArgs e)
        {
            double gehalt, steuersatz, steuerbetrag;
            gehalt = Convert.ToDouble(txtGehalt.Text);

            if (gehalt <= 12000)
                steuersatz = 12;
            else if (gehalt <= 20000)
                steuersatz = 15;
            else if (gehalt <= 30000)
                steuersatz = 20;
            else
                steuersatz = 25;

            steuerbetrag = gehalt * steuersatz / 100;
            lblSteuerbetrag.Text =
                "Steuerbetrag: " + steuerbetrag;
        }
    }
}
