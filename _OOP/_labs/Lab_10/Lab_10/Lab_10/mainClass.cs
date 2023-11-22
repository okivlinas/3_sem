using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    partial class Program
    {
        public static void Main(string[] argv)
        {
            Console.WriteLine("----------------- Задание 1 -----------------");
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int len = 3;

            var findMonth = from m in month
                            where m.Length == len
                            select m;

            Console.WriteLine("\nМесяца с заданным количеством символов (" + len + "):");
            foreach (var m in findMonth)
            {
                Console.Write(m);
            }

            Console.WriteLine("\n\nЛетние и зимние месяца: ");
            var SummerAndWinter = from sw in month
                                  where sw is ( "January" or
                                        "February" or
                                        "December" or 
                                        "June" or
                                        "July" or
                                        "August" )
                                  select sw;

            foreach (var s in SummerAndWinter)
            {
                Console.Write(s + ' ');
            }


            Console.WriteLine("\n\nМесяца в алфaвитном порядке:");
            var sortmonth = from p in month orderby p select p;

            foreach (var m in sortmonth)
            {
                Console.Write("{0} ", m);
            }

            Console.WriteLine("\n\nМесяца, содержащие букву 'u': ");
            var searchU = from u in month
                          where u.Contains('u')
                          select u;

            foreach (var m in searchU)
            {
                Console.Write("{0} ", m);
            }

            Console.WriteLine("\n\nМесяца, содержащие не менее 4 символов в имени: ");
            var searchFour = from f in month
                             where f.Length >= 4
                             select f;

            foreach(var m in searchFour)
            {
                Console.Write("{0} ", m);
            }

            Console.WriteLine("\n\n----------------- Задание 2-3 -----------------");
            Console.WriteLine("\nИнформация про абонентов:\n");
            List<PHONE> abonents = new()
            {
                new("Kravchenko", 15, 2, 3),
                new("Gaikov", 22, 30, 6),
                new("Adamovich", 15, 30, 22),
                new("Avsukevich", 25, 0, 44),
                new("Novikov", 19, 0, 21),
                new("Trubach", 155, 15165, 32),
                new("Grigorenko", 51, 56, 12),
                new("Krishtal", 1, 0, 556),
                new("Patsei", 15, 0, 3),
                new("Beloded", 89, 77, 6)
            };

            foreach (var ab in abonents)
            {
                ab.ToString();
            }

            int TimeCityCall = 50;
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Cведения об абонентах, у которых время внутригородских разговоров превышает " + TimeCityCall + ':' + '\n');
            var moreCityCalls = from ms in abonents
                                where ms.TimeOfcityCalls > TimeCityCall
                                select ms;

          
            foreach (var sc in moreCityCalls)
            {
                Console.Write("{0}",sc);
            }


            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Сведения об абонентах, которые пользовались междугородной связью: \n");
            var useInternationalCalls = from ic in abonents
                                        where ic.TimeOfInternationalCalls > 0
                                        select ic;

            foreach (var ic in useInternationalCalls)
            {
                Console.Write("{0}", ic);
            }

            int deb = 3;
            Console.WriteLine("\n---------------------------------------");
            var searchDebet = (from d in abonents where d.debet == deb select d).Count();
            Console.WriteLine("Количество абонентов cо значением дебета " + deb + ": " + searchDebet +"\n");

            Console.WriteLine("\n---------------------------------------");
            var MaxOfCityCalls = (from mc in abonents select mc.TimeOfcityCalls).Max();

            Console.WriteLine("Абонент с наибольшим количеством времени разговора внутригорода:");
            foreach (var mc in abonents)
            {
                if(mc.TimeOfcityCalls == MaxOfCityCalls)
                {
                    mc.ToString();
                }
            }

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Абоненты упорядоченные по алфавиту:\n");
            var alphabet = from a in abonents orderby a.surname select a;

            foreach(var al in alphabet)
            {
                al.ToString();
            }

            Console.WriteLine("\n\n----------------- Задание 4 -----------------");
            //агрегирование
            var timeCC = (from c in abonents select c.TimeOfcityCalls).Sum();
            Console.WriteLine("Общее время разговоров внутригорода: " + timeCC + '\n');

            var averageCalls = (from ac in abonents select ac.TimeOfcityCalls).Average();
            Console.WriteLine("Среднее время разговоров внутригорода: "+averageCalls + '\n');

            //группировка
            var noIC = abonents.GroupBy(ic => ic.TimeOfInternationalCalls > 0);
            Console.WriteLine("Группировка: ");

            foreach (var mc in noIC)
            {
                if(mc.Key == true)
                {
                    Console.WriteLine("Абоненты, которые использовали междугородную связь: ");
                }

                else
                    Console.WriteLine("Абоненты, которые НЕ использовали междугородную связь: ");
                foreach(var mc2 in mc)
                {
                    Console.WriteLine(mc2.surname);
                }
                Console.WriteLine();
            }

            //кванторы
            string sm = "Kravchenko";
            Console.WriteLine("Поиск указанной фамилии: ");

            var searchSurname = abonents.Any(ss => ss.surname == sm);
            
            if (searchSurname == false)
                Console.WriteLine("Нет абонента с фамиилей "+sm+'\n');
            else
                Console.WriteLine("Абонент с фамилией " + sm + " присутствует!\n");

            //разбиение
            var result = abonents.Take(3);
            Console.WriteLine("Первых ТРИ абонента:");
            foreach(var r in result)
            {
                r.ToString();
            }

            Console.WriteLine("\n\n----------------- Задание 5 -----------------");

            abonentInfo[] abon =
            {
                new abonentInfo("Aleksey", "Belarus"), new abonentInfo("Thomas", "Germany"),
                new abonentInfo("Polina", "Belarus"), new abonentInfo("Mike", "England")
            };

            TelecommunicationOperator[] TO =
            {
                new TelecommunicationOperator("Belarus", "+375"), new TelecommunicationOperator("Germany", "+49"),
                new TelecommunicationOperator("England", "+44")
            };

            var connection = from a in abon
                             join t in TO on a.country equals t.country
                             select new { name = a.name, country = t.country, codeOfTheCountry = t.CodeOFTheCountry };

            foreach(var c in connection)
            {
                Console.WriteLine($"{c.name} - {c.country} ({c.codeOfTheCountry})");
            }
        }
    }

    partial class Program
    {
        public class abonentInfo
        {
            public string name;
            public string country;
           public abonentInfo(string _name, string _country)
            {
                this.name = _name;
                this.country = _country;
            }
        }

        public class TelecommunicationOperator
        {
            public string country;
            public string CodeOFTheCountry;

            public TelecommunicationOperator(string _country, string _codeOFTheCountry)
            {
                this.country = _country;
                CodeOFTheCountry = _codeOFTheCountry;
            }
        }
    }
}
