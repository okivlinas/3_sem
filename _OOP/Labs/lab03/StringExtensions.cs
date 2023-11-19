using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    static class StringExtensions
    {
        public static int GetLastNumber(this string str)
        {
            string numberStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(str[i]))
                    numberStr = str[i] + numberStr;
                else if (numberStr.Length > 0)
                    break;
            }
            return int.Parse(numberStr);
        }

        public static List RemoveElement(this List<int> list, int element)
        {
            int[] newElements = new int[list.Count - 1];
            int newIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != element)
                {
                    newElements[newIndex] = list[i];
                    newIndex++;
                }
            }
            return new List(newElements);
        }
    }
}
