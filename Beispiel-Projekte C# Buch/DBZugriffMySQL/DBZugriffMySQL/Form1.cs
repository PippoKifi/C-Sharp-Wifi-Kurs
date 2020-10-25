using System;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace DBZugriffMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAlleSehen_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;
            DateTime geburtstag;

            con.ConnectionString =
                "Data Source=localhost;" +
                "Initial Catalog=firma;UID=root";

            cmd.Connection = con;
            cmd.CommandText = "select * from personen";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                lstTab.Items.Clear();
                while (reader.Read())
                {
                    geburtstag = Convert.ToDateTime(
                        reader["geburtstag"]);

                    lstTab.Items.Add(
                        reader["name"] + " # " +
                        reader["vorname"] + " # " +
                        reader["personalnummer"] + " # " +
                        reader["gehalt"] + " # " +
                        geburtstag.ToShortDateString());
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
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            int anzahl;
            string op;

            con.ConnectionString =
                "Data Source=localhost;" +
                "Initial Catalog=firma;UID=root";

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
                MessageBox.Show("Datensätze geändert: " + anzahl);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
