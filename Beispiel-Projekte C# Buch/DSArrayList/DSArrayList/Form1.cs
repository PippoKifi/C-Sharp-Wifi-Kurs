using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections;

namespace DSArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList a = new ArrayList();

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            lstA.Items.Clear();
            a.Clear();

            /* Elemente hinzufügen, ausgeben */
            a.Add(4);
            a.Add(7.5);
            a.Add("Hallo");
            a.Add(7.5);
            Ausgabe();

            /* Elemente einfügen */
            a.Insert(2, "Salut");
            Ausgabe();

            /* Elemente suchen */
            lstA.Items.Add("Position von 7.5: " +
                a.IndexOf(7.5));
            lstA.Items.Add("Position von 7.5: " +
                a.LastIndexOf(7.5));

            /* Element mit bestimmtem Wert entfernen */
            a.Remove(7.5);
            Ausgabe();

            /* Element an bestimmter Position entfernen */
            a.RemoveAt(1);
            Ausgabe();
        }

        private void Ausgabe()
        {
            string aus;
            int i;

            aus = "Elemente: ";
            for (i = 0; i < a.Count; i++)
                aus += a[i] + " ";
            lstA.Items.Add(aus);
        }
    }
}
