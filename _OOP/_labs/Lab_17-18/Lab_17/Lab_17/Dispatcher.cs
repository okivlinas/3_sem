using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    public static class Dispatcher
    {
        public static void PerfomanceCheck(CarFlight flight)
        {
            List<drivers> dri = new List<drivers>();

            for (int i = 0; i < 10; i++)
            {
                    if(flight.weight <= Driver.dr[i].auto.maxWeightOfCargo && Driver.dr[i].auto.carCondition && flight.ExperienceOfDriver <= Driver.dr[i].person.DriverExperience)
                    {
                        dri.Add(Driver.dr[i]);
                    }
            }

            if(dri.Count > 0)
            {
               foreach(drivers d in dri)
               {
                    Console.Write("\nМы нашли для вашего груза водителя, его зовут ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(d.person.driverName + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Его опыт работы: " + d.person.DriverExperience + "лет");
                    Console.WriteLine("У него автомобиль с датой выпуска: " + d.auto.YearOfIssue + "года");
                    Console.WriteLine("Максимально допустимый вес груза для перевозки: " + d.auto.maxWeightOfCargo + "кг");
                }
                Console.WriteLine("***********************************");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("К сожалению, водитель не был найден!(((");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
