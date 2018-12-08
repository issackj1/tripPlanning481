using System;
using System.Collections;
using System.Diagnostics; //I put this class here for debugging purposes. Use Debug.WriteLine(var) like you would printf and itll output it in the debug window
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Instantiate the pages
        SignUp signIn = new SignUp();
        Welcome_Page welcome = new Welcome_Page();
        HomePage home = new HomePage();
        EmptyHomePage EmptyHome = new EmptyHomePage();
        Forgot_Page forgot = new Forgot_Page();
        EventPage eventPage = new EventPage();
        Payment payment = new Payment();
        Overview overview = new Overview();


        public ArrayList logIncredentials = new ArrayList();
        public ArrayList passWordcredentials = new ArrayList();
        public ArrayList emailCredentials = new ArrayList();

        public MainWindow()
        {
            InitializeComponent();

            //this pairs the eventHandler to the Page_ButtonClick method
            welcome.pageSwitchHandler += Page_ButtonClick;
            signIn.pageSwitchHandler += Page_ButtonClick;
            home.pageSwitchHandler += Page_ButtonClick;
            forgot.pageSwitchHandler += Page_ButtonClick;
            home.pageSwitchHandler += Page_ButtonClick;


            //connects switcher to this window
            Switcher.pageSwitcher = this;
            Switcher.Switch(welcome);

            welcome.logIns = logIncredentials;
            welcome.passwords = passWordcredentials;
            forgot.emails = emailCredentials;

            SignUp.pz = this;

            logIncredentials.Add("John Doe");
            passWordcredentials.Add("12345");
            emailCredentials.Add("johndoe@gmail.com");
        }

        //This method handles the page switching events 
        private void Page_ButtonClick(object sender, EventArgs e)
        {
            //gets the string object of the signaled event and decided which page is requested
            String page = ((SwitchEventArgs) e).Page;

            //Basically a series of if/else statements
            switch (page)
            {
                case "Welcome":
                    Switcher.Switch(welcome);
                    welcome.failBlock.Visibility = Visibility.Hidden;
                    break;
                case "Signup":
                    Switcher.Switch(signIn);
                    break;
                case "Homepage":
                    this.background.Opacity = 0;
                    this.Background = new SolidColorBrush(Colors.White);
                    Switcher.Switch(EmptyHome);
                    break;
                case "Forgot":
                    forgot.confirmBlock.Visibility = Visibility.Hidden;
                    forgot.emailBox.Text = "";
                    Switcher.Switch(forgot);
                    break;
                case "Zorro":
                    Switcher.Switch(eventPage);
                    break;
            }
        }

        //changes the pages in the window
        public void Navigate(Page nextPage)
        {
            this.Content = nextPage;
        }

        public void AddCredentials(String email, String login, String pass)
        {
            logIncredentials.Add(login);
            passWordcredentials.Add(pass);
            emailCredentials.Add(email);
        }
    }
}
//site code (got from TA slides)