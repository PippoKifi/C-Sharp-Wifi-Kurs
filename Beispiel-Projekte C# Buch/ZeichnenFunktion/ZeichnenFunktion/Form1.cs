using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZeichnenFunktion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdZeichnen_Click(object sender, EventArgs e)
        {
            Graphics z = CreateGraphics();
            Pen stift;
            Point start, ende;

            stift = new Pen(Color.Black, 2);
            z.DrawLine(stift,
                new Point(20, 120), new Point(380, 120));
            z.DrawLine(stift,
                new Point(20, 220), new Point(20, 20));

            stift = new Pen(Color.Blue, 2);
            start = new Point(20, 120);
            for (int i = 1; i <= 360; i++)
            {
                ende = new Point(20 + i, 120 -
                    (int)(Math.Sin(i * Math.PI / 180) * 100));
                z.DrawLine(stift, start, ende);
                start = ende;
            }

            stift = new Pen(Color.LightGray, 2);
            start = new Point(20, 20);
            for (int i = 1; i <= 360; i++)
            {
                ende = new Point(20 + i, 120 -
                    (int)(Math.Cos(i * Math.PI / 180) * 100));
                z.DrawLine(stift, start, ende);
                start = ende;
            }
        }
    }
}
