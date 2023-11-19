using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class Cartoon
    {
        public string nameOfCartoon;
        private int _startTime;
        public int _TimeOfSleep;
        public int startTime
        {
            get { 
                return _startTime; 
            }  
            set { 
                _startTime = value; 
            }
        }

        public int TimeOfSleep
        {
            get => _TimeOfSleep;

            set
            {
                if (value < _startTime)
                    throw new SleepExceptionArg("Вы не сможете в это время смотреть мультфильм, вы будете спать!", value, _startTime);
                else
                    _TimeOfSleep = value;
            }
        }


      public Cartoon(string nameOfCartoon, int startTime, int timeOfSleep)
        {
            this.nameOfCartoon = nameOfCartoon;
            this.startTime = startTime;
            TimeOfSleep = timeOfSleep;
        }
    }
}
