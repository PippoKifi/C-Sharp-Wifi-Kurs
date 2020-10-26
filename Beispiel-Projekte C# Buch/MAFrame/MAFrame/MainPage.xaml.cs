﻿using System;
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

namespace MAFrame
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

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            fr.Navigate(typeof(Seite1));
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            fr.Navigate(typeof(Seite2));
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            fr.Navigate(typeof(Seite3));
        }
    }
}