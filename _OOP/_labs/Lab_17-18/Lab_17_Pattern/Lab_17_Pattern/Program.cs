using Lab_17_Pattern;
using System.Text;

namespace Lab_17
{
    class Program
    {
        public static void Main()
        {
            #region ex1
            Driver Truckdriver = new(TypeOfCar.FreightCar);
            Driver Cardriver = new(TypeOfCar.car);

            Truckdriver.createDriver(100, true, 2003, 20, "Вадим", 0);
            Truckdriver.createDriver(200, false, 2010, 10, "Дима", 1);
            Truckdriver.createDriver(300, true, 2021, 30, "Пётр", 2);
            Truckdriver.createDriver(400, true, 2022, 5, "Сергей", 3);
            Truckdriver.createDriver(10, false, 2022, 3, "Кирилл", 4);
            Cardriver.createDriver(10, true, 2023, 7, "Максим", 5);
            Cardriver.createDriver(500, true, 1998, 10, "Роман", 6);
            Cardriver.createDriver(178, false, 1971, 15, "Алексей", 7);
            Cardriver.createDriver(1000, true, 2018, 12, "Игорь", 8);
            Cardriver.createDriver(200, true, 2021, 16, "Вадим", 9);


            Client cl1 = new("Артём");
            var flight1 = cl1.CreateNewFlight("Бетонные плиты", 800, 12);

            Dispatcher.PerfomanceCheck(flight1);
            #endregion

            #region ex2
            Console.WriteLine("\n\nЗадание 2");
            App app = new();
            app.setSize("12");
            app.setColor("red");
            Console.WriteLine("Цвет шрифта: " + app.col._color);
            Console.WriteLine("Размер шрифта: " + app.size.size);

            //попытка изменить
            app.col = color.getInstance("white");
            app.size = SizeOfText.getInstance("26");
            Console.WriteLine("Цвет шрифта: " + app.col._color);
            Console.WriteLine("Размер шрифта: " + app.size.size);
            #endregion

            #region ex3
            Client cl2 = new("Александр");
            Client clonedClient = (Client)cl2.clone(); //<<----- clone
            Console.WriteLine("\n\n" + cl2.nameOfClient);
            Console.WriteLine("Клон: " + cl2.nameOfClient);
            #endregion
        }
    }
}
