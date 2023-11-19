using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list1 = new List(new int[] {1, 2, 3});
            List list2 = new List(new int[] {4, 5, 6});

            Console.WriteLine("List 1" + string.Join(", ", list1));
            Console.WriteLine("List 2" + string.Join(", ", list2));

            List list3 = list1 + list2;
            Console.WriteLine("List 3 (List 1 + List 2):" + string.Join(", ", list3));

            List list4 = --list3;
            Console.WriteLine("List 4 (List3--): " + string.Join(", ", list4));

            bool isEqual = list1 == list2;
            Console.WriteLine("List 1 == List 2: " + isEqual);

            //bool isEmpty = list4;
            //Console.WriteLine("List 4 is empty: " + isEmpty);
        }
    }
}
