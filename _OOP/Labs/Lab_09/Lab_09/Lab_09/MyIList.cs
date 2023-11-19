using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09
{
    interface MyIList<T>
    {
        public void Add(T element);
        public void delete(T element);
        public void search(T elem);
        public void Print();
    }
}
