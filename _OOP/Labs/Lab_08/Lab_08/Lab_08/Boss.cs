using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Lab_08;
using static Lab_08.Program;

namespace Lab_08
{
    partial class Boss
    {
        public string nameTechnique;
        public string voltage;
        public int countTechnique;

        public Boss (string name_Technique, string _voltage, int count_Technique)
        {
            this.nameTechnique = name_Technique;
            this.voltage = _voltage;
            this.countTechnique = count_Technique;
        }

        public override string ToString()
        {
            Console.WriteLine("Название техники: "+nameTechnique);
            Console.WriteLine("Напряжение для её работы: "+voltage+'B');
            Console.WriteLine("Количество техники: "+countTechnique);
            Console.WriteLine('\n');
            return "";
        }
    }

    //методы
    partial class Boss
    {
        public void upgrade(int count)
        {
            if (Convert.ToInt32(voltage) < 400)
            {
                Console.WriteLine("Техника " + nameTechnique + " с напряжением " + voltage + "B обновлена до количества " + count);
                countTechnique = count;
            }

            else if(Convert.ToInt32(voltage) > 400)
            {
                Console.WriteLine("Напряжение слишком велико! Техника сломается(((");
            }
        }

        public void turnOn()
        {
            if (Convert.ToInt32(voltage) < 400)
            {
                Console.WriteLine("Техника " + nameTechnique + " с напряжением " + voltage + "B включена! ");
            }

            else
            {
                Console.WriteLine("Напряжение слишком велико! Техника сломается и не включится(((");
            }
        }

        public deleg3 ThrowOut = () =>
        {
            Console.WriteLine("Данная техника на свалке!");
        };
    }

}
