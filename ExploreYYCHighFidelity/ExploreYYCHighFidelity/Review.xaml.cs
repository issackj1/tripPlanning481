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
    /// Interaction logic for Review.xaml
    /// </summary>
    public partial class Review : Page
    {
        public event EventHandler pageSwitchHandler;
        public Review()
        {
            InitializeComponent();
        }

        /*public void setSum(int z)
        {
            sumBlock.Text = "Item Total:         " + z.ToString();
        }*/

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution)
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "Back";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }

        private void bookButton_Click(object sender, RoutedEventArgs e)
        {
            //Makes a new SwitchEventArgs (class in solution)
            SwitchEventArgs switchArgs = new SwitchEventArgs();
            switchArgs.Page = "HomePage1Event";

            //if pageSwitchHandler exists, it sends a signal to Page_ButtonClick in MainWindow.xaml.cs that a button is clicked and it needs to switch the page
            if (this.pageSwitchHandler != null)
                this.pageSwitchHandler(this, switchArgs);
        }
    }
}
