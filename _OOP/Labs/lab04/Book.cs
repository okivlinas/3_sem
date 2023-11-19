using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Book : PrintMedia
    {
        public string Author { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Book Title: " + Title);
            Console.WriteLine("Year of Publication: " + Year);
            Console.WriteLine("Author: " + Author);
        }
    }
}
