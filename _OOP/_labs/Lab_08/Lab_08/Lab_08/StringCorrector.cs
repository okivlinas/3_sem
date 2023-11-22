using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
     class StringCorrector
    {
        public Action<string> CorrectStr;
        public Action<string, char> CorrectStr2;
        public void DelPunct(string str)
        {
            str = str.Replace("!", "");
            str = str.Replace(".", "");
            str = str.Replace(",", "");
            str = str.Replace(":", "");
            str = str.Replace(";", "");
            str = str.Replace("?", "");
            Console.WriteLine("Удаление знаков препинания: " + str);
        }

        public void AddSymb(string str, char symb)
        {
            Console.WriteLine($"Строка с символом {symb}: " + str + symb);
        }

        public void UpperCase(string str)
        {
            str = str.ToUpper();
            Console.WriteLine("Строка в верхнем регистре: " + str);
        }

        public void DelSpace(string str)
        {
            str = str.Replace(" ", "");
            Console.WriteLine("Строка без пробелов: " + str);
        }

        public StringCorrector() //конструктор
        {
            CorrectStr2 +=AddSymb;
        }
    }
}
