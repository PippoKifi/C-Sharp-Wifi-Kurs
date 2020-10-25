using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜDatenfeldEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void cmdMinima_Click(object sender, EventArgs e)
        {
            int[] a = new int[10];
            int MinWert, i;

            /* Feld füllen */
            lstZahl.Items.Clear();
            for (i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                lstZahl.Items.Add(a[i]);
            }

            MinWert = a[0];
            for (i = 0; i < a.Length; i++)
                if (a[i] < MinWert)
                    MinWert = a[i];

            lblA.Text = "Minimum: " + MinWert +
                ", an Position:" + "\n";
            for (i = 0; i < a.Length; i++)
                if (a[i] == MinWert)
                    lblA.Text += i + "\n";
        }
    }
}
