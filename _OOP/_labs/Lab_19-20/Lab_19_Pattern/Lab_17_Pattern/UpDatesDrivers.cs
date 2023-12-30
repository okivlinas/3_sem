using Lab_18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_Pattern
{
    public static class UpDatesDrivers
    {
        public static void MakeDriverWithMoreExperience(TypeOfCar type, int id, int n)
        {
            if(type == TypeOfCar.boat)
            {
                DriverOfBoat.cp[id].person.DriverExperience += n;
                Console.WriteLine("Опыт работы водителя увеличен, теперь " + DriverOfBoat.cp[id].person.driverName + " имеет опыт " + DriverOfBoat.cp[id].person.DriverExperience);
            }
            else
            {
                Driver.dr[id].person.DriverExperience += n;
                Console.WriteLine("Опыт работы водителя увеличен, теперь " + Driver.dr[id].person.driverName + " имеет опыт " + Driver.dr[id].person.DriverExperience);

            }
        }
    }
}
