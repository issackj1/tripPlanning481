using System;
using System.Collections;
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
    /// Interaction logic for Forgot_Page.xaml
    /// </summary>
    public partial class Forgot_Page : Page
    {

        public event EventHandler pageSwitchHandler;

        public ArrayList emails;

        public Forgot_Page()
        {
            InitializeComponent();
            MainWindow pz = this.Parent as MainWindow;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Welcome";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }
        
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            String email = emailBox.Text;
            if (emails.Contains(email))
            {
                confirmBlock.Visibility = Visibility.Visible;
            } else
            {
                errorBlock.Visibility = Visibility.Visible;
            }
            
        }

        private void RedirectButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Welcome";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            errorBlock.Visibility = Visibility.Hidden;
        }
    }
}
