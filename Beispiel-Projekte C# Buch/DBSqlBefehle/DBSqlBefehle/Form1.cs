using System;
using System.Drawing;
using System.Windows.Forms;

using System.Data.OleDb;

namespace DBSqlBefehle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Auswahl(string sqlbefehl, params string[] felder)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;
            int i;
            string zeile;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\firma.accdb";

            cmd.Connection = con;
            cmd.CommandText = sqlbefehl;

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                lstTab.Items.Clear();
                while (reader.Read())
                {
                    zeile = "";
                    for (i = 0; i < felder.Length; i++)
                        zeile += reader[felder[i]] + " # ";
                    lstTab.Items.Add(zeile);
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Aktion(string sqlbefehl)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            int anzahl;
            string op;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\firma.accdb";
            cmd.Connection = con;

            cmd.CommandText = sqlbefehl;

            try
            {
                con.Open();
                anzahl = cmd.ExecuteNonQuery();
                MessageBox.Show(
                    "Datensätze geändert: " + anzahl);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdEinzelneFelder_Click(object sender, EventArgs e)
        {
            Auswahl("select name, vorname from personen", "name", "vorname");
        }

        private void cmdBedingungZahl_Click(object sender, EventArgs e)
        {
            Auswahl("select * from personen where gehalt > 3600", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void cmdBedingungZeichen_Click(object sender, EventArgs e)
        {
            Auswahl("select * from personen where name = 'Schmitz'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void cmdBedingungLogisch_Click(object sender, EventArgs e)
        {
            Auswahl("select * from personen where gehalt >= 3600 And gehalt <= 3650", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void cmdBeginntMitZeichen_Click(object sender, EventArgs e)
        {
            Auswahl("select * from personen where name like 'M%'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void cmdZeichenKommtVor_Click(object sender, EventArgs e)
        {
            Auswahl("select * from personen where name like '%i%'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void cmdEinzelnerPlatzhalter_Click(object sender, EventArgs e)
        {
            Auswahl("select * from personen where name like 'M__er'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void cmdSortierungFallend_Click(object sender, EventArgs e)
        {
            Auswahl("select name, gehalt from personen order by gehalt desc", "name", "gehalt");
        }

        private void cmdSortierungNachZweiFeldern_Click(object sender, EventArgs e)
        {
            Auswahl("select * from personen order by name, vorname", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void cmdEingabeSuchbegriff_Click(object sender, EventArgs e)
        {
            Auswahl("select * from personen where name like '" + txtEingabe.Text + "'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void cmdEingabeSuchzeichen_Click(object sender, EventArgs e)
        {
            Auswahl("select * from personen where name like '%" + txtEingabe.Text + "%'", "name", "vorname", "personalnummer", "gehalt", "geburtstag");
        }

        private void cmdÄndernAlle_Click(object sender, EventArgs e)
        {
            Aktion("update personen set gehalt = 3800");
        }

        private void cmdÄndernEinzeln_Click(object sender, EventArgs e)
        {
            Aktion("update personen set gehalt = 3800 where personalnummer = 2297");
        }

        private void cmdLöschenEinzeln_Click(object sender, EventArgs e)
        {
            Aktion("delete from personen where personalnummer = 2297");
        }

        private void cmdEinfügen_Click(object sender, EventArgs e)
        {
            Aktion("insert into personen (name, vorname, personalnummer, gehalt, geburtstag) values('Müller', 'Gerd', 4711, 2900, '12.08.1976')");
        }

        private void cmdFehlerZeichen_Click(object sender, EventArgs e)
        {
            Aktion("update personen set name = Mohr where personalnummer = 6714");
        }

        private void cmdFehlerDatum_Click(object sender, EventArgs e)
        {
            Aktion("update personen set geburtstag = '18.07.' where personalnummer = 6714");
        }

        private void cmdFehlerEindeutigkeit_Click(object sender, EventArgs e)
        {
            Aktion("insert into personen (name, vorname, personalnummer, gehalt, geburtstag) values('Müller', 'Gerd', 6714, 2900, '12.08.1976')");
        }

        private void cmdOriginalwerte_Click(object sender, EventArgs e)
        {
            Aktion("delete from personen");
            Aktion("insert into personen (name, vorname, personalnummer, gehalt, geburtstag) values('Maier', 'Hans', 6714, 3500, '15.03.1962')");
            Aktion("insert into personen (name, vorname, personalnummer, gehalt, geburtstag) values('Schmitz', 'Peter', 81343, 3750, '12.04.1958')");
            Aktion("insert into personen (name, vorname, personalnummer, gehalt, geburtstag) values('Mertens', 'Julia', 2297, 3621.5, '30.12.1959')");
        }
    }
}
