using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogischeOperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLogisch1_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3;
            lblA.Text = "Bedingung: " + !(A < B);
        }

        private void cmdLogisch2_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3, C = 5;
            lblA.Text = "Bedingung: " + ((B > A) && (C > B));
        }

        private void cmdLogisch3_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3, C = 5;
            lblA.Text = "Bedingung: " + ((B < A) || (C < B));
        }

        private void cmdLogisch4_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3, C = 5;
            lblA.Text = "Bedingung: " + ((B < A) ^ (C > B));
        }
    }
}
