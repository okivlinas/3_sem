using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    //сделать грузовые и легковые автомобилиы
    public struct drivers
    {
        public Person person;
        public Auto auto;
        public drivers(Person p, Auto a)
        {
            person = p;
            auto = a;
        }
    }

    public static class Driver
    {
        public static drivers[] dr = new drivers[10];
        static public void createDriver(int maxWeight, bool Condition, int year, int exp, string name, int id)
        {
            Auto auto = new(maxWeight, Condition, year);
            Person person = new(exp, name);
            dr[id].person = person;
            dr[id].auto = auto;
        }
    }

    public class Auto
    {
        public int maxWeightOfCargo;
        public bool carCondition;
        public int YearOfIssue;
        public Auto(int maxWeight, bool Condition, int year)
        {
            this.maxWeightOfCargo = maxWeight;
            this.carCondition = Condition;
            YearOfIssue = year;
        }
    }

    public class Person
    {
        public int DriverExperience;
        public string driverName;
        public Person(int Experience, string Name)
        {
            DriverExperience = Experience;
            this.driverName = Name;
        }
    }
}
