using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    public static class Dispatcher <T> where T : class, new()
    {
        public static int CountOfAplications;
        public static int _CountOfAplications
        {
            get { 
                return CountOfAplications; 
                }

            set { 
                CountOfAplications = value; 
                }
        }

      
        

    }
}
