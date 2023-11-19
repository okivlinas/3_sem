using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Lab_09
{
    class FurnitureCollections<T> : MyIList<T>
    {
        ArrayList CollectionFurniture = new ArrayList();

        public void Add(T element)
        {
            CollectionFurniture.Add(element);
        }

        public void delete(T element) //можно было использовать indexOf
        {


                    CollectionFurniture.Remove(element);

        }

        public void search(T elem)
        {
            bool prov = CollectionFurniture.Contains(elem);
            
            if (prov)
            {
                Console.WriteLine($"Объект присутствует! Первое вхождение: {CollectionFurniture.IndexOf(elem) + 1}");
            }
            else
            {
                Console.WriteLine("Такой элемент отсутствует!");
            }
        }

        public void Print()
        {
            Console.WriteLine("\nОбъекты коллекции:\n");
            foreach (T item in CollectionFurniture)
            {
                item.ToString();
                Console.WriteLine('\n');
            }
        }
    }
}
