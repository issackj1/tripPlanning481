﻿#pragma checksum "..\..\EventPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0060E3E4F70C2B334F7335AC04FE8FDA7FBA482A"
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
    /// EventPage
    /// </summary>
    public partial class EventPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 76 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Eventpage;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button calendarButton;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homeButton;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\EventPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button eventsButton;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\EventPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ExploreYYCHighFidelity;component/eventpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EventPage.xaml"
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
            this.Eventpage = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            
            #line 93 "..\..\EventPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 167 "..\..\EventPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.calendarButton = ((System.Windows.Controls.Button)(target));
            
            #line 179 "..\..\EventPage.xaml"
            this.calendarButton.Click += new System.Windows.RoutedEventHandler(this.calendarButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.homeButton = ((System.Windows.Controls.Button)(target));
            
            #line 185 "..\..\EventPage.xaml"
            this.homeButton.Click += new System.Windows.RoutedEventHandler(this.homeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.eventsButton = ((System.Windows.Controls.Button)(target));
            
            #line 191 "..\..\EventPage.xaml"
            this.eventsButton.Click += new System.Windows.RoutedEventHandler(this.eventsButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.routesButton = ((System.Windows.Controls.Button)(target));
            
            #line 197 "..\..\EventPage.xaml"
            this.routesButton.Click += new System.Windows.RoutedEventHandler(this.routesButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

