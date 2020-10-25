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

namespace WPFLayoutKombi
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

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("b1");
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("b2");
        }

        private void sp_Click(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            MessageBox.Show(b.Name);
        }
    }
}
