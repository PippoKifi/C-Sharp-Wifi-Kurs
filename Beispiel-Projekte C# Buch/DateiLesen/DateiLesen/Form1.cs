using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace DateiLesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLesen_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ein.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string zeile;

            while (sr.Peek() != -1)
            {
                zeile = sr.ReadLine();
                lblA.Text += zeile + "\n";
            }
            sr.Close();
        }
    }
}
