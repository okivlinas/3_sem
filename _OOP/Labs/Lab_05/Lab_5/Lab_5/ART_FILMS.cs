using LAB_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class ART_FILMS:TV_program
    {
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

        public ART_FILMS(string yearOfIssue, string duraTION, string ageRestrictions, string country)
        {
            _YearOfIssue = yearOfIssue;
            _duraTION = duraTION;
            _country = country;
        }



        //ПЕРЕОПРЕДЕЛНИЕ БАЗОВОГО КЛАССА
        public override string ToString()
        {
            Console.WriteLine("Художественный фильм: ");
            Console.WriteLine("Год выпуска: {0}", _YearOfIssue);
            Console.WriteLine("Длительность: {0} минут", _duraTION);
            Console.WriteLine("Страна: {0}", _country);
            return "";
        }

        public string Information_about_ART_FILMS { get; set; } = "";

        public override int GetHashCode()
        {
            return Information_about_ART_FILMS.GetHashCode();
        }

        //GetType не переопределяется

        public string Name { get; set; } = "";
        public override bool Equals(object? obj)
        {
            // если параметр метода представляет тип Person
            // то возвращаем true, если имена совпадают
            if (obj is ART_FILMS person) return Name == person.Name;
            return false;
        }
    }
}
