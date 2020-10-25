using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZeichnenGrundformen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics z;
        Pen stift = new Pen(Color.Red, 2);
        SolidBrush pinsel = new SolidBrush(Color.Red);

        private void Form1_Load(object sender, EventArgs e)
        {
            z = CreateGraphics();

            lstFarbe.Items.Add("Rot");
            lstFarbe.Items.Add("Grün");
            lstFarbe.Items.Add("Blau");
            lstFarbe.SelectedIndex = 0;
        }

        private void cmdLinie_Click(object sender, EventArgs e)
        {
            z.DrawLine(stift, 100, 40, 100, 60);
        }

        private void cmdRechteck_Click(object sender, EventArgs e)
        {
            if (chkFüllen.Checked)
            {
                z.FillRectangle(pinsel, 10, 10, 180, 180);
                chkFüllen.Checked = false;
            }
            else
                z.DrawRectangle(stift, 10, 10, 180, 180);
        }

        private void cmdPolygon_Click(object sender, EventArgs e)
        {
            Point[] point_feld =
                    {new Point(90, 80),
                     new Point(110, 80),
                     new Point(100, 120)};

            if (chkFüllen.Checked)
            {
                z.FillPolygon(pinsel, point_feld);
                chkFüllen.Checked = false;
            }
            else
                z.DrawPolygon(stift, point_feld);
        }

        private void cmdEllipse_Click(object sender, EventArgs e)
        {
            if (chkFüllen.Checked)
            {
                z.FillEllipse(pinsel, 10, 10, 180, 180);
                chkFüllen.Checked = false;
            }
            else
                z.DrawEllipse(stift, 10, 10, 180, 180);
        }

        private void numPenWidth_ValueChanged(object sender, EventArgs e)
        {
            stift.Width = (float)numPenWidth.Value;
        }

        private void lstFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color[] color_feld = { Color.Red, Color.Green, Color.Blue };

            stift.Color =
                color_feld[lstFarbe.SelectedIndex];
            pinsel.Color =
                color_feld[lstFarbe.SelectedIndex];
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            z.Clear(BackColor);
        }
    }
}
