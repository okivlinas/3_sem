using LAB_4;
using Lab_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    class Program
    {
        public static void Main(string[] argv)
        {
            ADVERTISING advertising = new("2022", "90", "14+", "Беларусь", "Гай Ричи");
            //*************
            ADVERTISING advertising_2 = new("2021", "60", "14+", "Беларусь", "Алексей Адамович");
            ADVERTISING advertising_3 = new("2020", "150", "16+", "Румыния", "Алексей Кравченко");
            //*************
            advertising.ToString();
            Console.WriteLine("-----------------------------------");

            ART_FILMS art_films = new("2015", "120", "12+", "Беларусь");
            art_films.ToString();
            Console.WriteLine("-----------------------------------");
            
            CARTOONS cartoons = new("2022", "30", "6+", "Украина");
            cartoons.ToString();
            Console.WriteLine("-----------------------------------");

            FILM film = new("2022", "210", "16+", "Беларусь");
            film.ToString();
            Console.WriteLine("-----------------------------------");

            NEWS news = new("2015", "20", "14+", "Беларусь");
            news.ToString();
            Console.WriteLine("******************************************\n");


            /*Console.WriteLine("\n\n----------Printer-----------\n\n");

            Printer Printer = new();
            var programTV = new TV_program[]
            {
            advertising,
            art_films,
            cartoons,
            film,
            news
            }; 

            foreach (var El in programTV)
            {
                Printer.IAmPrinting(El);
            }*/
            
            ProgramGuide programG = new();
            programG.AddsProgram(advertising, art_films, cartoons, film, news);
            Console.WriteLine("\n\n" + programG.ToString());

            Console.WriteLine("**********************************");
            Console.WriteLine("Введите год для поиска: ");
            string? year = Console.ReadLine();
            Console.WriteLine("\n");
            Controller.SearchByYear(programG, year);
            Console.WriteLine("**********************************");

            Console.WriteLine("\nПродолжительность всех передач: {0} минут", Controller.DurationOfProgram(programG));

            Console.WriteLine("Число рекламных роликов: {0}", Controller.CountOfAdvertising(advertising));
        }
    }
}
