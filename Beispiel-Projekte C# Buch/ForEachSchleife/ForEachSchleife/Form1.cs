using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections;

namespace ForEachSchleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstLand.Items.Add("Ecuador");
            lstLand.Items.Add("Chile");
            lstLand.Items.Add("Brasilien");
            lstLand.Items.Add("Kolumbien");
        }

        private void cmdDatenfeld_Click(object sender, EventArgs e)
        {
            int[] a = { 3, 7, -2, 12 };

            lblA.Text = "";
            foreach (int x in a)
                lblA.Text += x + "\n";
        }

        private void cmdArrayList_Click(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            a.Add(5.6);
            a.Add(lstLand.Items[3]);
            a.Add(-6);
            a.Add("Hallo");

            lblA.Text = "";
            foreach (object x in a)
                lblA.Text += x + "\n";
        }

        private void cmdListBox_Click(object sender, EventArgs e)
        {
            lblA.Text = "";
            foreach (string x in lstLand.Items)
                lblA.Text += x + "\n";
        }

        private void cmdSteuerelemente_Click(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            a.Add(cmdDatenfeld);
            a.Add(cmdArrayList);
            a.Add(lstLand);
            a.Add(this);

            lblA.Text = "";
            foreach (Control x in a)
                lblA.Text += x.Size.Width + "\n";
        }
    }
}
