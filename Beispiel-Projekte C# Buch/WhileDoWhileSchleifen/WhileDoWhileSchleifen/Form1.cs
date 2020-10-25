using System;
using System.Drawing;
using System.Windows.Forms;

namespace WhileDoWhileSchleifen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void cmdWhile_Click(object sender, EventArgs e)
        {
            int summe = 0, z;
            lblA.Text = "";

            while (summe < 20)
            {
                z = r.Next(1, 7);
                summe = summe + z;
                lblA.Text += summe + "\n";
            }
        }

        private void cmdDoWhile_Click(object sender, EventArgs e)
        {
            int summe = 0, z;
            lblA.Text = "";

            do
            {
                z = r.Next(1, 7);
                summe = summe + z;
                lblA.Text += summe + "\n";
            }
            while (summe < 20);
        }
}
}
