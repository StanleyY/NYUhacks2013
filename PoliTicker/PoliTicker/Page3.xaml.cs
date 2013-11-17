using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace PoliTicker
{
    public partial class Page3 : PhoneApplicationPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void NewCommentFocused(object sender, RoutedEventArgs e)
        {
            if (NewComment.Text == "Please Leave a Comment")
            {
                NewComment.Text = "";
            }
        }

        private void ClickedUp(object sender, RoutedEventArgs e)
        {
            if(Globals.hasVoted == 1)
            {
                return;
            }

            BitmapImage pics;

            if(Globals.upChecked == 1)
            {
                pics = new BitmapImage(new Uri("greythumbu.png", UriKind.Relative));
                Globals.upChecked = 0;
            }

            else
            {
                if(Globals.downChecked == 0)
                {
                    pics = new BitmapImage(new Uri("thumbup.png", UriKind.Relative));
                    Globals.upChecked = 1;
                }
                else
                {
                    return;
                }
            }

            Upvote.Source = pics;
        }

        private void ClickedDown(object sender, RoutedEventArgs e)
        {
            if (Globals.hasVoted == 1)
            {
                return;
            }

            BitmapImage pics;

            if (Globals.downChecked == 1)
            {
                pics = new BitmapImage(new Uri("greythumbd.png", UriKind.Relative));
                Globals.downChecked = 0;
            }

            else
            {
                if (Globals.upChecked == 0)
                {
                    pics = new BitmapImage(new Uri("thumbdown.png", UriKind.Relative));
                    Globals.downChecked = 1;
                }
                else
                {
                    return;
                }
            }

            Downvote.Source = pics;

        }

        private void CheckSubmission(object sender, RoutedEventArgs e)
        {
            if(Globals.hasVoted == 1)
            {
                SubmitButton.Content = "Thank You for Your Comment!";
                return;
            }

        }

        private void Submission(object sender, RoutedEventArgs e)
        {
            if(Globals.hasVoted == 1)
            {
                return;
            }

            if(Globals.upChecked == 0 && Globals.downChecked == 0)
            {
                return;
            }

            Globals.hasVoted = 1;
            SubmitButton.Content = "Thank You for Your Comment!";
            Globals.nysGovMsg = NewComment.Text;
            NewComment.IsReadOnly = true;
            if(Globals.upChecked == 1)
            {
                Globals.nysGovPos = Globals.nysGovPos + 1;
            }
            else
            {
                Globals.nysGovNeg = Globals.nysGovNeg + 1;
            }

        }

        private void checkForComment(object sender, RoutedEventArgs e)
        {
            if(Globals.hasVoted == 1)
            {
                NewComment.Text = Globals.nysGovMsg;
                NewComment.IsReadOnly = true;
            }
        }

        private void LoadComments(object sender, RoutedEventArgs e)
        {
            int i = 1;
            foreach (Comment stuff in Globals.nysGovComments)
            {
                BitmapImage pics;

                if (stuff.value == 0)
                {
                    pics = new BitmapImage(new Uri("thumbdown.png", UriKind.Relative));
                }
                else
                {
                    pics = new BitmapImage(new Uri("thumbup.png", UriKind.Relative));
                }
                Image pic = new Image();

                pic.Source = pics;
                pic.Height = 50;
                pic.Width = 50;
                pic.HorizontalAlignment = HorizontalAlignment.Left;
                
//                MessageBox.Show("wut");

                i = i + 1;

                TextBlock block = new TextBlock();

                block.Width = 331;
                block.Text = stuff.message;
                block.TextWrapping = TextWrapping.Wrap;
                CommentList.Children.Add(pic);
                CommentList.Children.Add(block);

                //pic.Source = new Uri("greythumbsu.png", UriKind.Relative);
            }
           //<Image Source="greythumbu.png" Height="50" Width="50" HorizontalAlignment="Left" VerticalAlignment="Top"/>
           //         <TextBlock TextWrapping="Wrap" Text="TextBlock" Width="331"/>
        }
        private void UpvoteLoaded(object sender, RoutedEventArgs e)
        {
            if(Globals.upChecked == 1)
            {
                if (Globals.hasVoted == 0)
                {
                    Globals.upChecked = 0;
                }
                else
                {
                    Upvote.Source = new BitmapImage(new Uri("thumbup.png", UriKind.Relative));
                }
            }
        }

        private void DownvoteLoaded(object sender, RoutedEventArgs e)
        {
            if (Globals.downChecked == 1)
            {
                if (Globals.hasVoted == 0)
                {
                    Globals.downChecked = 0;
                }
                else
                {
                    Downvote.Source = new BitmapImage(new Uri("thumbdown.png", UriKind.Relative));
                }
            }
        }

    }
}