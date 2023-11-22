using lab02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class TrainClass
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[3];
            trains[0] = new Train(127, "Мозырь", "18:18", 350);
            trains[1] = new Train(258, "Минск", "00:08", 1500);
            trains[2] = new Train(057, "Мозырь", "21:55", 350);
            int newSeats1 = 1000;
            trains[0].ChangeSeats(ref newSeats1);
            for (int i = 0; i < Train.count; i++)
            {
                Console.WriteLine("_______________________");
                trains[i].DisplayInfo();
            }
            Console.WriteLine("_______________________");
            Console.WriteLine("Сравнение trains1 и trains2: " + trains[1].Equals(trains[2]));
            Console.WriteLine("_______________________");
            Console.WriteLine("Введите город для поиска поездов");
            string destinationSearch = Console.ReadLine();
            foreach (Train train1 in trains)
            {
                if (train1.Destination == destinationSearch)
                {
                    Train.count++;
                    
                    train1.DisplayInfo();
                }
            }
            Console.WriteLine("_______________________");
        }
    }
}

