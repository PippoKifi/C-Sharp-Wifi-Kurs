using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehrereFormulare
{
    public partial class Form2 : Form
    {
        Form1 fh;

        public Form2(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtUnter.Text =
                fh.Controls["txtHaupt"].Text;

            CheckBox cb = fh.Controls["chkHaupt"] as CheckBox;
            chkUnter.Checked = cb.Checked;
        }

        private void cmdEndeUnter_Click(object sender, EventArgs e)
        {
            fh.Controls["txtHaupt"].Text =
                txtUnter.Text;

            CheckBox cb = fh.Controls["chkHaupt"] as CheckBox;
            cb.Checked = chkUnter.Checked;

            Close();
        }
    }
}
