using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;

namespace WPFInForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Windows.Controls.Button nb = new System.Windows.Controls.Button();
            nb.Content = "WPF Button";
            nb.Click += new RoutedEventHandler(nb_Click);
            ehost1.Child = nb;

            StackPanel sp = new StackPanel();
            for (int i = 1; i <= 3; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = "Inhalt " + i;
                sp.Children.Add(tb);
            }
            Expander ep = new Expander();
            ep.Header = "WPF Expander";
            ep.Content = sp;
            ehost2.Child = ep;
        }

        private void nb_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show((sender as System.Windows.Controls.Button).Content + "");
        }

        private void WFO_Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Windows Forms Button");
        }
    }
}
