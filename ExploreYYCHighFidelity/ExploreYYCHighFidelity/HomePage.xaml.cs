using System;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public event EventHandler pageSwitchHandler;

        public HomePage()
        {
            InitializeComponent();
            //MainWindow mainWindow = this.Parent as MainWindow;
        }

        private void zorroButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "ZorroRemove";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }

        private void christmasButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Christmas";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }

        private void nutcrackerButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Nutcracker";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }

        private void calendarButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "CalendarEvents";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }

        private void eventsButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "popularEvent";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }

        private void routesButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Routes";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }
    }
}