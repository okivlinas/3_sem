using LAB07;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //проверка обобщенного интерфейса на базе класса с массивом
            int[] AI = { 2, 8, 3, 4, 11, 17, 5 };
            ArrayItems <int> A1 = new ArrayItems<int>(AI);

            A1.Print("A1:");

            // Добавить элемент
            int newNum = 130;
            A1.Add(newNum);
            A1.Print($"A1 + [{newNum}]:");

            // Удалить другой элемент
            int delNum = 1;
            A1.Delete(delNum);
            A1.Print($"A1 - A1[{delNum+1}]:");

            Console.ReadKey();

            //проверка обобщеного интерфейса на базе класса множества 
            var set1 = new Set<int>()
            {
                -1, 2, 3, 4, 5, -6
            };


            var set2 = new Set<int>()
            {
                4, 5, 6, 7, 8, 9
            };

            set1.Print("\nМножество SET1:");
            int newNumSet = 15;
            set1.Add(newNumSet);
            set1.Print($"Множество SET1 (после добавления {newNumSet}):");

            int delNumSet = 2;
            set1.Delete(delNumSet-1);
            set1.Print($"Множество SET1(после удаления {delNumSet} элемента): ");

            Console.ReadKey();

            //****обработчик исключений****
            try
            {
                set2.Delete(-2);
            }
            catch(ArrayRange ex)
            {
                Console.WriteLine("\nОшибка: "+ ex.Message);
                Console.WriteLine("Некорректные данные: " + ex.Value);
            }
            finally
            {
                Console.WriteLine("------------------------------");
            }

            try
            {
                set2.Delete(500);
            }
            catch (ArrayRange ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Некорректные данные: " + ex.Value);
            }
            finally
            {
                Console.WriteLine("------------------------------");
            }

            Console.ReadKey();

            //обобщение для стандартных типов данных
            //тип int
            GenericStandardTypes<int> objInt = new (23, 15);
            objInt.Print("\nInt: ");

            //тип double
            GenericStandardTypes<double> objDouble = new GenericStandardTypes<double>(7.88, -3.22);
            objDouble.Print("Double: ");

            //***** или *****
            Dictionary<string, int> mark =new Dictionary<string, int>();
            mark.Add("Кравченко", 10);
            mark.Add("Гайков", 9);
            mark.Add("Адамович", 8);
            mark.Add("Климов", 3);

            try
            {
                mark.Add("Кравченко", 8);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nСтудент с фамилией \"Кравченко\" уже определён.\n");
            }

            Console.ReadKey();

            //пользовательский класс CARTOON, который используется в качестве параметра обобщения
            CARTOONS cartoon1 = new("Смешарики", "50 минут", "7+");
            CARTOONS cartoon2 = new("Пивозаврики", "30 минут", "12+");
            Set<CARTOONS> set3 = new()
            {
                 cartoon1, cartoon2
            };

            set3.Print();

            Console.ReadKey();

            //запись и чтение в (из) файла
            set2.ToFile("file.txt");
            Console.ReadKey();

            Console.WriteLine("\nЧтение из файла: ");
            set2.FromFile("file.txt");
            Console.ReadKey();

        }
    }
}

