using System;
using System.Drawing;
using System.Windows.Forms;

namespace MenüKontext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSchriftgröße.Items.Add("8,25");
            cboSchriftgröße.Items.Add("10");
            cboSchriftgröße.Items.Add("13");
            cboSchriftgröße.Items.Add("18");
            cboSchriftgröße.SelectedIndex = 0;
        }

        private void mnuKopieren_Click(object sender, EventArgs e)
        {
            lblA.Text = txtE.Text;
            if (lblA.Text == "")
                lblA.Text = "(leer)";
        }

        private void mnuEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuGelb_Click(object sender, EventArgs e)
        {
            lblA.BackColor = Color.Yellow;
            mnuGelb.Checked = true;
            mnuBlau.Checked = false;
            mnuRot.Checked = false;
        }

        private void mnuBlau_Click(object sender, EventArgs e)
        {
            lblA.BackColor = Color.Blue;
            mnuGelb.Checked = false;
            mnuBlau.Checked = true;
            mnuRot.Checked = false;
        }

        private void mnuRot_Click(object sender, EventArgs e)
        {
            lblA.BackColor = Color.Red;
            mnuGelb.Checked = false;
            mnuBlau.Checked = false;
            mnuRot.Checked = true;
        }

        private void mnuCourierNew_Click(object sender, EventArgs e)
        {
            lblA.Font = new Font("Courier New",
                lblA.Font.Size, lblA.Font.Style);
            mnuCourierNew.Checked = true;
            mnuSymbol.Checked = false;
            mnuArial.Checked = false;
        }

        private void mnuSymbol_Click(object sender, EventArgs e)
        {
            lblA.Font = new Font("Symbol",
                lblA.Font.Size, lblA.Font.Style);
            mnuCourierNew.Checked = false;
            mnuSymbol.Checked = true;
            mnuArial.Checked = false;
        }

        private void mnuArial_Click(object sender, EventArgs e)
        {
            lblA.Font = new Font("Arial",
                lblA.Font.Size, lblA.Font.Style);
            mnuCourierNew.Checked = false;
            mnuSymbol.Checked = false;
            mnuArial.Checked = true;
        }

        private void mnuFett_Click(object sender, EventArgs e)
        {
            lblA.Font = new Font(lblA.Font.FontFamily,
                lblA.Font.Size,
                lblA.Font.Style ^ FontStyle.Bold);
            mnuFett.Checked = !mnuFett.Checked;
            conLblFett.Checked = !conLblFett.Checked;
        }

        private void mnuKursiv_Click(object sender, EventArgs e)
        {
            lblA.Font = new Font(lblA.Font.FontFamily,
                lblA.Font.Size,
                lblA.Font.Style ^ FontStyle.Italic);
            mnuKursiv.Checked = !mnuKursiv.Checked;
        }

        private void cboSchriftgröße_TextChanged(object sender, EventArgs e)
        {
            double schriftgröße;

            try
            {
                schriftgröße = Convert.ToDouble(
                    cboSchriftgröße.Text);
            }
            catch
            {
                schriftgröße = 8.25;
            }

            lblA.Font = new Font(lblA.Font.FontFamily,
                (float)schriftgröße, lblA.Font.Style);
        }

        private void conTxtReadOnly_Click(object sender, EventArgs e)
        {
            txtE.ReadOnly = !txtE.ReadOnly;
            conTxtReadOnly.Checked =
                !conTxtReadOnly.Checked;
        }

        private void conTxtMultiline_Click(object sender, EventArgs e)
        {
            txtE.Multiline = !txtE.Multiline;

            if (txtE.Multiline)
                txtE.ScrollBars = ScrollBars.Vertical;
            else
                txtE.ScrollBars = ScrollBars.None;

            conTxtMultiline.Checked =
                !conTxtMultiline.Checked;
        }
    }
}
