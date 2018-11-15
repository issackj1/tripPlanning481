using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreYYCHighFidelity
{
    //The event class for switching pages
    class SwitchEventArgs : EventArgs
    {
        public String Page
        {
            get; set;
        }
    }
}
