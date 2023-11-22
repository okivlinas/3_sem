using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.CodeAnalysis;
using Lab_07;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace LAB07
{
    public class Set <T> : IEnumerable<T>, IItems<T>  //перечислитель
    {
        private List<T> _items = new(); 
        public int Count => _items.Count; //размерность

        public void Add(T item)
        {
            if (item == null)
            {
                throw new NULLException("вы ничего не передали!", item);
            }

            // множество содержит только уникальные элементы
            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
        }

        public void Delete(int index)
        {
            if (index == null)
            {
                throw new NULLException("вы ничего не передали!", index);
            }


            if(index < 0 || index > _items.Count)
            {
                throw new ArrayRange("вы вышли за диапазон значений!", index);
            }

            T element = _items[index];
            // множество содержит только уникальные элементы
            if (_items.Contains(element))
            {
                _items.Remove(element);
            }
        }

        public void Print(string message)
        {
            Console.Write(message + "\t\t");

            for (int i = 0; i < _items.Count; i++)
            {
                Console.Write("{0} ", _items[i]);
            }
            Console.WriteLine();
        }

        public void Print()
        {

            for (int i = 0; i < _items.Count; i++)
            {
                Console.Write("{0} ", _items[i]);
            }
            Console.WriteLine();

        }

        public void ToFile(string path)
        {
            using (StreamWriter writer = new (path, false))
            {
                for (int i = 0; i < _items.Count; i++)
                {
                    writer.Write($"{_items[i]}  ");
                }
                Console.WriteLine("Файл записан!");
            }
        }

        public void FromFile(string path)
        {
                using (StreamReader reader = new StreamReader(path))
                {
                    string? line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
        }

        public static Set<T> operator *(Set<T> set1, Set<T> set2) => Intersection(set1, set2);
        /// Пересечение множеств ПЕРЕГРУЗКА!.
        public static Set<T> Intersection(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            // Результирующее множество.
            var resultSet = new Set<T>();

            // Выбираем множество с наименьшим количеством элементов
            if (set1.Count < set2.Count)
            {
                // Проверяем все элементы выбранного множества.
                foreach (var item in set1._items)
                {
                    // Если элемент из первого множества содержится во втором множестве,
                    // то добавляем его в результирующее множество.
                    if (set2._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in set2._items)
                {
                    if (set1._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }

            return resultSet;
        }

        public static bool operator <(Set<T> set1, Set<T> set2) => Subset(set1, set2);
        /// Подмножество ПЕРЕГРУЗКА.
        public static bool Subset(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            /* Перебираем элементы первого множества.
             Если все элементы первого множества -> во втором -
            это подмножество. Возвращаем истину, иначе ложь. */
            var result = set1._items.All(s => set2._items.Contains(s));
            return result;
        }

        //проверка на принадлежность ПЕРЕГРУЗКА
        public static bool operator >(Set<T> set1, Set<T> set2) => Belonging(set1, set2);
        
        public static bool Belonging(Set<T> set1, Set<T> set2)
        {
            T number = default(T);
            Console.WriteLine("{0}",number);
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }



            if (set1._items.IndexOf(number) != -1)
                return true;

            return false;
        }

        /// Вернуть перечислитель, выполняющий перебор всех элементов множества.
        public IEnumerator<T> GetEnumerator()
        {
            // Используем перечислитель списка элементов данных множества.
            return _items.GetEnumerator();
        }

        /// Вернуть перечислитель, который осуществляет итерационный переход по множеству.
         IEnumerator IEnumerable.GetEnumerator()
        {
            // Используем перечислитель списка элементов данных множества.
            return _items.GetEnumerator();
        }

        static class StatisticOperation
        {
            static public int sum(Set<int> set) =>
                set._items.Sum();
            

            static public int difference_beetwen_max_and_min(Set<int> set)
            {
                var max = set._items.Max();
                var min = set._items.Min();                

                int result = max - min;

                return result;
            }

            static public int count_elemets(Set<int> set)
            { 
                return set._items.Count;
            }
        }
    }

    public class INFORMATION
    {
        static public class Production
        {
            static public int ID;
            static public int ID_2
            {
                set
                {
                    if (value >= 0)
                    {
                        ID = value;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                }

                get => ID;
            }
            static public string? Name;
        }

        public class Developer
        {
             public string? name_developer { get; set; }
             public int id { get; set; }
             public string? department { get; set; }

           public Developer()
            {
                name_developer = "Aleksey Kravchenko";
                id = 0;
                department = "5 POIT";
            }
        }

        //ПРИВЕДЕНИЕ ТИПОВ
        public class emlpoyee : Developer
        {
            public string Company;
            public emlpoyee(string name, string company)
            {
                Company = company;
            }
        }

        public class Person : Developer
        {
            public string Bank;
            public Person(string name, string bank)
            {
                Bank = bank;
            }

            public static implicit operator Person(emlpoyee v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
    
