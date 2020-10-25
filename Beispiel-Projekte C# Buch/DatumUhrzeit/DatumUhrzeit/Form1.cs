using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatumUhrzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(
                2014, 2, 18, 16, 35, 12);
            DateTime d2 = new DateTime(2014, 3, 23);
            DateTime d3, d4 = new DateTime();

            lstA.Items.Add("d1: " + d1);
            lstA.Items.Add("d2: " + d2.ToShortDateString());
            d3 = DateTime.Now;
            d4 = DateTime.Today;
            lstA.Items.Add("d3: " + d3);
            lstA.Items.Add("d4: " + d4.ToShortDateString());

            lstA.Items.Add(
                "Tag der Woche: " + d1.DayOfWeek);
            if (d1.DayOfWeek == DayOfWeek.Sunday)
                lstA.Items.Add("Sonntag");
            else
                lstA.Items.Add("Kein Sonntag");

            lstA.Items.Add(
                "Tag des Jahres: " + d1.DayOfYear);
            lstA.Items.Add("Datum: " + d1.Date);
            lstA.Items.Add(
                "Uhrzeit: " + d1.TimeOfDay);
        }
    }
}
