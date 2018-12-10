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
    /// Interaction logic for Welcome_Page.xaml
    /// </summary>
    public partial class Welcome_Page : Page
    {

        //The event handler for this page to handle page switches
        public event EventHandler pageSwitchHandler;

        public ArrayList logIns;
        public ArrayList passwords;
        public static MainWindow pz;

        public Welcome_Page()
        {
            InitializeComponent();
            MainWindow pz = this.Parent as MainWindow;

        }
        //What happens when log In button is clicked
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            String logIn = userBox.Text;
            String pw = passBox.Password.ToString();
            bool valid = false;
            for(int i = 0; i < logIns.Count; i++)
            {
                if(String.Equals(logIn, logIns[i]) && (String.Equals(pw, passwords[i])))
                {
                    valid = true;
                    break;
                }
            }
            if(valid == false)
            {
                failBlock.Visibility = Visibility.Visible;
            } else
            {
                pz.checkNewUser(false);
                //Makes a new SwitchEventArgs (class in solution) 
                SwitchEventArgs switchArgs = new SwitchEventArgs();
                switchArgs.Page = "Homepage";

                //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
                if (this.pageSwitchHandler != null)
                    this.pageSwitchHandler(this, switchArgs);
            }
        }

        //What happens when sign up button is clicked
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Signup";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);

        }

        private void forgotButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Forgot";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }
    }
}
