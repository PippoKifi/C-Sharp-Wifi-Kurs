using System;
using System.Drawing;
using System.Windows.Forms;

using Print1 = Microsoft.VisualBasic.PowerPacks.Printing;
using Print2 = System.Drawing.Printing;

namespace Drucken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdDrucken_Click(object sender, EventArgs e)
        {
            Print1.PrintForm pf = new Print1.PrintForm();
            pf.Form = this;
            pf.PrintAction = Print2.PrintAction.PrintToPrinter;
            pf.Print();
        }

        private void cmdSeitenvorschau_Click(object sender, EventArgs e)
        {
            Print1.PrintForm pf = new Print1.PrintForm();
            pf.Form = this;
            pf.PrintAction = Print2.PrintAction.PrintToPreview;
            pf.Print();
        }

        private void cmdInfo_Click(object sender, EventArgs e)
        {
            Print1.PrintForm pf = new Print1.PrintForm();
            String ausgabe;

            pf.PrinterSettings.FromPage = 2;
            pf.PrinterSettings.ToPage = 4;
            pf.PrinterSettings.Copies = 2;

            ausgabe = pf.PrinterSettings.PrinterName + "\n";
            if (pf.PrinterSettings.SupportsColor)
                ausgabe += "Ist ein Farbdrucker" + "\n";
            else
                ausgabe += "Ist kein Farbdrucker" + "\n";

            ausgabe += "Druckt von Seite " +
                pf.PrinterSettings.FromPage + " bis " +
                pf.PrinterSettings.ToPage + "\n";
            ausgabe += "Anzahl Kopien: " +
                pf.PrinterSettings.Copies + "\n";
            ausgabe += "Höhe in cm " +
                pf.PrinterSettings.DefaultPageSettings.
                PaperSize.Height * 2.54 / 100 + "\n";
            ausgabe += "Breite in cm " +
                pf.PrinterSettings.DefaultPageSettings.
                PaperSize.Width * 2.54 / 100 + "\n";

            MessageBox.Show(ausgabe);
        }
    }
}
