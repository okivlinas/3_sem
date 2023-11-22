using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class Program
    {
        public static void Main(string[] argv)
        {
            /* 
             Debug.Write("Data"); //send message to debugger
             Debug.WriteLine(23 * 34);
             int x = 5, y = 3;
             Debug.WriteIf(x > y, "x is greater than y");
            
             Debugger.Launch(); //choose of debugger
             Debugger.Break(); //==breakpoint 
            */

            //1
            try
            {
                Film film = new("Улица разбитых фонарей", 16, 14); // 1 - ограничение, 2 - возраст
            }
            catch(AgeExceptionArg ex)
            {
                Console.WriteLine("Ошибка: {0}",ex.Message);
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
            finally
            {
                Console.WriteLine("-----------------------\n");
            }

            //2
            try
            {
                Cartoon cartoon = new("Пивозаврики", 2030, 2000);
            }
            catch (SleepExceptionArg ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
                Console.WriteLine($"Мультфильм начинается в : {ex.Value}");
                Console.WriteLine($"Вы ляжете спать в : {ex.Value_2}");
            }
            finally
            {
                Console.WriteLine("-----------------------\n");
            }

            //3
            try
            {
                ArtFilm artfilm = new("Глухарь", "Гайков Дмитрий", 1052);
            }
            catch (YearException ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
                Console.WriteLine($"Некорректное значение : {ex.value}");
            }
            finally
            {
                Console.WriteLine("-----------------------\n");
            }

            //4
            ArtFilm artfilm_2 = new("В мире БГТУ", "Новиков Роман", 2022);
            try
            {
                artfilm_2.ProgramGuide("Вторник");
            }
            catch (WeekException ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
                Console.WriteLine($"Некорректное значение : {ex.value}");
            }
            finally
            {
                Console.WriteLine("-----------------------\n");
            }

            //5
            Console.WriteLine("Введите название фильма:");
            try
            {
                string nameFilm = Console.ReadLine();
                Film film_2 = new("Вовращение Глухаря-2", 16, 20);
                Console.WriteLine("\nОбъект с данным фильмом успешно создан!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("-----------------------\n");
            }

            //6
            ArtFilm artfilm_3 = new("Улица разбитых фонарей - 2", "Кравченко Алексей", 2004);
            try
            {
                artfilm_3.ProgramGuide(-3);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("\n------------END-----------\n");
            }
        }
    }
}
