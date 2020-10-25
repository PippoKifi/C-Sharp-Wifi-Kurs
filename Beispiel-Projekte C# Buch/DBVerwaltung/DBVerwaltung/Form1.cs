using System;
using System.Drawing;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Collections;

namespace DBVerwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;
        ArrayList pnummer = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\firma.accdb";
            cmd.Connection = con;
        }

        private void cmdAlleSehen_Click(object sender, EventArgs e)
        {
            AlleSehen();
        }

        private void cmdNameSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText =
                    "select * from personen where" +
                    " name like '%" + txtName.Text + "%'";
                MessageBox.Show(cmd.CommandText);
                Ausgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void cmdEinfügen_Click(object sender, EventArgs e)
        {
            int anzahl;

            try
            {
                con.Open();
                cmd.CommandText =
                    "insert into personen " +
                   "(name, vorname, personalnummer, " +
                   "gehalt, geburtstag) values ('" +
                   txtName.Text + "', '" +
                   txtVorname.Text + "', " +
                   txtPersonalnummer.Text + ", " +
                   txtGehalt.Text.Replace(',', '.') +
                   ", '" + txtGeburtstag.Text + "')";
                MessageBox.Show(cmd.CommandText);

                anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show(
                        "Ein Datensatz eingefügt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte mindestens " +
                    "einen Namen, eine eindeutige " +
                    "Personalnummer und ein gültiges " +
                    "Geburtsdatum eintragen");
            }

            con.Close();
            AlleSehen();
        }

        private void cmdÄndern_Click(object sender, EventArgs e)
        {
            int anzahl;

            try
            {
                con.Open();
                cmd.CommandText =
                   "update personen set " +
                   "name = '" + txtName.Text + "', " +
                   "vorname = '" + txtVorname.Text +
                   "', personalnummer = " +
                   txtPersonalnummer.Text + ", " +
                   "gehalt = " +
                   txtGehalt.Text.Replace(',', '.') +
                   ", geburtstag = '" +
                   txtGeburtstag.Text +
                   "' where personalnummer = " +
                   pnummer[lstTab.SelectedIndex];
                MessageBox.Show(cmd.CommandText);

                anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte einen Datensatz " +
                    "auswählen und mindestens einen Namen," +
                    " eine eindeutige Personalnummer und" +
                    " ein gültiges Geburtsdatum eintragen");
            }

            con.Close();
            AlleSehen();
        }

        private void cmdLöschen_Click(object sender, EventArgs e)
        {
            int anzahl;
            if (txtPersonalnummer.Text == "")
            {
                MessageBox.Show(
                    "Bitte einen Datensatz auswählen");
                return;
            }

            if (MessageBox.Show("Wollen Sie den " +
                    "ausgewählten Datensatz wirklich " +
                    "löschen?", "Löschen",
                    MessageBoxButtons.YesNo)
                    == DialogResult.No)
                return;

            try
            {
                con.Open();
                cmd.CommandText = "delete from personen " +
                    "where personalnummer = " +
                    pnummer[lstTab.SelectedIndex];
                MessageBox.Show(cmd.CommandText);

                anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz gelöscht");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            AlleSehen();
        }

        private void AlleSehen()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select * from personen";
                Ausgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            txtName.Text = "";
            txtVorname.Text = "";
            txtPersonalnummer.Text = "";
            txtGehalt.Text = "";
            txtGeburtstag.Text = "";
        }

        private void Ausgabe()
        {
            DateTime geburtstag;

            reader = cmd.ExecuteReader();
            lstTab.Items.Clear();
            pnummer.Clear();

            while (reader.Read())
            {
                geburtstag = Convert.ToDateTime(
                    reader["geburtstag"]);

                lstTab.Items.Add(reader["name"] + " # " +
                    reader["vorname"] + " # " +
                    reader["personalnummer"] + " # " +
                    reader["gehalt"] + " # " +
                    geburtstag.ToShortDateString());
                pnummer.Add(reader["personalnummer"]);
            }

            reader.Close();
        }

        private void lstTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime geburtstag;

            try
            {
                con.Open();
                cmd.CommandText = "select * from personen" +
                    " where personalnummer = " +
                    pnummer[lstTab.SelectedIndex];

                reader = cmd.ExecuteReader();
                reader.Read();

                txtName.Text = "" + reader["name"];
                txtVorname.Text = "" + reader["vorname"];
                txtPersonalnummer.Text =
                    "" + reader["personalnummer"];
                txtGehalt.Text = "" + reader["gehalt"];

                geburtstag = Convert.ToDateTime(
                    reader["geburtstag"]);
                txtGeburtstag.Text =
                    geburtstag.ToShortDateString();

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }
    }
}
