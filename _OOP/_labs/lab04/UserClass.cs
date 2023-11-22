using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class UserClass : BaseClone, ICloneable
    {
        public override bool DoClone()
        {
            Console.WriteLine("UserClass DoClone method called");
            return true;
        }

        bool ICloneable.DoClone()
        {
            Console.WriteLine("ICloneable DoClone method called");
            return true;
        }
    }
}
