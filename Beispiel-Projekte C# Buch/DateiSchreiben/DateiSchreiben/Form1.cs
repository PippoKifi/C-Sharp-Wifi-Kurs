using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace DateiSchreiben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSchreiben_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(
                "aus.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txtEingabe.Text);
            sw.Close();
        }
    }
}
