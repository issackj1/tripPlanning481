﻿#pragma checksum "..\..\Nearby.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8647A52801FC23ED7A79538BC327D8AD0C005D9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ExploreYYCHighFidelity;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ExploreYYCHighFidelity {
    
    
    /// <summary>
    /// Nearby
    /// </summary>
    public partial class Nearby : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Nearby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem popularTab;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Nearby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem upcomingTab;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Nearby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem nearbyTab;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Nearby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem bookmarkedTab;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Nearby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button calendarButton;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\Nearby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homeButton;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Nearby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button eventsButton;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\Nearby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button routesButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ExploreYYCHighFidelity;component/nearby.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Nearby.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.popularTab = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\Nearby.xaml"
            this.popularTab.Click += new System.Windows.RoutedEventHandler(this.popularTab_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.upcomingTab = ((System.Windows.Controls.MenuItem)(target));
            
            #line 37 "..\..\Nearby.xaml"
            this.upcomingTab.Click += new System.Windows.RoutedEventHandler(this.upcomingTab_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nearbyTab = ((System.Windows.Controls.MenuItem)(target));
            
            #line 43 "..\..\Nearby.xaml"
            this.nearbyTab.Click += new System.Windows.RoutedEventHandler(this.nearbyTab_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bookmarkedTab = ((System.Windows.Controls.MenuItem)(target));
            
            #line 48 "..\..\Nearby.xaml"
            this.bookmarkedTab.Click += new System.Windows.RoutedEventHandler(this.bookmarkedTab_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.calendarButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.homeButton = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\Nearby.xaml"
            this.homeButton.Click += new System.Windows.RoutedEventHandler(this.homeButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.eventsButton = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.routesButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

