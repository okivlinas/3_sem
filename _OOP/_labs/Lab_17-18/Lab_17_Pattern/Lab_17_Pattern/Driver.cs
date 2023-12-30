using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    public enum TypeOfCar
    {
        FreightCar, car
    }
    public struct drivers
    {
        public Person person;
        public Auto auto;
        public TypeOfCar type;
        public drivers(Person p, Auto a, TypeOfCar type)
        {
            person = p;
            auto = a;
            this.type = type;
        }
    }

    public abstract class AbsractDriver
    {
        abstract public void createDriver(int maxWeight, bool Condition, int year, int exp, string name, int id);
    }

    public class Driver : AbsractDriver
    {
        public static drivers[] dr = new drivers[10];
        public TypeOfCar type;
        public Driver(TypeOfCar typ)
        {
            this.type = typ;
        }
   
        public override void createDriver(int maxWeight, bool Condition, int year, int exp, string name, int id)
        {
            if(type == TypeOfCar.FreightCar)
            {
                Auto auto = new(maxWeight, Condition, year);
                Person person = new(exp, name);
                FreightCar freCar = new(person, auto, id);
            }
            else
            {
                Auto auto = new(maxWeight, Condition, year);
                Person person = new(exp, name);
                Car c = new(person, auto, id);
            }
        }
    }

    abstract class absractCar
    { }

    abstract class abstractFreightCar
    { }

    class Car:absractCar
    {
        public Car(Person p, Auto a, int id)
        {
            Driver.dr[id].auto = a;
            Driver.dr[id].person = p;
            Driver.dr[id].type = TypeOfCar.car;
        }
        public TypeOfCar type = TypeOfCar.car;
    }

    class FreightCar:abstractFreightCar
    {
        public FreightCar(Person p, Auto a, int id)
        {
            Driver.dr[id].auto = a;
            Driver.dr[id].person = p;
            Driver.dr[id].type = TypeOfCar.FreightCar;
        }
        public TypeOfCar type = TypeOfCar.FreightCar;
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
