using System;
using System.Drawing;    
using System.Windows.Forms;

namespace StatischeElemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            Zahl x = new Zahl(2.5);
            Zahl p = new Zahl(-5);
            double y, r;

            /* Objektbezogene Methoden */
            x.maldrei();
            lblAnzeige.Text = x.ausgabe() + "\n" +
                p.ausgabe();

            /* Klassenbezogene Methode */
            y = 4;
            lblAnzeige.Text += "\n" + "Zahl: " + y +
                "\n" + "Nach Verdopplung: " +
                Zahl.verdoppeln(y);

            /* Klassenbezogene und öffentl. Eigenschaft */
            r = 6;
            lblAnzeige.Text += "\n" + "Radius: " + r +
                "\n" + "Fläche: " + r * r * Zahl.pi;
        }
    }
}
