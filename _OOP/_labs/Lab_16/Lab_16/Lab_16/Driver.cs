using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    public class Driver
    {
        //public Driver[] drv =
        //{
        //    new Driver(19,"Aleksey", 250, true, 1998),
        //    new Driver(25,"Artem", 250, true, 2003),
        //    new Driver(59,"Dmitry", 250, true,2022),
        //    new Driver(79,"Aleksandr", 250, false,2010),
        //    new Driver(22,"Vadim", 250, true,2018)
        //};


        public int AgeOfDriver;
        public string DriverName;
        private int _AgeOfDriver
        {
            get 
            { 
                return AgeOfDriver; 
            }

            set
            {
                AgeOfDriver = value;
            }
        }

        #region auto
            public int MaxWeightOfCargo;
            private int _MaxWeightOfCargo
            {
                get 
                {
                    return MaxWeightOfCargo; 
                }

                set 
                {
                    MaxWeightOfCargo = value; 
                }
            }
            public bool CarCondition;
            public int YearOfIssue;
        #endregion


        public Driver(int ageOfDriver, string driverName, int maxWeight, bool carCond, int yearIssue)
        {
            _AgeOfDriver = ageOfDriver;
            DriverName = driverName;
            _MaxWeightOfCargo= maxWeight;
            CarCondition = carCond;
            YearOfIssue = yearIssue;
        }
        public Driver()
        {
        }

        public override string ToString()
        {
            return $"\nИмя водителя:{DriverName}\nСтаж работы:{AgeOfDriver}лет\n--------------------------" +
                $"\nХарактеристики автомобиля:\nМаксимальный вес груза:{MaxWeightOfCargo}кг\nГод выпуска:{YearOfIssue}год" +
                $"\nСостояние автомобиля:{CarCondition}";
        }
    }
}
