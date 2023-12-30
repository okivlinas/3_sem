using Lab_18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_Pattern
{
    public interface IcheckExperience
    {
        public void check(TypeOfCar type, int id);
    }

    public class CheckExperience:IcheckExperience
    {
        public void check(TypeOfCar type, int id) 
        {
            if (type == TypeOfCar.boat)
            {
                if(DriverOfBoat.cp[id].person.DriverExperience <=2)
                {
                    Console.WriteLine("Водителю разрешается ездить с максимально допустимой скоростью 70 км/ч");
                }
                else
                {
                    Console.WriteLine("Водитель может ездить со скоростью более 70км/ч в случаых, оговоренных в правилах дорожного движения");
                }
               
            }
            else
            {
                if(Driver.dr[id].person.DriverExperience <=2)
                {
                    Console.WriteLine("Капитан пока что не очень опытный, ему не разрашается управлять судном с весом более 300т");
                }
                else
                {
                    Console.WriteLine("Капитан уже опытный!");
                }
            }
        }
    }
}
