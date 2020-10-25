using System;
using System.Drawing;
using System.Windows.Forms;

namespace Datentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeige_Click(object sender, EventArgs e)
        {
            /* ganze Zahlen */
            byte By;
            short Sh;
            int It;
            long Lg;

            /* Zahlen mit Nachkommastellen */
            double Db1, Db2;
            float Fl;
            decimal De;

            /* Boolesche Variable, Zeichen, Zeichenkette */
            bool Bo;
            char Ch;
            string St;

            By = 200;
            Sh = 30000;
            It = 2000000000;
            Lg = 3000000000;

            Db1 = 1 / 7;
            Db2 = 1.0 / 7;
            Fl = 1.0f / 7;
            De = 1.0m / 7;

            Bo = true;
            Ch = 'a';
            St = "Zeichenkette";

            lblAnzeige.Text =
               "byte: " + By + "\n" +
               "short: " + Sh + "\n" +
               "int: " + It + "\n" +
               "long: " + Lg + "\n" +
               "double 1: " + Db1 + "\n" +
               "double 2: " + Db2 + "\n" +
               "float: " + Fl + "\n" +
               "decimal: " + De + "\n" +
               "bool: " + Bo + "\n" +
               "char: " + Ch + "\n" +
               "string: " + St;
        }
    }
}
