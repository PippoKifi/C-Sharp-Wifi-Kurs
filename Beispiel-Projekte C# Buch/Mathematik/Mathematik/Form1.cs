using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mathematik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x;

        private void T_TextChanged(
            object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(T.Text);
            }
            catch
            {
                T.Text = "";
                x = 0;
            }
        }

        private void cmdBackSpace_Click(
            object sender, EventArgs e)
        {
            T.Text = T.Text.Substring(
                0, T.Text.Length - 1);
        }

        private void cmdClear_Click(
            object sender, EventArgs e)
        {
            T.Text = "";
        }

        private void cmdSinus_Click(
            object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Asin(x) * 180 / Math.PI;
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Sin(x / 180.0 * Math.PI);
        }

        private void cmdCosinus_Click(
            object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Acos(x) * 180 / Math.PI;
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Cos(x / 180.0 * Math.PI);
        }

        private void cmdTangens_Click(
            object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Atan(x) * 180 / Math.PI;
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Tan(x / 180.0 * Math.PI);
        }

        private void cmdLn_Click(
            object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Exp(x);
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Log(x);
        }

        private void cmdLog_Click(
            object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Pow(10.0, x);
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Log10(x);
        }

        private void cmdPI_Click(
            object sender, EventArgs e)
        {
            T.Text = "" + Math.PI;
        }

        private void cmdE_Click(
            object sender, EventArgs e)
        {
            T.Text = "" + Math.E;
        }

        private void cmdCeiling_Click(
            object sender, EventArgs e)
        {
            T.Text = "" + Math.Ceiling(x);
        }

        private void cmdFloor_Click(
            object sender, EventArgs e)
        {
            T.Text = "" + Math.Floor(x);
        }

        private void cmdRound_Click(
            object sender, EventArgs e)
        {
            T.Text = "" + Math.Round(x);
        }

        private void cmdTruncate_Click(
            object sender, EventArgs e)
        {
            T.Text = "" + Math.Truncate(x);
        }

        private void cmdWurzel_Click(
            object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Pow(x, 2.0);
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Sqrt(x);
        }

        private void cmdPlusMinus_Click(
            object sender, EventArgs e)
        {
            T.Text = "" + x * -1.0;
        }

        private void cmdKehrwert_Click(
            object sender, EventArgs e)
        {
            T.Text = "" + 1.0 / x;
        }

        private void cmdZiffer_Click(
            object sender, EventArgs e)
        {
            Button b = (Button) sender;
            T.Text += b.Text;
        }

        private void cmdKomma_Click(
            object sender, EventArgs e)
        {
            if (T.Text.IndexOf(",") < 0)
                T.Text += ",";
        }
    }
}
