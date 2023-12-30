using Lab_16;
using System;
using System.Linq;
using System.Text;
using System.IO;


namespace Lab_16
{
    partial class Program
    {
        public static void Main(string[] argv)
        {
            string ?name = "";
            int ?weight = 0, workExperience = 0;
            Driver motorDepot = new();

            List<Driver> drivers = new List<Driver>();
             Driver[] drv =
            {
                new Driver(19,"Aleksey", 250, true, 1998),
                new Driver(25,"Artem", 2005, true, 2003),
                new Driver(59,"Dmitry", 100, true,2022),
                new Driver(79,"Aleksandr", 1500, false,2010),
                new Driver(22,"Vadim", 2500, true,2018)
            };
            while (true)
            {
                Console.WriteLine("----------- Необходимо ввести заявку ----------------");
                Console.WriteLine("Введите название товара: ");
                name = Console.ReadLine();
                Console.WriteLine("Введите вес груза: ");
                weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минимальный опыт (лет) водителя для перевозки данного груза: ");
                workExperience = Convert.ToInt32( Console.ReadLine());

                for(int i = 0; i < drv.Length; i++)
                {
                    if (drv[i].MaxWeightOfCargo >= weight && drv[i].AgeOfDriver >=workExperience && drv[i].CarCondition)
                    {
                        drivers.Add(drv[i]);
                    }
                }

                if(drivers.Count != 0)
                {
                    foreach(Driver driver in drivers)
                    {
                        Console.Write("\nМы нашли для вашего груза водителя, его зовут ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(driver.DriverName + '\n');
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Его характеристики: " + driver.ToString());
                        if (drivers.Count > 1)
                            Console.WriteLine("*****************************************************");
                    }
                    Console.WriteLine("Вы желаете отправить ещё груз?");
                    string ?choice = Console.ReadLine();
                    
                    if(choice == "да" || choice == "Да")
                    {
                        Console.Clear();
                        continue;
                    }    
                    else
                    {
                        return;
                        
                    }
                }
                else
                {
                    Console.WriteLine("\nВодители с необходимыми для вас характеристиками отсутствуют. Желаете ввести харакетеритиски груза заново?");
                    string? choice = Console.ReadLine();

                    if (choice == "да" || choice == "Да")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        return;

                    }
                }
            }
        }
    }
}