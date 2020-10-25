using System;
using System.Drawing;
using System.Windows.Forms;

namespace Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdOben_Click(object sender, EventArgs e)
        {
            p.Location = new Point(
                p.Location.X, p.Location.Y - 10);
        }

        private void cmdLinks_Click(object sender, EventArgs e)
        {
            p.Location = new Point(
                p.Location.X - 10, p.Location.Y);
        }

        private void cmdRechts_Click(object sender, EventArgs e)
        {
            p.Location = new Point(
                p.Location.X + 10, p.Location.Y);
        }

        private void cmdUnten_Click(object sender, EventArgs e)
        {
            p.Location = new Point(
                p.Location.X, p.Location.Y + 10);
        }
    }
}
