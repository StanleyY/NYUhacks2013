using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PoliTicker
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void gotoGovernor(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

        private void gotoMayor(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.Relative));
        }

    }
}