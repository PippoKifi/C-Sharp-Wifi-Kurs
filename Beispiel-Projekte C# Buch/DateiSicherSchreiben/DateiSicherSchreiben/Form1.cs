using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace DateiSicherSchreiben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAusnahme_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter sw;
            string dateiname = "aus.txt";

            try
            {
                fs = new FileStream(
                    dateiname, FileMode.Create);
                sw = new StreamWriter(fs);
                sw.WriteLine(txtEingabe.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
