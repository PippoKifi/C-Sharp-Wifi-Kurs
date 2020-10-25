using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜKran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdHakenAus_Click(object sender, EventArgs e)
        {
            h.Height = h.Height + 10;
        }

        private void cmdHakenEin_Click(object sender, EventArgs e)
        {
            h.Height = h.Height - 10;
        }

        private void cmdAuslegerAus_Click(object sender, EventArgs e)
        {
            a.Width = a.Width + 10;
            a.Location = new Point(
                a.Location.X - 10, a.Location.Y);
            h.Location = new Point(
                h.Location.X - 10, h.Location.Y);
        }

        private void cmdAuslegerEin_Click(object sender, EventArgs e)
        {
            a.Width = a.Width - 10;
            a.Location = new Point(
                a.Location.X + 10, a.Location.Y);
            h.Location = new Point(
                h.Location.X + 10, h.Location.Y);
        }

        private void cmdKranRechts_Click(object sender, EventArgs e)
        {
            f.Location = new Point(
                f.Location.X + 10, f.Location.Y);
            s.Location = new Point(
                s.Location.X + 10, s.Location.Y);
            a.Location = new Point(
                a.Location.X + 10, a.Location.Y);
            h.Location = new Point(
                h.Location.X + 10, h.Location.Y);
        }

        private void cmdKranLinks_Click(object sender, EventArgs e)
        {
            f.Location = new Point(
                f.Location.X - 10, f.Location.Y);
            s.Location = new Point(
                s.Location.X - 10, s.Location.Y);
            a.Location = new Point(
                a.Location.X - 10, a.Location.Y);
            h.Location = new Point(
                h.Location.X - 10, h.Location.Y);
        }

        private void cmdKranAus_Click(object sender, EventArgs e)
        {
            s.Height = s.Height + 10;
            s.Location = new Point(
                s.Location.X, s.Location.Y - 10);
            a.Location = new Point(
                a.Location.X, a.Location.Y - 10);
            h.Location = new Point(
                h.Location.X, h.Location.Y - 10);
        }

        private void cmdKranEin_Click(object sender, EventArgs e)
        {
            s.Height = s.Height - 10;
            s.Location = new Point(
                s.Location.X, s.Location.Y + 10);
            a.Location = new Point(
                a.Location.X, a.Location.Y + 10);
            h.Location = new Point(
                h.Location.X, h.Location.Y + 10);
        }
    }
}
