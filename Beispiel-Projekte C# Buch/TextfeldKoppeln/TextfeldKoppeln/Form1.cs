using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextfeldKoppeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Kopplung;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.SelectAll();
            Kopplung = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (Kopplung)
                txtProjektmappenname.Text = txtName.Text;
        }

        private void txtProjektmappenname_Click(object sender, EventArgs e)
        {
            Kopplung = false;
        }
    }
}
