using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜPanelZeitgeber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            tim1.Enabled = true;
        }

        private void tim1_Tick(object sender, EventArgs e)
        {
            pan1.Location = new Point(
                pan1.Location.X - 5, pan1.Location.Y - 5);
            pan2.Location = new Point(
                pan2.Location.X + 5, pan2.Location.Y - 5);
            pan3.Location = new Point(
                pan3.Location.X - 5, pan3.Location.Y + 5);
            pan4.Location = new Point(
                pan4.Location.X + 5, pan4.Location.Y + 5);
        }
    }
}
