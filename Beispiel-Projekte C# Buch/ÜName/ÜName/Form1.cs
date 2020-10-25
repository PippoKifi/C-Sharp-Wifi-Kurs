using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÜName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdMyName_Click(object sender, EventArgs e)
        {
            lblMyName.Text = "Claus Clever";
        }

        private void cmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
