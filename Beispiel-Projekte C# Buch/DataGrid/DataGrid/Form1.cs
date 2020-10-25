using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Spalten hinzufügen */
            dgv.Columns.Add("SpName", "Name");
            dgv.Columns.Add("SpVorname", "Vorname");
            dgv.Columns.Add("SpPersonalnummer",
                            "Personalnummer");
            dgv.Columns.Add("SpGehalt", "Gehalt");
            dgv.Columns.Add("SpGeburtstag", "Geburtstag");

            /* Breite einstellen */
            for (int i = 0; i < dgv.Columns.Count; i++)
                dgv.Columns[i].Width = 75;

            /* Zeilen hinzufügen */
            dgv.Rows.Add("Maier", "Hans", 6714,
                3500.0, "15.03.1962");
            dgv.Rows.Add("Schmitz", "Peter", 81343,
                3750.0, "12.04.1958");
            dgv.Rows.Add("Mertens", "Julia", 2297,
                3621.5, "30.12.1959");
        }

        private void cmdInfoSpalte_Click(object sender, EventArgs e)
        {
            /* Name und Headertext */
            lblA.Text = "Name: " +
                dgv.Columns["SpName"].Name + ", Header: " +
                dgv.Columns["SpName"].HeaderText + "\n";
            for (int i = 1; i < dgv.Columns.Count; i++)
                lblA.Text += "Name: " +
                    dgv.Columns[i].Name + ", Header: " +
                    dgv.Columns[i].HeaderText + "\n";
        }

        private void cmdMittelwert_Click(object sender, EventArgs e)
        {
            double mw = 0;

            /* Zellen auswerten */
            lblA.Text = "";
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
                mw += Convert.ToDouble(
                    dgv.Rows[i].Cells[3].Value);
            mw /= dgv.Rows.Count - 1;
            lblA.Text = "Gehalt, Mittelwert: " + mw;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Klick auswerten */
            lblA.Text = "Zeile: " + e.RowIndex + "\n" +
                "Spalte: " + e.ColumnIndex + "\n";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                lblA.Text += "Inhalt: " +
                    dgv.Rows[e.RowIndex].
                        Cells[e.ColumnIndex].Value;
        }
    }
}
