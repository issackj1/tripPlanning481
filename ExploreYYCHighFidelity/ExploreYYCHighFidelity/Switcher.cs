using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ExploreYYCHighFidelity
{
    class Switcher
    {
        public static MainWindow pageSwitcher;

        //What switches to the next page
        public static void Switch(Page newPage)
        {
            pageSwitcher.Navigate(newPage);
        }
    }
}
