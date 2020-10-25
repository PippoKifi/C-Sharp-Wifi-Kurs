using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace MASteuerelemente
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet werden kann oder auf die innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void bu_Click(object sender, RoutedEventArgs e)
        {
            tk.Text = "Button geklickt";
        }

        private void cb_Checked(object sender, RoutedEventArgs e)
        {
            tk.Text = "CheckBox ein";
        }

        private void cb_Unchecked(object sender, RoutedEventArgs e)
        {
            tk.Text = "CheckBox aus";
        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tk.Text = lb.SelectedIndex + "";
        }

        private void pb_LostFocus(object sender, RoutedEventArgs e)
        {
            tk.Text = pb.Password;
        }

        private void rb1_Click(object sender, RoutedEventArgs e)
        {
            tk.Text = "Auswahl 1";
        } 

        private void rb2_Click(object sender, RoutedEventArgs e)
        {
            tk.Text = "Auswahl 2";
        }

        private void sl_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            tk.Text = sl.Value + "";
        }

        private void tx_LostFocus(object sender, RoutedEventArgs e)
        {
            tk.Text = tx.Text;
        }
    }
}
