using System;
using System.Drawing;
using System.Windows.Forms;

namespace MethodenRückgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 12;
            b = 17;
            c = MaxWert(a, b);
            lblA.Text = "Maximum: " + c;
        }

        private int MaxWert(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
    }
}
