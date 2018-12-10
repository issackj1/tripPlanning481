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
        private event EventHandler backbutton;
        //Instantiate the pages
        SignUp signIn = new SignUp();
        Welcome_Page welcome = new Welcome_Page();
        HomePage home = new HomePage();
        HomePage1Event home1E = new HomePage1Event();
        EmptyHomePage emptyHome = new EmptyHomePage();
        Forgot_Page forgot = new Forgot_Page();
        Profile profile_page = new Profile();

        CalendarJanPage calendarJan = new CalendarJanPage();
        CalendarNovPage calendarNov = new CalendarNovPage();
        CalendarDecPage calendarDec = new CalendarDecPage();

        EventPage eventPage = new EventPage(); //zorro
        Event2Page event2Page = new Event2Page(); //christmas carol
        Event3Page event3page = new Event3Page(); //nutcracker
        ZorroRemove zorroRemove = new ZorroRemove();

        //zorro payment pages
        zorroCalendar zorroCal = new zorroCalendar();
        ZorroSchedule zorroSched = new ZorroSchedule();
        Overview overview = new Overview();
        Payment payment = new Payment();
        EmptyPayment emptyPayment = new EmptyPayment();
        Review review = new Review();

        //event pages
        Popular popularPage = new Popular();
        Upcomming upcomingPage = new Upcomming();
        Nearby nearbyPage = new Nearby();
        BookMarkedEmpty emptybookmark = new BookMarkedEmpty();
        BookMarkedWithEvent zorroBookmark = new BookMarkedWithEvent();

        Route routePage = new Route();
        Filter filterPage = new Filter();

        public ArrayList logIncredentials = new ArrayList();
        public ArrayList passWordcredentials = new ArrayList();
        public ArrayList emailCredentials = new ArrayList();
        public List<String> backLog = new List<String>();

        protected bool noEvents;
        private int sum;
        public MainWindow()
        {
            InitializeComponent();

            //this pairs the eventHandler to the Page_ButtonClick method
            welcome.pageSwitchHandler += Page_ButtonClick;
            signIn.pageSwitchHandler += Page_ButtonClick;
            home.pageSwitchHandler += Page_ButtonClick;
            home1E.pageSwitchHandler += Page_ButtonClick;
            forgot.pageSwitchHandler += Page_ButtonClick;
            emptyHome.pageSwitchHandler += Page_ButtonClick;

            //zorro
            eventPage.pageSwitchHandler += Page_ButtonClick;
            zorroCal.pageSwitchHandler += Page_ButtonClick;
            zorroSched.pageSwitchHandler += Page_ButtonClick;
            overview.pageSwitchHandler += Page_ButtonClick;
            payment.pageSwitchHandler += Page_ButtonClick;
            emptyPayment.pageSwitchHandler += Page_ButtonClick;
            review.pageSwitchHandler += Page_ButtonClick;
            profile_page.pageSwitchHandler += Page_ButtonClick;

            //calendars
            calendarJan.pageSwitchHandler += Page_ButtonClick;
            calendarNov.pageSwitchHandler += Page_ButtonClick;
            calendarDec.pageSwitchHandler += Page_ButtonClick;

            //other event pages
            event2Page.pageSwitchHandler += Page_ButtonClick;
            event3page.pageSwitchHandler += Page_ButtonClick;
            zorroRemove.pageSwitchHandler += Page_ButtonClick;

            //event search pages
            popularPage.pageSwitchHandler += Page_ButtonClick;
            upcomingPage.pageSwitchHandler += Page_ButtonClick;
            nearbyPage.pageSwitchHandler += Page_ButtonClick;
            emptybookmark.pageSwitchHandler += Page_ButtonClick;
            zorroBookmark.pageSwitchHandler += Page_ButtonClick;

            routePage.pageSwitchHandler += Page_ButtonClick;
            filterPage.pageSwitchHandler += Page_ButtonClick;

            this.backbutton += Page_ButtonClick;


            //connects switcher to this window
            Switcher.pageSwitcher = this;
            Switcher.Switch(welcome);

            welcome.logIns = logIncredentials;
            welcome.passwords = passWordcredentials;
            forgot.emails = emailCredentials;

            SignUp.pz = this;

            logIncredentials.Add("JohnDoe");
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
                    //this.background.Opacity = 0;
                    //this.Background = new SolidColorBrush(Colors.White);
                    if(noEvents == true) Switcher.Switch(emptyHome);
                    else Switcher.Switch(home);
                    break;
                case "Forgot":
                    forgot.confirmBlock.Visibility = Visibility.Hidden;
                    forgot.emailBox.Text = "";
                    Switcher.Switch(forgot);
                    break;

                //zorro cases
                case "Zorro":
                    Switcher.Switch(eventPage);
                    break;
                case "zorroCalendar":
                    Switcher.Switch(zorroCal);
                    break;
                case "zorroSchedule":
                    Switcher.Switch(zorroSched);
                    break;
                case "zorroOverview":
                    Switcher.Switch(overview);
                    break;
                case "zorroPayment":
                    Switcher.Switch(payment);
                    break;
                case "zorroEmptyPayment":
                    Switcher.Switch(emptyPayment);
                    break;
                case "zorroReview":
                    //review.setSum(sum);
                    Switcher.Switch(review);
                    break;

                case "Christmas":
                    Switcher.Switch(event2Page);
                    break;

                case "Nutcracker":
                    Switcher.Switch(event3page);
                    break;
                case "removeZorroCheck":
                    Switcher.Switch(emptyHome);
                    break;
                case "ZorroRemove":
                    Switcher.Switch(zorroRemove);
                    break;
                case "Profile":
                    Switcher.Switch(profile_page);
                    break;


                case "DecemberCalendar":
                    if(backLog.Count >= 2)
                    {
                        if (backLog[backLog.Count - 2] == "zorroCalendar")
                        {
                            page = "zorroCalendar";
                            Switcher.Switch(zorroCal);
                        }
                        else
                        {
                            Switcher.Switch(calendarDec);
                        }
                    }
                    else
                    {
                        Switcher.Switch(calendarDec);
                    }
                    break;
                case "NovemberCalendar":
                    Switcher.Switch(calendarNov);
                    break;
                case "JanuaryCalendar":
                    Switcher.Switch(calendarJan);
                    break;

                case "popularEvent":
                    Switcher.Switch(popularPage);
                    break;
                case "Upcomming":
                    Switcher.Switch(upcomingPage);
                    break;
                case "Nearby":
                    Switcher.Switch(nearbyPage);
                    break;
                case "emptyBookmark":
                    Switcher.Switch(emptybookmark);
                    break;
                case "bookmarked":
                    Switcher.Switch(zorroBookmark);
                    break;

                case "Routes":
                    Switcher.Switch(routePage);
                    break;
                case "HomePage1Event":
                    Switcher.Switch(home1E);
                    break;
                case "Filter":
                    Switcher.Switch(filterPage);
                    break;

                case "Back":
                    //MessageBox.Show(backLog[backLog.Count - 1] + ","+ backLog[backLog.Count - 2] + "," + backLog[backLog.Count - 3]);
                    SwitchEventArgs back = new SwitchEventArgs();
                    if(backLog[backLog.Count - 2] != "Back")
                    {
                        back.Page = backLog[backLog.Count - 2];
                        this.backbutton(this, back);
                        backLog.RemoveRange((backLog.Count - 2), 2);
                    }/* else if((backLog[backLog.Count - 2] != "Back"))
                    {
                        back.Page = backLog[backLog.Count - 3];
                        this.backbutton(this, back);
                        backLog.RemoveRange((backLog.Count - 3), 3);
                    }
                    else
                    {
                        for(int i = backLog.Count - 1; i < 0; i--)
                        {
                            if(backLog[i] != "Back")
                            {
                                back.Page = backLog[backLog.Count - 2];
                                this.backbutton(this, back);
                                backLog.RemoveRange((backLog.Count - 2), 2);
                            }
                        }
                    }*/
                    break;

            }
            if(page != "Back") backLog.Add(page);
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

        public void checkNewUser(bool newUser)
        {
            noEvents = true;
        }

        public void getSum(int x, int y, int z)
        {
            sum = (x * 10) + (y * 20) + (z * 50);
        }
    }
}
//site code (got from TA slides)
