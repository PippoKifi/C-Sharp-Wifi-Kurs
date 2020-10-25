using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections;
using System.Data.OleDb;
using System.IO;

namespace Vokabeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Liste der Fragen */
        ArrayList frage = new ArrayList();

        /* Liste der Antworten */
        ArrayList antwort = new ArrayList();

        /* Zufallszahl für ein Element der beiden Listen */
        int zufallszahl;

        /* Richtung der Vokabel-Abfrage */
        int richtung;

        /* Erzeugen und initialisieren
           des Zufallsgenerators */
        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Startrichtung Englisch - Deutsch */
            richtung = 2;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            con.ConnectionString =
               "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=C:\\Temp\\lernen.accdb";

            cmd.Connection = con;
            cmd.CommandText = "select * from vokabel";

            frage.Clear();
            antwort.Clear();

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                /* Speicherung in den Listen gemäß
                   der ausgewählten Richtung */
                while (reader.Read())
                {
                    if (richtung == 1 || richtung == 3)
                        frage.Add(reader["deutsch"]);
                    else if (richtung == 2)
                        frage.Add(reader["englisch"]);
                    else
                        frage.Add(reader["französisch"]);

                    if (richtung == 2 || richtung == 4)
                        antwort.Add(reader["deutsch"]);
                    else if (richtung == 1)
                        antwort.Add(reader["englisch"]);
                    else
                        antwort.Add(reader["französisch"]);
                }

                reader.Close();
                con.Close();

                /* Buttons und Menü (de)aktivieren */
                cmdStart.Enabled = false;
                cmdPrüfen.Enabled = true;
                mnuRichtung.Enabled = false;
                txtAntwort.Enabled = true;

                /* Erste Vokabel erscheint */
                Nächste_Vokabel();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Nächste_Vokabel()
        {
            /* Falls keine Vokabel mehr in der Liste: Ende */
            if (frage.Count < 1)
            {
                MessageBox.Show(
                    "Gratuliere! Alles geschafft");
                Test_Init();
            }

            /* Falls noch Vokabeln in der Liste: Nächste */
            else
            {
                zufallszahl = r.Next(0, frage.Count);
                lblFrage.Text = "" + frage[zufallszahl];
                txtAntwort.Text = "";
            }
        }

        private void Test_Init()
        {
            /* Buttons und Menü (de)aktivieren */
            cmdStart.Enabled = true;
            cmdPrüfen.Enabled = false;
            mnuRichtung.Enabled = true;
            txtAntwort.Enabled = false;

            /* Felder leeren */
            lblFrage.Text = "";
            txtAntwort.Text = "";
        }

        private void cmdPrüfen_Click(object sender, EventArgs e)
        {
            /* Falls richtig beantwortet:
               Vokabel aus Liste nehmen */
            if (txtAntwort.Text == (string)antwort[zufallszahl])
            {
                MessageBox.Show("Richtig", "Vokabel");
                frage.RemoveAt(zufallszahl);
                antwort.RemoveAt(zufallszahl);
            }

            /* Falls falsch beantwortet:
               richtige Antwort nennen */
            else
                MessageBox.Show("Falsch, richtige Antwort" +
                    " ist\n'" + antwort[zufallszahl] +
                    "'", "Vokabel");

            /* Nächste Vokabel erscheint */
            Nächste_Vokabel();
        }

        private void mnuEndeTest_Click(object sender, EventArgs e)
        {
            /* Abbruch mit Rückfrage */
            if (MessageBox.Show(
                    "Test wirklich abbrechen?",
                    "Vokabel",
                    MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                Test_Init();
        }

        private void mnuEndeProgramm_Click(object sender, EventArgs e)
        {
            /* Beenden mit Rückfrage */
            if (MessageBox.Show(
                    "Programm wirklich beenden?",
                    "Vokabel",
                    MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                Close();
        }

        private void mnuDE_Click(object sender, EventArgs e)
        {
            /* Richtung wird geändert */
            richtung = 1;
            Check_False();
            mnuDE.Checked = true;
            lblRichtung.Text = "deutsch/englisch";
        }

        private void mnuED_Click(object sender, EventArgs e)
        {
            richtung = 2;
            Check_False();
            mnuED.Checked = true;
            lblRichtung.Text = "englisch/deutsch";
        }

        private void mnuDF_Click(object sender, EventArgs e)
        {
            richtung = 3;
            Check_False();
            mnuDF.Checked = true;
            lblRichtung.Text = "deutsch/französisch";
        }

        private void mnuFD_Click(object sender, EventArgs e)
        {
            richtung = 4;
            Check_False();
            mnuFD.Checked = true;
            lblRichtung.Text = "französisch/deutsch";
        }

        private void Check_False()
        {
            mnuDE.Checked = false;
            mnuED.Checked = false;
            mnuDF.Checked = false;
            mnuFD.Checked = false;
        }

        private void mnuAnleitung_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string dateiname = "hilfe.txt";
            string ausgabe;

            if (!File.Exists(dateiname))
            {
                MessageBox.Show("Die Datei " +
                    dateiname + " existiert nicht");
                return;
            }

            fs = new FileStream(dateiname, FileMode.Open);
            sr = new StreamReader(fs);

            ausgabe = "";
            while (sr.Peek() != -1)
                ausgabe += sr.ReadLine() + "\n";
            sr.Close();

            MessageBox.Show(ausgabe);
        }
    }
}
