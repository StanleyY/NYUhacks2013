﻿#pragma checksum "c:\users\stanl_000\documents\visual studio 2013\Projects\PoliTicker\PoliTicker\Page2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2AA66A098750AB55D4EEDAE6BDEE42A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PoliTicker {
    
    
    public partial class Page2 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Shapes.Rectangle Approval_Rating;
        
        internal System.Windows.Media.LinearGradientBrush stuff;
        
        internal System.Windows.Media.GradientStop p1;
        
        internal System.Windows.Media.GradientStop p2;
        
        internal System.Windows.Controls.TextBlock ApprovalPercentage;
        
        internal System.Windows.Controls.TextBlock VoteCount;
        
        internal System.Windows.Controls.TextBlock ApprovalText;
        
        internal System.Windows.Controls.TextBlock Bio;
        
        internal System.Windows.Controls.Button VotingNavigation;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PoliTicker;component/Page2.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Approval_Rating = ((System.Windows.Shapes.Rectangle)(this.FindName("Approval_Rating")));
            this.stuff = ((System.Windows.Media.LinearGradientBrush)(this.FindName("stuff")));
            this.p1 = ((System.Windows.Media.GradientStop)(this.FindName("p1")));
            this.p2 = ((System.Windows.Media.GradientStop)(this.FindName("p2")));
            this.ApprovalPercentage = ((System.Windows.Controls.TextBlock)(this.FindName("ApprovalPercentage")));
            this.VoteCount = ((System.Windows.Controls.TextBlock)(this.FindName("VoteCount")));
            this.ApprovalText = ((System.Windows.Controls.TextBlock)(this.FindName("ApprovalText")));
            this.Bio = ((System.Windows.Controls.TextBlock)(this.FindName("Bio")));
            this.VotingNavigation = ((System.Windows.Controls.Button)(this.FindName("VotingNavigation")));
        }
    }
}

