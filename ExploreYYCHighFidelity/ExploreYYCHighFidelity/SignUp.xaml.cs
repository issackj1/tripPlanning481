using System;
using System.Diagnostics;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        public event EventHandler pageSwitchHandler;
        public static MainWindow pz;

        public SignUp()
        {
            InitializeComponent();
            //pz = this.Parent as MainWindow;
        }

        //What happens when back button is clicked
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution) 
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Welcome";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if(String.Equals(passBox.Text,confirmPassBox.Text) && (passBox.Text != "" || confirmPassBox.Text != ""))
            {
                pz.AddCredentials(userBox.Text, passBox.Text, emailBox.Text);

                SwitchEventArgs switchArgs = new SwitchEventArgs();
                switchArgs.Page = "Homepage";

                if (this.pageSwitchHandler != null)
                    this.pageSwitchHandler(this, switchArgs);

            } else
            {
                failBlock.Visibility = Visibility.Visible;
            }
        }
    }
}
