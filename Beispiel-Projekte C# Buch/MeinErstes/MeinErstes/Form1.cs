using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeinErstes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdHallo_Click(object sender, EventArgs e)
        {
            // Diese Anweisung setzt den Text in das Label
            lblAnzeige.Text = "Hallo";
        }

        private void cmdEnde_Click(object sender, EventArgs e)
        {
            /* Diese Anweisung beendet
               das Programm */
            Close();
        }
    }
}
