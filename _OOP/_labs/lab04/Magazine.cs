using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Magazine : PrintMedia
    {
        public string Publisher { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Magazine Title: " + Title);
            Console.WriteLine("Year of Publication: " + Year);
            Console.WriteLine("Publisher: " + Publisher);
        }
    }
}
