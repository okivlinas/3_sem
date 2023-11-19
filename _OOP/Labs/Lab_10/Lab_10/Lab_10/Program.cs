using System;
using Lab_10;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Lab_10
{
     public class PHONE
    {

        public string surname;
        public int TimeOfcityCalls;
        public int TimeOfInternationalCalls;
        public int debet;

        public PHONE (string _surname, int _timeOfcityCalls, int _timeOfInternationalCalls, int _debet)
        {
            this.surname = _surname;
            TimeOfcityCalls = _timeOfcityCalls;
            TimeOfInternationalCalls = _timeOfInternationalCalls;
            this.debet = _debet;
        }

        public override string ToString()
        {
            Console.WriteLine($"Фамилия абонента: {surname}\n" +
                $"Время внутрегородских разговоров: {TimeOfcityCalls}\n" +
                $"Время международной связи: {TimeOfInternationalCalls}\n" +
                $"Дебет: {debet}\n");
            return "";
        }

    }

  
   /* partial class MAIN_CLASS
    {
        static void Main(string[] args)
        {
            int size = 3;
            PHONE[] elements = new PHONE[size];
            PHONE Ph1 = new PHONE();
            PHONE Ph2 = new PHONE("10", "Aleksey", "Kravchenko");
            PHONE Ph3 = new PHONE(540);
            elements[0] = Ph1;
            elements[1] = Ph2;
            elements[2] = Ph3;

            int choice;
            while (true)
            {
                
                menu();
                Console.WriteLine("Выберите пункт:");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {

                    case 1:
                        {
                            Console.Clear();
                            output(elements, size);
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Количество объектов: {0}", PHONE.count);
                            Console.WriteLine("\n");
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите значение: ");
                            string num = Console.ReadLine();
                            int co = 0;
                            while (co < size)
                            {
                                PHONE.MORE_THAN_SPECIFIED(num, elements[co], size);
                                co++;
                            }
                            PHONE.time_count_foo = 0;
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            int co = 0;
                            while (co < size)
                            {
                                PHONE.IS_USE(elements[co], size);
                                co++;
                            }
                            PHONE.time_count_foo = 0;
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Пока!");
                            Environment.Exit(1);
                            break;
                        }

                }
            }
        }
    }

    partial class MAIN_CLASS
    {
        public static void menu()
        {
            Console.WriteLine("Выберите операцию, которую необходимо выполнить:");
            Console.WriteLine("1) Вывод инфорамции.");
            Console.WriteLine("2) Получить информацию по количеству созданных объектов.");
            Console.WriteLine("3) Получить информацию про абонентов, у которых время внутригородских разговоров превышает заданное.");
            Console.WriteLine("4) Сведения об абонентах, которые пользовались междугородной связью.");
            Console.WriteLine("5)Выход");
        }

        public static void output(PHONE[] elements, int size) 
        {
            Console.WriteLine("Вывод инфнормации:");
            
            for(int i = 0; i < size; i++)
            {
                
                    Console.WriteLine("Имя: {0}", elements[i].name_1);
                    Console.WriteLine("Фамилия: {0}", elements[i].surname_1);
                    Console.WriteLine("Отчество: {0}", elements[i].patronymic_1);
                    Console.WriteLine("Адрес: {0}", elements[i].Adress_1);
                    Console.WriteLine("Номер карты: {0}", elements[i].Num_of_card_2);
               
                if (elements[i].Debet_1 == -1)
                {
                    Console.WriteLine("Дебет: некорректные данные");
                }
                else
                {
                    Console.WriteLine("Дебет: {0}", elements[i].Debet_1);
                }

                if (elements[i].credit_1 == null)
                {
                    Console.WriteLine("Кредит: некорректные данные!");
                }
                else 
                {
                    Console.WriteLine("Кредит: {0}", elements[i].credit_1);
                }

                if (elements[i].time_1 == null)
                {
                    Console.WriteLine("Время городских разговоров: некорректные данные");
                }
                else
                {
                    Console.WriteLine("Время городских разговоров: {0}", elements[i].time_1);
                }

                if (elements[i].time_2  == null)
                {
                    Console.WriteLine("Время междугородных разговоров: некорректные данные");
                }
                else
                {
                    Console.WriteLine("Время междугородных разговоров: {0}", elements[i].time_2);
                }
               
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }*/
}
