using System;
using System.Drawing;
using System.Windows.Forms;

namespace Steuerelemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPositionRel_Click(object sender, EventArgs e)
        {
            cmdTest.Location = new Point(
                cmdTest.Location.X + 20,
                cmdTest.Location.Y);
        }

        private void cmdPositionAbs_Click(object sender, EventArgs e)
        {
            cmdTest.Location = new Point(100, 200);
        }

        private void cmdGrößeRel_Click(
            object sender, EventArgs e)
        {
            cmdTest.Size = new Size(
                cmdTest.Size.Width + 20,
                cmdTest.Size.Height);
        }

        private void cmdGrößeAbs_Click(
            object sender, EventArgs e)
        {
            cmdTest.Size = new Size(50, 100);
        }

        private void cmdFarbe_Click(
            object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            lblAnzeige.BackColor =
                Color.FromArgb(192, 255, 0);
        }

        private void cmdAnzeige_Click(
            object sender, EventArgs e)
        {
            lblAnzeige.Text =
                 "Position: X: " + cmdTest.Location.X +
                 ", Y: " + cmdTest.Location.Y + "\n" +
                 "Größe: Breite: " + cmdTest.Size.Width +
                 ", Höhe: " + cmdTest.Size.Height;
        }
    }
}
