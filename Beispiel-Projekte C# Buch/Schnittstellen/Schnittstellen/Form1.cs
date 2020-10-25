using System;
using System.Drawing;
using System.Windows.Forms;

namespace Schnittstellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            kreis k1 = new kreis("rot", 20);
            lblA.Text = k1.aus();

            k1.faerben("gelb");
            k1.vergroessern(1.5);
            lblA.Text += "\n" + k1.aus();

            kreis k2 = (kreis)k1.Clone();
            lblA.Text += "\n" + k2.aus();
        }
    }
}
