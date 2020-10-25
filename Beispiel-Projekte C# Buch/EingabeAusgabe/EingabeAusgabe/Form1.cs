using System;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace EingabeAusgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdInput_Click(object sender, EventArgs e)
        {
            string eingabe;

            eingabe = Interaction.InputBox(
                "Bitte Ihren Namen:",
                "Ihr Name", "Maier");
            lblA.Text = eingabe;
        }

        private void cmdLotto_Click(object sender, EventArgs e)
        {
            int zahl, i, k;
            int[] lotto = new int[6];
            bool gezogen;

            lblA.Text = "";
            for (i = 0; i < lotto.Length; i++)
            {
                do
                {
                    gezogen = false;
                    zahl = 0;
                    try
                    {
                        zahl = Convert.ToInt32(
                            Interaction.InputBox("Zahl " +
                            (i + 1) + ": ",
                            "Zahl " + (i + 1)));
                    }
                    catch
                    {
                        continue;
                    }

                    for (k = 0; k < i; k++)
                        if (lotto[k] == zahl)
                        {
                            gezogen = true;
                            break;
                        }
                }
                while (gezogen || zahl < 1 || zahl > 49);

                lotto[i] = zahl;
                lblA.Text += zahl + " ";
            }
        }

        private void cmdMsgBoxOkOnly_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Gelesen? Dann bitte Ok drücken",
                "Ok", MessageBoxButtons.OK);
        }

        private void cmdMsgBoxInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Das ist eine Information",
                "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void cmdMsgBoxYesNo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Soll die Datei gesichert werden?",
                "Sicherung", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                lblA.Text = "Sichern";
            else
                lblA.Text = "Nicht sichern";
        }

        private void cmdMsgBoxYesNoCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Soll die Datei gesichert werden?",
                "Sicherung",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                lblA.Text = "Sichern";
            else if (dr == DialogResult.No)
                lblA.Text = "Nicht sichern";
            else
                lblA.Text = "Abbrechen";
        }

        private void cmdMsgBoxRetryCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Beim " +
                "Sichern der Datei trat ein Fehler auf.\n" +
                "Wollen Sie es noch einmal probieren?\n" +
                "Wollen Sie den Vorgang abbrechen?",
                "Fehler bei Sicherung",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);

            if (dr == DialogResult.Retry)
                lblA.Text = "Noch einmal";
            else
                lblA.Text = "Abbrechen";
        }

        private void cmdMsgBoxAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Beim " +
                "Sichern der Datei trat ein Fehler auf.\n" +
                "Wollen Sie den Vorgang abbrechen?\n" +
                "Wollen Sie es noch einmal probieren?\n" +
                "Wollen Sie diese Nachricht ignorieren?",
                "Fehler bei Sicherung",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Abort)
                lblA.Text = "Abbrechen";
            else if (dr == DialogResult.Retry)
                lblA.Text = "Noch einmal";
            else
                lblA.Text = "Ignorieren";
        }
    }
}
