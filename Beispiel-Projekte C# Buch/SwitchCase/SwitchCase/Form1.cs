using System;
using System.Drawing;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;

            switch (x)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    lblA.Text = "einstellig, ungerade";
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    lblA.Text = "einstellig, gerade";
                    break;
                default:
                    lblA.Text = "zweistellig";
                    break;
            }
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            string s = "Nizza";
            lblA.Text = "";

            switch (s)
            {
                case "France":
                    lblA.Text += "Frankreich\n";
                    break;
                case "Bordeaux":
                    lblA.Text += "Atlantik\n";
                    goto case "France";
                case "Nizza":
                    lblA.Text += "Cote d'Azur\n";
                    goto case "France";
                default:
                    lblA.Text += "restliche Fälle\n";
                    break;
            }
        }
    }
}
