using System;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration;
using System.Collections.Specialized;
using System.Data.OleDb;

namespace Konfigurationsdaten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            /* Konfigurationsdatei lesen */
            NameValueCollection appset =
                ConfigurationSettings.AppSettings;

            /* Verbindung einrichten */
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                appset["DBVerzeichnis"] + "\\firma.accdb";

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            cmd.Connection = con;
            cmd.CommandText = "select * from personen";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                lstTab.Items.Clear();
                while (reader.Read())
                {
                    lstTab.Items.Add(
                        reader["name"] + " # " +
                        reader["vorname"] + " # " +
                        reader["personalnummer"] + " # " +
                        reader["gehalt"] + " # " +
                        reader["geburtstag"]);
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
