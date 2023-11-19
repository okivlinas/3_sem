using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;
using Lab_09;
using System.Collections.Specialized;
using System.Drawing;

namespace Lab_09
{
    class Program
    {
        public static void Main(string[] argv)
        {
            Console.WriteLine("------------------- Задание 1 ------------------------");
            try
            {   
                Furniture cupBoard = new("Шкаф", "Островецкая фабрика", 2018, 555);
                Furniture sofa = new("Диван", "Минская фабрика", 2022, 665);
                Furniture table = new("Стол", "Гомельская колония номер 2", 2020, 444);
                Furniture mirror = new("Зекрало", "Минский областной филиал по производству зекрал", 2022, 120);
                FurnitureCollections<Furniture> collection = new();
                collection.Add(cupBoard);
                collection.Add(sofa);
                collection.Add(table);

                collection.Print();

                collection.search(cupBoard);
                collection.search(mirror);
                collection.delete(sofa);
                Console.WriteLine("\n**************** После удаления ******************");
                collection.Print();
                Console.ReadLine();

                Console.WriteLine("------------------- Задание 2 ------------------------");
                ArrayList array = new();
                array.Add(500);
                array.Add(1000);
                array.Add(1500);
                array.Add(2000);
                array.Add(2500);
                array.Add(3000);

                Console.WriteLine("Коллекция:");
                for(int i = 0; i < array.Count; i++)
                {
                    Console.WriteLine(array[i]);
                }

                int countDel = 2, startPos = 3;
                Console.WriteLine($"\nКоллекция после удаления элементов c {startPos} по {startPos + countDel}:");

                while (countDel != 0) 
                {
                    array.RemoveAt(startPos - 1);
                    countDel--; 
                }

                for (int i = 0; i < array.Count; i++)
                {
                    Console.WriteLine(array[i]);
                }

                array.Insert(0, 0);
                array.Add(0);
                Console.WriteLine("\nКоллекция после добавления элементов:");
                for (int i = 0; i < array.Count; i++)
                {
                    Console.WriteLine(array[i]);
                }

                /******************/
                Queue q = new Queue(array);

                Console.WriteLine("\nОчередь: ");
                while (q.Count != 0)
                {
                    string next = q.Dequeue().ToString();
                    Console.WriteLine(next);
                }

                Console.ReadLine();

                Console.WriteLine("------------------- Задание 3 ------------------------");
                ObservableCollection<Furniture> furn = new();
                furn.CollectionChanged += CollectionChange;
                furn.Add(table);
                furn.Add(mirror);
                furn.Remove(table);
                
                void CollectionChange(object sender, NotifyCollectionChangedEventArgs e)
                {
                    Console.WriteLine("Изменения произошли в " + e.NewStartingIndex);
                    Console.WriteLine("Новые элементы: " + e.NewItems);
                    Console.WriteLine("Remove (индекс): " + e.OldItems);
                }

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();           
        }
    }


}