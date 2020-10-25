using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace DateiVerzeichnisListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Temp"))
                Directory.
                    SetCurrentDirectory(@"C:\Temp");
            else
                MessageBox.Show(
                    @"Das Verzeichnis C:\Temp" +
                    " existiert nicht");
            lblCurDir.Text =
                Directory.GetCurrentDirectory();
        }

        private void cmdDateiliste_Click(object sender, EventArgs e)
        {
            string verzeichnis;
            string[] dateiliste;
            int i;

            verzeichnis = Directory.
                GetCurrentDirectory();
            dateiliste = Directory.
                GetFiles(verzeichnis);
            lstA.Items.Clear();
            for (i = 0; i < dateiliste.Length; i++)
                lstA.Items.Add(dateiliste[i]);
        }

        private void cmdSystemeinträge_Click(object sender, EventArgs e)
        {
            Systemeinträge();
        }

        private void Systemeinträge()
        {
            string verzeichnis;
            string[] dateiliste;
            int i;

            verzeichnis = Directory.
                GetCurrentDirectory();
            dateiliste = Directory.
                GetFileSystemEntries(verzeichnis);
            lstA.Items.Clear();
            for (i = 0; i < dateiliste.Length; i++)
                lstA.Items.Add(dateiliste[i]);
        }

        private void lstA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name;

            if (lstA.SelectedIndex != -1)
            {
                name = lstA.Text;

                lblAnzeige.Text = name + "\n" +
                    "Erzeugt: " +
                    File.GetCreationTime(name) + "\n" +
                    "Letzter Zugriff: " +
                    File.GetLastAccessTime(name) +
                    "\n" + "Letzter Schreibzugriff:" +
                    File.GetLastWriteTime(name);
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");
        }

        private void cmdInVerzeichnis_Click(object sender, EventArgs e)
        {
            if (lstA.SelectedIndex != -1)
            {
                try
                {
                    Directory.SetCurrentDirectory(lstA.Text);
                }
                catch
                {
                    MessageBox.Show(lstA.Text +
                        " ist kein Verzeichnis");
                }
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");

            lblCurDir.Text = Directory.GetCurrentDirectory();
            Systemeinträge();
        }

        private void cmdNachOben_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("..");
            lblCurDir.Text =
                Directory.GetCurrentDirectory();
            Systemeinträge();
        }
    }
}
