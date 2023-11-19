using LAB_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class ADVERTISING:TV_program, INFORMATION
    {
        static int count = 0;
        public int count_2
        {
            get { return count; }

            set => count = value;
        }
        public override void yearOfIssue(string yearOfIssue)
        {
            Console.WriteLine("Время начала: {0}", yearOfIssue);
            this._YearOfIssue = yearOfIssue;
        }

        public override void duration(string dur)
        {
            Console.WriteLine("Длительность: {0}", dur);
            this._duraTION = dur;
        }

        public override void country(string country)
        {
            Console.WriteLine("Страна: {0}", country);
            this._country = country;
        }

        public ADVERTISING(string yearOfIssue, string duraTION, string ageRestrictions, string country, string name)
        {
            count++;
            _YearOfIssue = yearOfIssue;
            _duraTION = duraTION;
            _country = country;
            _name = name;
        }

        public ADVERTISING()
        {
            count++;
        }

        //----------------------------------------------//
        public string _name;
        public void name(string name)
        {
            Console.WriteLine("Имя: {0}", name);
            this._name = name;
        }
        public string age(string age)
        {
            Console.WriteLine("Возраст: {0}", age);
            return age;
        }

        void INFORMATION.country(string country)
        {
            Console.WriteLine("Страна: {0}", country);
        }

        public override string ToString()
        {
            Console.WriteLine("Реклама: ");
            Console.WriteLine("Год выпуска: {0}", _YearOfIssue);
            Console.WriteLine("Длительность: {0} минут", _duraTION);
            Console.WriteLine("Страна: {0}", _country);
            Console.WriteLine("Имя режиссера: {0}",_name);
            return "";
        }
    }
}
