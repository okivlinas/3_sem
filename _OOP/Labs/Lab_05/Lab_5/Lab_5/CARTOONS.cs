using LAB_4;

namespace Lab_04
{
    public class CARTOONS:TV_program
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

        public CARTOONS(string yearOfIssue, string duraTION, string ageRestrictions, string country)
        {
            _YearOfIssue = yearOfIssue;
            _duraTION = duraTION;
            _country = country;
        }



        //ПЕРЕОПРЕДЕЛНИЕ БАЗОВОГО КЛАССА
        public override string ToString()
        {
            Console.WriteLine("Мультики: ");
            Console.WriteLine("Год выпуска: {0}", _YearOfIssue);
            Console.WriteLine("Длительность: {0} минут", _duraTION);
            Console.WriteLine("Страна: {0}", _country);
            return "";
        }
    }
}
