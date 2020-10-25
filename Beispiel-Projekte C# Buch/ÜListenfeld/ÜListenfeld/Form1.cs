using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜListenfeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstLinks.Items.Add("Malta");
            lstLinks.Items.Add("Zypern");
            lstLinks.Items.Add("Slowenien");
            lstLinks.Items.Add("Estland");
            lstLinks.Items.Add("Rumänien");

            lstRechts.Items.Add("Belgien");
            lstRechts.Items.Add("Spanien");
            lstRechts.Items.Add("Italien");
            lstRechts.Items.Add("Portugal");
            lstRechts.Items.Add("Dänemark");
        }

        private void cmdRechts_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < lstLinks.SelectedItems.Count; i++)
                lstRechts.Items.Add(
                    lstLinks.SelectedItems[i]);

            for (i = lstLinks.SelectedItems.Count - 1;
                    i >= 0; i--)
                lstLinks.Items.RemoveAt(
                    lstLinks.SelectedIndices[i]);
        }

        private void cmdLinks_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < lstRechts.SelectedItems.Count; i++)
                lstLinks.Items.Add(
                    lstRechts.SelectedItems[i]);
            for (i = lstRechts.SelectedItems.Count - 1;
                    i >= 0; i--)
                lstRechts.Items.RemoveAt(
                    lstRechts.SelectedIndices[i]);
        }
    }
}
