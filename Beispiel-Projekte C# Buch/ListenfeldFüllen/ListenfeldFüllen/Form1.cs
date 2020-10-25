using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListenfeldFüllen
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
    }
}
