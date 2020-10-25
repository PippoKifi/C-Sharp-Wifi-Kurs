using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kombinationsfeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbWerkzeug1.Items.Add("Zange");
            cmbWerkzeug1.Items.Add("Hammer");
            cmbWerkzeug1.Items.Add("Bohrer");
            cmbWerkzeug1.Items.Add("Schraubendreher");

            cmbWerkzeug2.Items.Add("Zange");
            cmbWerkzeug2.Items.Add("Hammer");
            cmbWerkzeug2.Items.Add("Bohrer");
            cmbWerkzeug2.Items.Add("Schraubendreher");

            cmbWerkzeug3.Items.Add("Zange");
            cmbWerkzeug3.Items.Add("Hammer");
            cmbWerkzeug3.Items.Add("Bohrer");
            cmbWerkzeug3.Items.Add("Schraubendreher");
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            lblAnzeige1.Text =
                "Auswahl: " + cmbWerkzeug1.Text;
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            lblAnzeige2.Text =
                "Auswahl: " + cmbWerkzeug2.SelectedItem;
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            lblAnzeige3.Text =
                "Auswahl: " + cmbWerkzeug3.Text;
        }
    }
}
