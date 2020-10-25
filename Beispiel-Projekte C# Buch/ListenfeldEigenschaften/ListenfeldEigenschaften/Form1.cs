using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListenfeldEigenschaften
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSpeisen.Items.Add("Spaghetti");
            lstSpeisen.Items.Add("Grüne Nudeln");
            lstSpeisen.Items.Add("Tortellini");
            lstSpeisen.Items.Add("Pizza");
            lstSpeisen.Items.Add("Lasagne");
        }

        private void cmdAnzeige_Click(object sender, EventArgs e)
        {
            int i;

            lblAnzeige1.Text =
                "Anzahl: " + lstSpeisen.Items.Count;
            lblAnzeige2.Text = "Ausgewählter Eintrag: " +
                lstSpeisen.SelectedItem;
            lblAnzeige3.Text = "Nummer des ausgewählten" +
                " Eintrags: " + lstSpeisen.SelectedIndex;

            lblAnzeige4.Text = "Alle Einträge:" + "\n";
            for (i = 0; i < lstSpeisen.Items.Count; i++)
                lblAnzeige4.Text +=
                    lstSpeisen.Items[i] + "\n";
        }
    }
}
