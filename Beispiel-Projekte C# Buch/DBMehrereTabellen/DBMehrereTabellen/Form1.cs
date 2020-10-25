using System;
using System.Drawing;
using System.Windows.Forms;

using System.Data.OleDb;

namespace DBMehrereTabellen
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
                "Data Source=C:\\Temp\\projektverwaltung.accdb";

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

        private void cmdAllePersonen_Click(object sender, EventArgs e)
        {
            Auswahl("select * from person order by pe_nachname, pe_vorname", "pe_nachname", "pe_vorname");
        }

        private void cmdAnzahlKunden_Click(object sender, EventArgs e)
        {
            Auswahl("select count(ku_id) as count_ku_id from kunde", "count_ku_id");
        }

        private void cmdAlleKundenAlleProjekte_Click(object sender, EventArgs e)
        {
            Auswahl("select * from kunde, projekt where ku_id = pr_ku_id order by ku_name, ku_ort, pr_bezeichnung", "ku_name", "ku_ort", "pr_bezeichnung");
        }

        private void cmdAllePersonenAlleProjektzeiten_Click(object sender, EventArgs e)
        {
            Auswahl("select * from projekt, projekt_person, person where projekt.pr_id = projekt_person.pr_id and projekt_person.pe_id = person.pe_id order by pe_nachname, pr_bezeichnung, pp_datum", "pe_nachname", "pr_bezeichnung", "pp_datum");
        }

        private void cmdAllePersonenZeitsumme_Click(object sender, EventArgs e)
        {
            Auswahl("select pe_nachname, sum(pp_zeit) as sum_pp_zeit from person, projekt_person where person.pe_id = projekt_person.pe_id group by person.pe_id, pe_nachname order by pe_nachname", "pe_nachname", "sum_pp_zeit");
        }

        private void cmdAlleProjekteAllePersonenzeiten_Click(object sender, EventArgs e)
        {
            Auswahl("select * from projekt, projekt_person, person where projekt.pr_id = projekt_person.pr_id and projekt_person.pe_id = person.pe_id order by pr_bezeichnung, pe_nachname, pp_datum", "pr_bezeichnung", "pe_nachname", "pp_datum");
        }

        private void cmdAlleProjekteZeitsumme_Click(object sender, EventArgs e)
        {
            Auswahl("select pr_bezeichnung, sum(pp_zeit) as sum_pp_zeit from projekt, projekt_person where projekt.pr_id = projekt_person.pr_id group by projekt.pr_id, pr_bezeichnung order by pr_bezeichnung", "pr_bezeichnung", "sum_pp_zeit");
        }
    }
}
