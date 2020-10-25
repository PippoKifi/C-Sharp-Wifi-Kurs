using System;
using System.Drawing;
using System.Windows.Forms;

namespace StandardDialogfelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;
            ofd.InitialDirectory = "C:\\Temp";
            ofd.Filter = "Tabellen (*.xls)|*.xls|" +
                " Texte (*.txt; *doc)|*.txt;*.doc|" +
                " Alle Dateien (*.*)|*.*";
            ofd.Title = "Datei zum Öffnen auswählen";

            if (ofd.ShowDialog() == DialogResult.OK)
                foreach (string s in ofd.FileNames)
                    MessageBox.Show("Öffnen: " + s);
            else
                MessageBox.Show("Abbruch");
        }

        private void cmdSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = "C:\\Temp";
            sfd.Filter = "Tabellen (*.xls)|*.xls|" +
                " Texte (*.txt; *doc)|*.txt;*.doc|" +
                " Alle Dateien (*.*)|*.*";
            sfd.Title = "Datei zum Speichern auswählen";

            if (sfd.ShowDialog() == DialogResult.OK)
                MessageBox.Show(
                    "Speichern unter: " + sfd.FileName);
            else
                MessageBox.Show("Abbruch");
        }

        private void cmdFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd =
                new FolderBrowserDialog();

            fbd.RootFolder =
                Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Verzeichnis auswählen";

            if (fbd.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Zugriff auf Verzeichnis: " +
                    fbd.SelectedPath);
            else
                MessageBox.Show("Abbruch");
        }

        private void cmdColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                lblA.ForeColor = cd.Color;
            else
                MessageBox.Show("Abbruch");
        }

        private void cmdFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            fd.ShowColor = true;
            fd.MinSize = 8;
            fd.MaxSize = 20;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                lblA.Font = fd.Font;
                lblA.ForeColor = fd.Color;
            }
            else
                MessageBox.Show("Abbruch");
        }
    }
}
