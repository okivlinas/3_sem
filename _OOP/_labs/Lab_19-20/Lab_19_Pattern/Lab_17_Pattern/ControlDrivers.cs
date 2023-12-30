using Lab_18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_Pattern
{
    public class ControlDrivers
    {
        public void SortDrivers()
        {
            Dispatcher.sort();
        }

        public void SearchDrivers(string name)
        {
            Dispatcher.search(name);
        }
    }
}
