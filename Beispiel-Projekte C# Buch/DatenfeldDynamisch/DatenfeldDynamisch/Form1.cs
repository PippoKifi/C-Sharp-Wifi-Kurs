using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatenfeldDynamisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int[] a;

        private void cmdOriginal_Click(object sender, EventArgs e)
        {
            a = new int[4];
            int i;

            lstFeld.Items.Clear();
            for (i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                lstFeld.Items.Add(a[i]);
            }
        }

        private void cmdNeu1_Click(object sender, EventArgs e)
        {
            Array.Resize(ref a, 6);
            int i;

            lstFeld.Items.Clear();
            for (i = 0; i < a.Length; i++)
                lstFeld.Items.Add(a[i]);
        }

        private void cmdNeu2_Click(object sender, EventArgs e)
        {
            Array.Resize(ref a, (int)numGröße.Value);
            int i;

            lstFeld.Items.Clear();
            for (i = 0; i < a.Length; i++)
                lstFeld.Items.Add(a[i]);
        }
    }
}
