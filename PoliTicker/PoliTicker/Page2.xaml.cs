using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Threading;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PoliTicker
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void ApprovalChange(object sender, RoutedEventArgs e)
        {
            p1.Offset = 0.5;
            p2.Offset = 0.5;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}