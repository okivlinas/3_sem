using Lab_18_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18
{
    public class Dispatcher
    {
        public static void PerfomanceCheck(CarFlight flight)
        {
            List<drivers> dri = new List<drivers>();
            List<captains> cap = new();

                for (int i = 0; i < 10; i++)
                {
                    if (flight.weight <= Driver.dr[i].auto.maxWeightOfCargo && Driver.dr[i].auto.carCondition && flight.ExperienceOfDriver <= Driver.dr[i].person.DriverExperience)
                    {
                        dri.Add(Driver.dr[i]);
                    }
                }
                for (int i = 0; i < 3; i++)
            {
                if (flight.weight <= DriverOfBoat.cp[i].boat.maxWeightOfCargo && DriverOfBoat.cp[i].boat.boatCondition && flight.ExperienceOfDriver <= DriverOfBoat.cp[i].person.DriverExperience)
                {
                    cap.Add(DriverOfBoat.cp[i]);
                }
            }

                if (dri.Count > 0)
                {
                    foreach (drivers d in dri)
                    {
                        Console.Write("\nМы нашли для вашего груза водителя, его зовут ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(d.person.driverName + "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Его опыт работы: " + d.person.DriverExperience + "лет");
                        Console.WriteLine("У него автомобиль с датой выпуска: " + d.auto.YearOfIssue + "года");
                        Console.WriteLine("Максимально допустимый вес груза для перевозки: " + d.auto.maxWeightOfCargo + "кг");
                        Console.Write("Он является водителем ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        if (d.type == TypeOfCar.FreightCar)
                        {
                            Console.Write("грузового автомобиля");
                        }
                        else if (d.type == TypeOfCar.boat)
                        {
                            Console.Write("лодки");
                        }
                        else if(d.type == TypeOfCar.car)
                        {
                            Console.WriteLine("легкового автомобиля");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    }
                    Console.WriteLine("\n***********************************");
                }
                if(cap.Count>0)
                {
                    foreach (var d in cap)
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nМы нашли для вашего груза капитана корабля, есть возможность отправить груз по морю! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nЕго имя: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(d.person.driverName + "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Его опыт работы: " + d.person.DriverExperience + "лет");
                        Console.WriteLine("У него корабль с датой выпуска: " + d.boat.YearOfIssue + "года");
                        Console.WriteLine("Максимально допустимый вес груза для перевозки: " + d.boat.maxWeightOfCargo + "кг");
                        Console.Write("Он является водителем ");

                        Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("лодки");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n***********************************");
                }
                
                if(cap.Count==0 && dri.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("К сожалению, водитель не был найден!(((");
                    Console.ForegroundColor = ConsoleColor.White;
                }
        }

        public static void sort()
        {
            List<string> drv = new();
            for(int i=0; i<10; i++)
            {
                drv.Add(Driver.dr[i].person.driverName);
            }

            var SortedDrivers = from d in drv
                                orderby d
                                select d;
            Console.WriteLine("Список имён всех водителей в алфавитном порядке:");
            foreach (var d in SortedDrivers)
            {
                Console.WriteLine(d);
            }
        }

        public static void search(string name)
        {
            for(int i=0; i<3; i++)
            {
                if (DriverOfBoat.cp[i].person.driverName == name)
                {
                    Console.Write("\nСуществует такой капитан, его зовут ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(DriverOfBoat.cp[i].person.driverName + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Его опыт работы: " + DriverOfBoat.cp[i].person.DriverExperience + "лет");
                    Console.WriteLine("У него автомобиль с датой выпуска: " + DriverOfBoat.cp[i].boat.YearOfIssue + "года");
                    Console.WriteLine("Максимально допустимый вес груза для перевозки: " + DriverOfBoat.cp[i].boat.maxWeightOfCargo + "кг");
                    Console.Write("Он является водителем ");
                    Console.Write("лодки");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
            }
        }

        public static void _CheckExperience(TypeOfCar tp, int id)
        {
            CheckExperience ch = new();
            ch.check(tp, id);
        }

    }
}
