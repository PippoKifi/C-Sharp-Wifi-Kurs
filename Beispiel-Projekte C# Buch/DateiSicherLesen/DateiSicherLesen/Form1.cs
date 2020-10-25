using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace DateiSicherLesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdExistenz_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string dateiname = "ein.txt";
            string zeile;

            if (!File.Exists(dateiname))
            {
                MessageBox.Show("Datei " + dateiname +
                       " existiert nicht");
                return;
            }

            fs = new FileStream(dateiname, FileMode.Open);
            sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                zeile = sr.ReadLine();
                lblA.Text += zeile + "\n";
            }
            sr.Close();
        }

        private void cmdAusnahme_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string zeile;

            try
            {
                fs = new FileStream(
                    "ein.txt", FileMode.Open);
                sr = new StreamReader(fs);
                while (sr.Peek() != -1)
                {
                    zeile = sr.ReadLine();
                    lblA.Text += zeile + "\n";
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdPfad_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;

            try
            {
                fs = new FileStream(
                    @"..\..\Daten\ein.txt",
                    FileMode.Open);
                sr = new StreamReader(fs);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
