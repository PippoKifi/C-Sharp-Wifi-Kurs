using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeichnenText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics z;
        Font f = new Font("Arial", 16);
        SolidBrush pinsel = new SolidBrush(Color.Red);

        private void Form1_Load(object sender, EventArgs e)
        {
            z = CreateGraphics();

            lstSchriftart.Items.Add("Arial");
            lstSchriftart.Items.Add("Courier New");
            lstSchriftart.Items.Add("Symbol");
            lstSchriftart.SelectedIndex = 0;

            lstFarbe.Items.Add("Rot");
            lstFarbe.Items.Add("Grün");
            lstFarbe.Items.Add("Blau");
            lstFarbe.SelectedIndex = 0;
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            z.DrawString(txtE.Text, f, pinsel, 20, 20);
        }

        private void lstSchriftart_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = new Font(lstSchriftart.Text, f.Size);
        }

        private void numSchriftgröße_ValueChanged(object sender, EventArgs e)
        {
            f = new Font(f.FontFamily,
                (float)numSchriftgröße.Value);
        }

        private void lstFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color[] color_feld = { Color.Red, Color.Green, Color.Blue };
            pinsel.Color =
                color_feld[lstFarbe.SelectedIndex];
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            z.Clear(BackColor);
        }
    }
}
