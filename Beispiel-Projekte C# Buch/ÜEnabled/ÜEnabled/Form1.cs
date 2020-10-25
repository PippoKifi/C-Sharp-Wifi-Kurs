using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜEnabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstLand.Items.Add("Liechtenstein");
            lstLand.Items.Add("Malta");
            lstLand.Items.Add("Andorra");
            lstLand.Items.Add("San Marino");
            lstLand.Items.Add("Monaco");
        }

        private void lstLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLand.SelectedItems.Count > 0)
                cmdLöschen.Enabled = true;
            else
                cmdLöschen.Enabled = false;
        }

        private void cmdLöschen_Click(object sender, EventArgs e)
        {
            lstLand.Items.RemoveAt(
                lstLand.SelectedIndex);
        }
    }
}
