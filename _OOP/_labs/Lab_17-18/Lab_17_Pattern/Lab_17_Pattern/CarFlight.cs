using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    public class CarFlight
    {
        public string name;
        public int weight;
        public int ExperienceOfDriver;

        public CarFlight(string n, int w, int expDriver)
        {
            this.name = n;
            this.weight = w;
            ExperienceOfDriver = expDriver;
        }
    }
}
