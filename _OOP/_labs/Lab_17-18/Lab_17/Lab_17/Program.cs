using System.Text;

namespace Lab_17
{
    class Program
    {
        public static void Main()
        {
            Driver.createDriver(100, true, 2003, 20, "Вадим", 0);
            Driver.createDriver(200, false, 2010, 10, "Дима", 1);
            Driver.createDriver(300, true, 2021, 30, "Пётр", 2);
            Driver.createDriver(400, true, 2022, 5, "Сергей", 3);
            Driver.createDriver(10, false, 2022, 3, "Кирилл", 4);
            Driver.createDriver(10, true, 2023, 7, "Максим", 5);
            Driver.createDriver(500, true, 1998, 10, "Роман", 6);
            Driver.createDriver(178, false, 1971, 15, "Алексей", 7);
            Driver.createDriver(1000, true, 2018, 12, "Игорь", 8);
            Driver.createDriver(200, true, 2021, 16, "Вадим", 9);

            Client cl1 = new("Артём");
            var flight1 = cl1.CreateNewFlight("Бетонные плиты", 800, 12);

            Dispatcher.PerfomanceCheck(flight1);
        }
    }
}
