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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
	public MainWindow()
	{
	    InitializeComponent();
	    Storyboard sbD = this.FindResource("DecSb") as Storyboard;
	    sbD.Completed += OnStoryboardDec;
	    Storyboard sbJ = this.FindResource("JanSb") as Storyboard;
	    sbJ.Completed += OnStoryboardJan;
	}

	private void OnStoryboardDec(object sender, EventArgs e)
	{
	    JanuaryGrid.Visibility = Visibility.Collapsed;
	    ScheduleGrid.Visibility = Visibility.Collapsed;
	}
	private void OnStoryboardJan(object sender, EventArgs e)
	{
	    JanuaryGrid.Visibility = Visibility.Collapsed;
	    ScheduleGrid.Visibility = Visibility.Collapsed;
	}
    }
}
