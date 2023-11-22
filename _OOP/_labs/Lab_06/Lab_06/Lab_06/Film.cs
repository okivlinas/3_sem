using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class Film
    {
        public string nameOfFilm;
        public int AgeRestrictions;
         int _age;
        public int Age
        {
            get => _age;
            
            set
            {
                if (value < AgeRestrictions)
                {
                    throw new AgeExceptionArg("Лицам в таком возрасте просмотр запрещен!", value);
                }

                else
                    _age = value;
            }
        }

        public Film(string nameOfFilm, int ageRestrictions, int age)
        {
            this.nameOfFilm = nameOfFilm;
            AgeRestrictions = ageRestrictions;
            Age = age;
        }
    }
}
