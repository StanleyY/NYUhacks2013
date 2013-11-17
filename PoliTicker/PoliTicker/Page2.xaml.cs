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

        private void Approval_OnLoad(object sender, RoutedEventArgs e)
        {
            double pos = Globals.nysGovPos;
            double neg = Globals.nysGovNeg;

            p1.Offset = pos/(pos + neg);
            p2.Offset = p1.Offset;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Bio.Text = Globals.number.ToString();
            //Globals.number += 1;
        }

        private void gotoVoting(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }

        private void Bio_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            if (Globals.number > 10 && Globals.number < 20)
            {
                Bio.Text = "lol";
            }

            if(Globals.number > 19)
            {
                int i = 0;
                foreach (Comment stuff in Globals.nysGovComments)
                {
                    i= i+1;
                    Bio.Text = stuff.message;
                }

                Bio.Text = Bio.Text + i.ToString();
            }*/
        }

        private void PercentageLoaded(object sender, RoutedEventArgs e)
        {
            double pos = Globals.nysGovPos;
            double neg = Globals.nysGovNeg;
            double percent = pos / (neg + pos);

            ApprovalPercentage.Text = "Approval Rating: " + Convert.ToInt32(percent * 100).ToString() + "%";
        }

        private void CountVotes(object sender, RoutedEventArgs e)
        {
            VoteCount.Text = "Number of Votes: " + (Globals.nysGovNeg + Globals.nysGovPos).ToString();
        }
    }
} 