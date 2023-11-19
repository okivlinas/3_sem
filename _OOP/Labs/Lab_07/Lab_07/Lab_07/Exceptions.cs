using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    class ArrayRange : ArgumentException
    {
        public int Value;
        public ArrayRange(string message, int val): base(message)
        {
            Value = val; //свойство для хранения устанавливаемого значения
        }
    }

    class NULLException : Exception
    {
        public int value;
        private object item;

        public NULLException(string message, int val) : base (message)
        {
            value = val;
        }

        public NULLException(string? message, object item) : base(message)
        {
            this.item = item;
        }
    }

    class FileException:Exception
    {
        public int value;

        public FileException(string message, int _value) : base (message)
        {
            value= _value;
        }
    }
}