using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_Pattern
{
    public class DriverMemento
    {
        public int driverExp;
        public DriverMemento(int _driverExp)
        { 
            this.driverExp = _driverExp; 
        }
    }

    public class DriverHistory
    {
        public Stack<DriverMemento> history;
         public DriverHistory() 
         { 
            history = new Stack<DriverMemento>();
         }
    }
}
