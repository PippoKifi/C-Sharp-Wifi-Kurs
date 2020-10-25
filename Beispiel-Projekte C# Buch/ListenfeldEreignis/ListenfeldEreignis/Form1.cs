using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListenfeldEreignis
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

        private void cmdEreignis_Click(object sender, EventArgs e)
        {
            lstSpeisen.SelectedIndex = 3;
        }

        private void lstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnzeige.Text =
                "Auswahl: " + lstSpeisen.SelectedItem;
        }
    }
}
