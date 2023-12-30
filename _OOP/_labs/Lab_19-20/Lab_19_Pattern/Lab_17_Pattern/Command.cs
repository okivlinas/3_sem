using Lab_18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_Pattern
{
    interface ICommand
    {
        public void search(string name);
        public void sort();
    }
    public class Command:ICommand
    {
        private ControlDrivers control_driver;
        public Command(ControlDrivers _control_driver)
        {
            this.control_driver = _control_driver;
        }

        public void search(string name)
        {
            control_driver.SearchDrivers(name);
        }

        public void sort()
        {
            control_driver.SortDrivers();
        }
    }
}
