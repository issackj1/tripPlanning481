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
    /// Interaction logic for PageTemplate.xaml
    /// </summary>
    public partial class Overview : Page
    {
        public event EventHandler pageSwitchHandler;
        public static MainWindow pz;
        private int basic;
        private int floor;
        private int VIP;
        public Overview()
        {
            InitializeComponent();
            pz = this.Parent as MainWindow;
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution)
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            //basic = int.Parse(basicBox.Text);
            //floor = int.Parse(floorBox.Text);
            //VIP = int.Parse(VIPBox.Text);
            //pz.getSum(basic, floor, VIP);
            switchArgs.Page = "zorroPayment";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
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
    }
}
