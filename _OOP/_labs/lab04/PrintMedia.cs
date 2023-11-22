using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public abstract class PrintMedia
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public abstract void PrintInfo();
    }
}
