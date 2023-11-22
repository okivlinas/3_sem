using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Textbook : PrintMedia
    {
        public string Subject { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Textbook Title: " + Title);
            Console.WriteLine("Year of Publication: " + Year);
            Console.WriteLine("Subject: " + Subject);
        }
    }
}
