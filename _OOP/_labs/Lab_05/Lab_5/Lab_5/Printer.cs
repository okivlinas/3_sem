using LAB_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    class Printer
    {
        public void IAmPrinting(TV_program _tvProgram)
        {
            if (_tvProgram is ADVERTISING adv)
            {
                Console.WriteLine(
                    $"Тип данных: класс ADVERTISING\n" +
                    $"{adv.ToString()}\n"
                    );
            }
            else if (_tvProgram is ART_FILMS art)
            {
                Console.WriteLine(
                    $"Тип данных: класс ART_FILMS\n" +
                    $"{art.ToString()}\n"
                    );
            }
            else if (_tvProgram is CARTOONS cart)
            {
                Console.WriteLine(
                    $"Тип данных: класс CARTOONS\n" +
                    $"{cart.ToString()}\n"
                    );
            }
            else if (_tvProgram is FILM fi)
            {
                Console.WriteLine(
                    $"Тип данных: класс FILM\n" +
                    $"{fi.ToString()}\n"
                    );
            }
            else if (_tvProgram is NEWS _news)
            {
                Console.WriteLine(
                    $"Тип данных: класс NEWS\n" +
                    $"{_news.ToString()}\n"
                    );
            }
        }
    }
}
