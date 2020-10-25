using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatenfeldEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int i;

            int[] a;
            a = new int[7];

            lstFeld.Items.Clear();
            for (i = 0; i < 7; i++)
            {
                a[i] = r.Next(20, 31);
                lstFeld.Items.Add(a[i]);
            }
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] a = new int[7];
            int MaxWert, MinWert, i,
                MaxWertIndex, MinWertIndex;

            lstFeld.Items.Clear();
            for (i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                lstFeld.Items.Add(a[i]);
            }

            /* Max/Min initialisieren */
            MaxWert = a[0];
            MinWert = a[0];
            MaxWertIndex = 0;
            MinWertIndex = 0;

            /* Max/Min suchen */
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] > MaxWert)
                {
                    MaxWert = a[i];
                    MaxWertIndex = i;
                }

                if (a[i] < MinWert)
                {
                    MinWert = a[i];
                    MinWertIndex = i;
                }
            }

            /* Max/Min ausgeben */
            lblAnzeige.Text = "Max. Wert: " + MaxWert +
                " bei Index " + MaxWertIndex + "\n" +
                "Min. Wert: " + MinWert +
                " bei Index " + MinWertIndex;
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int[] a = new int[7], b = new int[7];
            int SuchIndex, i;

            for (i = 0; i < a.Length; i++)
                a[i] = r.Next(20, 31);

            b = (int[])a.Clone();

            Array.Sort(b);

            lstFeld.Items.Clear();
            for (i = 0; i < a.Length; i++)
                lstFeld.Items.Add(b[i]);

            SuchIndex = Array.IndexOf(b, 25);
            lblAnzeige.Text = "Gesuchter Wert 25" +
                " bei Index: " + SuchIndex;
        }
    }
}
