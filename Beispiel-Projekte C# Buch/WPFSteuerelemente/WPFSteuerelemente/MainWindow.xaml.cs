using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSteuerelemente
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cb_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("eingeschaltet");
        }

        private void cb_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ausgeschaltet");
        }

        private void bu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tb.Text + " / " + tb.SelectedText);
        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded)
            {
                String ausgabe = "";
                foreach (ListBoxItem lbi in lb.SelectedItems)
                    ausgabe += lbi.Content + " ";
                MessageBox.Show(ausgabe);
            }
        }

        private void sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                MessageBox.Show(sl.Value + "");
        }
    }
}
