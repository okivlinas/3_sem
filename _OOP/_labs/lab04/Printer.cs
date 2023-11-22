using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Printer
    {
        public void IAmPrinting(PrintMedia someobj)
        {
            Console.WriteLine(someobj.ToString());
        }
    }
}
