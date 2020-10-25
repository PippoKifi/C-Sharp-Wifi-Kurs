using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜKranOptionen
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

        private void cmdStop_Click(object sender, EventArgs e)
        {
            tim1.Enabled = false;
        }

        private void tim1_Tick(object sender, EventArgs e)
        {
            if (optHakenAus.Checked)
                if (h.Location.Y + h.Height + 5 <
                        f.Location.Y)
                    h.Height = h.Height + 10;
                else
                    tim1.Enabled = false;

            else if (optHakenEin.Checked)
                if (h.Height > 15)
                    h.Height = h.Height - 10;
                else
                    tim1.Enabled = false;

            else if (optAuslegerAus.Checked)
                if (a.Location.X > 15)
                {
                    a.Width = a.Width + 10;
                    a.Location = new Point(
                        a.Location.X - 10, a.Location.Y);
                    h.Location = new Point(
                        h.Location.X - 10, h.Location.Y);
                }
                else
                    tim1.Enabled = false;

            else if (optAuslegerEin.Checked)
                if (a.Width > 25)
                {
                    a.Width = a.Width - 10;
                    a.Location = new Point(
                        a.Location.X + 10, a.Location.Y);
                    h.Location = new Point(
                        h.Location.X + 10, h.Location.Y);
                }
                else
                    tim1.Enabled = false;

            else if (optKranRechts.Checked)
                if (f.Location.X < 215)
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
                else
                    tim1.Enabled = false;

            else if (optKranLinks.Checked)
                if (f.Location.X > 15 && a.Location.X > 15)
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
                else
                    tim1.Enabled = false;

            else if (optKranAus.Checked)
                if (s.Location.Y > 15)
                {
                    s.Height = s.Height + 10;
                    s.Location = new Point(
                        s.Location.X, s.Location.Y - 10);
                    a.Location = new Point(
                        a.Location.X, a.Location.Y - 10);
                    h.Location = new Point(
                        h.Location.X, h.Location.Y - 10);
                }
                else
                    tim1.Enabled = false;

            else if (optKranEin.Checked)
                if (h.Location.Y + h.Height + 5 <
                        f.Location.Y)
                {
                    s.Height = s.Height - 10;
                    s.Location = new Point(
                        s.Location.X, s.Location.Y + 10);
                    a.Location = new Point(
                        a.Location.X, a.Location.Y + 10);
                    h.Location = new Point(
                        h.Location.X, h.Location.Y + 10);
                }
                else
                    tim1.Enabled = false;
        }
    }
}
