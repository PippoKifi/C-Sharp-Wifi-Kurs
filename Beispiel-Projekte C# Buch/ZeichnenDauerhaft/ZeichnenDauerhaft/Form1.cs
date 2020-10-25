using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace ZeichnenDauerhaft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics z;
            Pen stift = new Pen(Color.Red, 2);
            Font f = new Font("Arial", 16);
            SolidBrush pinsel = new SolidBrush(Color.Red);
            Image bild;
            string filename;

            /* Holt Grafik-Objekt zum Zeichnen */
            z = e.Graphics;

            /* Rechteck, Text */
            z.DrawRectangle(stift, 20, 20, 30, 60);
            z.DrawString("Hallo", f, pinsel, 70, 20);

            /* Bild */
            filename = "namibia.gif";
            if (File.Exists(filename))
            {
                bild = Image.FromFile(filename);
                z.DrawImage(bild, 70, 70);
            }
            else
                MessageBox.Show("Datei nicht vorhanden");
        }
    }
}
