﻿using System;
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

namespace ExploreYYCHighFidelity
{
    /// <summary>
    /// Interaction logic for EmptyPayment.xaml
    /// </summary>
    public partial class EmptyPayment : Page
    {
        public event EventHandler pageSwitchHandler;
        public EmptyPayment()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Back";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "zorroReview";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }
    }
}
