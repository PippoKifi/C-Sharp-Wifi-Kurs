using System;
using System.Drawing;
using System.Windows.Forms;

using System.Data.OleDb;

namespace DBZugriffAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAlleSehen_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\firma.accdb";

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

        private void cmdErhöhen_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            int anzahl;
            string op;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\firma.accdb";

            cmd.Connection = con;

            if (ReferenceEquals(sender, cmdErhöhen))
                op = "*";
            else
                op = "/";
            cmd.CommandText = "update personen set" +
                " gehalt = gehalt " + op + " 1.05";

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
    }
}
