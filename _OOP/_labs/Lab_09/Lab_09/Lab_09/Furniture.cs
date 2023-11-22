using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09
{
    class Furniture
    {
        private string _nameFurniture;
        public string Namecompany { get; set; }
        private int _YearOfIssue;
        private int _cost;

        public string NameFurniture
        {
            set { _nameFurniture = value; }
           
            get { return _nameFurniture; }
        }

        public int YearOfIssue
        {
            get 
            {
                return _YearOfIssue;
            }
            set 
            {
                if (value < 1000 || value > 2023)
                {
                    throw new Exception("Вы ввели неверный год производства!");
                }
                else
                {
                    _YearOfIssue = value;
                }

            }
        }

        public int Cost
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Пожалуйста, введите верную стоимость!!!");
                }
                else
                {
                    _cost = value;
                }
            }
            get { return _cost; }
        }

        public override string ToString()
        {
            Console.WriteLine($"Название мебели: {NameFurniture}\n" +
                $"Компания - производитель: {Namecompany}\n" +
                $"Стоимость мебели: {Cost}\n" +
                $"Год выпуска: {YearOfIssue}"
                );
            return "";
        }

        public Furniture(string name_Furniture, string namecompany, int year_Of_Issue, int mark)
        {
            NameFurniture = name_Furniture;
            Namecompany = namecompany;
            YearOfIssue = year_Of_Issue;
            Cost = mark;
        }
    }
}
