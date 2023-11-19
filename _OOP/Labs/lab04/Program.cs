using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Program
    {
            static void Main(string[] args)
            {
                PrintMedia magazine = new Magazine();
                magazine.Title = "Magazine 1";
                magazine.Year = 2020;
                magazine.PrintInfo();

                PrintMedia book = new Book();
                book.Title = "Book 1";
                book.Year = 2019;
                book.PrintInfo();

                PrintMedia textbook = new Textbook();
                textbook.Title = "Textbook 1";
                textbook.Year = 2021;
                textbook.PrintInfo();

                Person author = new Author();
                author.Name = "John Smith";
                author.Age = 35;

                Publisher publisher = new Publisher();
                publisher.Name = "Publisher 1";
                publisher.Location = "New York";

                Console.WriteLine("Author: " + author.Name);
                Console.WriteLine("Publisher: " + publisher.Name);

                UserClass userClass = new UserClass();
                userClass.DoClone();

                Console.ReadLine();
            }
    }
}
