using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    class GenericStandardTypes <T>
    {
        T X { get; set; }
        T Y { get; set; }
        public GenericStandardTypes(T _x, T _y)
        {
            X = _x; Y = _y;
        }

        public void Print(string message)
        {
            Console.Write(message + " = ");
            Console.WriteLine($"x = {X}, y = {Y}");
        }
    }
}
