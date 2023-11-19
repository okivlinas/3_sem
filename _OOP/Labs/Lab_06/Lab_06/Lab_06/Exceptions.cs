using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class AgeExceptionArg : ArgumentException //передача некорректных аргументов в функцию
    {
        public int Value;
        public AgeExceptionArg(string message, int val): base(message)
        {
            Value = val; //свойство для хранения устанавливаемого значения
        }
    }

    class SleepExceptionArg : ArgumentException
    {
        public int Value { get; }
        public int Value_2 {get; }
        public SleepExceptionArg(string message, int val, int val2) : base(message)
        {
            Value = val; //свойство для хранения устанавливаемого значения
            Value_2 = val2;
        }
    }

    class YearException : Exception
    {
        public int value;
        public YearException(string message, int val) : base (message)
        {
            value = val;
        }
    }

    class WeekException : Exception
    {
        public string value;
        public WeekException(string message, string val) : base(message)
        {
            value = val;
        }
    }

}