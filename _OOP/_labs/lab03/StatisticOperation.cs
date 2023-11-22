using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    static class StatisticOperation
    {
        public static int Sum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }

        public static int Difference(List<int> list)
        {
            int min = list[0];
            int max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
                if (list[i] > max)
                    max = list[i];
            }
            return max - min;
        }

        public static int Count(List<int> list)
        {
            return list.Count;
        }
    }
}
