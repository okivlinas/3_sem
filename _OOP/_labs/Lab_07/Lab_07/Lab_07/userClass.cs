using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class CARTOONS 
    {
        public string name;
        public string _duraTION;
        public string _ageRestrictions;
        public CARTOONS(string NAME, string duraTION, string ageRestrictions)
        {
            name = NAME;
            _duraTION = duraTION;
            _ageRestrictions = ageRestrictions;
        }

        //ПЕРЕОПРЕДЕЛНИЕ БАЗОВОГО КЛАССА
        public override string ToString()
        {
            Console.WriteLine("\nИнформация про мультик: ");
            Console.WriteLine("Название: {0}", name);
            Console.WriteLine("Длительность: {0}", _duraTION);
            Console.WriteLine("Возрастные ограничения: {0}", _ageRestrictions);
            return "";
        }
    }
}
