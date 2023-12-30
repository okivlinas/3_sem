using Lab_18_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18
{
    public enum TypeOfCar
    {
        FreightCar, car, boat
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

        public DriverMemento saveExp(int id)
        {
                Console.WriteLine("Текущий опыт работы водителя: " + Driver.dr[id].person.DriverExperience);
                return new DriverMemento(Driver.dr[id].person.DriverExperience);
        }

        public void RestoreState(DriverMemento memento, int id)
        {
            Driver.dr[id].person.DriverExperience = memento.driverExp;
            Console.WriteLine("Восстановление опыта работы водителя: " + Driver.dr[id].person.DriverExperience);
        }
    }

    public struct captains
    {
        public Person person;
        public boat boat;
        public TypeOfCar type;
        public captains(Person p, boat b, TypeOfCar type)
        {
            person = p;
            boat = b;
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

    public class DriverOfBoat:AbsractDriver
    {
        public static captains[] cp = new captains[3];
        private readyBoat rbo;
        public override void createDriver(int maxWeight, bool Condition, int year, int exp, string name, int id)
        {
                boat boat = new(maxWeight, Condition, year);
                Person person = new(exp, name);
                readyBoat rb = new(person, boat, id);
                rbo = rb;
        }
    }

    abstract class absractCar
    { }

    abstract class abstractFreightCar
    { }

    abstract class abstractBoat
    { }

    class readyBoat:abstractBoat
    {
        public readyBoat(Person p, boat b, int id)
        {
            DriverOfBoat.cp[id].person = p;
            DriverOfBoat.cp[id].boat = b;
            DriverOfBoat.cp[id].type = TypeOfCar.boat;
        }
    }

    class Car:absractCar
    {
        public Car(Person p, Auto a, int id)
        {
            Driver.dr[id].auto = a;
            Driver.dr[id].person = p;
            Driver.dr[id].type = TypeOfCar.car;
        }
    }
    class FreightCar:abstractFreightCar
    {
        public FreightCar(Person p, Auto a, int id)
        {
            Driver.dr[id].auto = a;
            Driver.dr[id].person = p;
            Driver.dr[id].type = TypeOfCar.FreightCar;
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

    public class boat
    {
        public int maxWeightOfCargo;
        public bool boatCondition;
        public int YearOfIssue;
        public boat(int maxWeight, bool Condition, int year)
        {
            this.maxWeightOfCargo = maxWeight;
            this.boatCondition = Condition;
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
