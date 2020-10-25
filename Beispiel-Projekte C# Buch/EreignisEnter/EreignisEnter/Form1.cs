using System;
using System.Drawing;
using System.Windows.Forms;

namespace EreignisEnter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstPaketdienst.Items.Add("DHL");
            lstPaketdienst.Items.Add("Hermes");
            lstPaketdienst.Items.Add("UPS");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lblHilfe.Text = "";
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            lblHilfe.Text =
                "Bitte geben Sie Nachname, Vorname ein";
        }

        private void chkKunde_Enter(object sender, EventArgs e)
        {
            lblHilfe.Text = "Kreuzen Sie hier an," +
                " ob Sie bereits Kunde sind";
        }

        private void lstPaketdienst_Enter(object sender, EventArgs e)
        {
            lblHilfe.Text = "Wählen Sie Ihren" +
                " bevorzugten Paketdienst aus";
        }

        private void optZahlungsform_CheckedChanged(object sender, EventArgs e)
        {
            lblHilfe.Text =
                "Wählen Sie Ihre Zahlungsform aus";
        }
    }
}
