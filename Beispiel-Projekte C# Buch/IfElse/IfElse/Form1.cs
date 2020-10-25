using System;
using System.Drawing;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeige1_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;
            lblAnzeige.Text = "";

            if (x > 0)
            {
                lblAnzeige.Text = "x ist größer als 0";
                numX.BackColor = Color.LightGreen;
            }
        }

        private void cmdAnzeige2_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;

            if (x > 0)
            {
                lblAnzeige.Text = "x ist größer als 0";
                numX.BackColor = Color.LightGreen;
            }
            else
            {
                lblAnzeige.Text =
                    "x ist kleiner als 0 oder gleich 0";
                numX.BackColor = Color.LightBlue;
            }
        }

        private void cmdAnzeige3_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;

            if (x > 0)
            {
                lblAnzeige.Text = "x ist größer als 0";
                numX.BackColor = Color.LightGreen;
            }
            else
            {
                numX.BackColor = Color.LightBlue;

                if (x < 0)
                    lblAnzeige.Text = "x ist kleiner als 0";
                else
                    lblAnzeige.Text = "x ist gleich 0";
            }
        }

        private void cmdAnzeige4_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;
            int y = (int)numY.Value;
            numX.BackColor = Color.White;

            if (x > 0 && y > 0)
                lblAnzeige.Text = "x und y sind größer als 0";
            else
                lblAnzeige.Text = "Mind. eine der beiden" +
                    " Zahlen ist nicht größer als 0";
        }

        private void cmdAnzeige5_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;
            int y = (int)numY.Value;
            numX.BackColor = Color.White;

            if (x > 0 || y > 0)
                lblAnzeige.Text = "x oder y oder beide" +
                    " sind größer als 0";
            else
                lblAnzeige.Text = "Keine der beiden" +
                    " Zahlen ist größer als 0";
        }

        private void cmdAnzeige6_Click(object sender, EventArgs e)
        {
            int x = (int)numX.Value;
            int y = (int)numY.Value;
            numX.BackColor = Color.White;
            lblAnzeige.Text = "";

            if (x > 0 ^ y > 0)
                lblAnzeige.Text = "Nur x oder nur y" +
                    " ist größer als 0";
        }
    }
}
