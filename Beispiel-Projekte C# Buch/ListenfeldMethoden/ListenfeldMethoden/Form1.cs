using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListenfeldMethoden
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

        private void cmdLöschen_Click(object sender, EventArgs e)
        {
            int x = lstSpeisen.SelectedIndex;
            if (x != -1)
                lstSpeisen.Items.RemoveAt(x);
        }

        private void cmdEinfügen_Click(object sender, EventArgs e)
        {
            if (txtNeu.Text == "")
                return;

            if (optAnfang.Checked)
                lstSpeisen.Items.Insert(0, txtNeu.Text);
            else if (optAuswahl.Checked &&
                    lstSpeisen.SelectedIndex != -1)
                lstSpeisen.Items.Insert(
                    lstSpeisen.SelectedIndex,
                    txtNeu.Text);
            else
                lstSpeisen.Items.Add(txtNeu.Text);

            txtNeu.Text = "";
        }

        private void cmdErsetzen_Click(object sender, EventArgs e)
        {
            int x;

            if (txtErsetzen.Text != "" &&
                    lstSpeisen.SelectedIndex != -1)
            {
                x = lstSpeisen.SelectedIndex;
                lstSpeisen.Items.RemoveAt(x);
                lstSpeisen.Items.Insert(
                    x, txtErsetzen.Text);
                txtErsetzen.Text = "";
            }
        }

        private void cmdAllesLöschen_Click(object sender, EventArgs e)
        {
            lstSpeisen.Items.Clear();
        }
    }
}
