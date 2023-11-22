using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Lab_08;

namespace Lab_08
{
    class Program
    {
        public delegate void deleg1(int count);
        public delegate void deleg2();
        public delegate void deleg3();

        public static event deleg1 Upgrade;
        public static event deleg2 TurnOn;
        public static event deleg3 Throw_out;
        public static event Action<string> strEvent;
        public static void Main(string[] argv)
        {
            Boss microwave = new("Микроволновка", "150", 15);
            Boss PC = new("Компьютер", "215", 5);
            Boss hoover = new("Пылесос", "100", 10);
            Boss TV = new("Телевизор", "290", 22);

            microwave.ToString();
            PC.ToString();
            hoover.ToString();

            Upgrade += microwave.upgrade;
            Upgrade += PC.upgrade;

            TurnOn += hoover.turnOn;

            Throw_out += TV.ThrowOut;

            Upgrade(25);
            TurnOn();
            Throw_out();

            Console.WriteLine("\n------------СТРОКИ------------");
            string stroke = "Hello, my dear friend";
            Console.WriteLine("Начальная строка: " + stroke);
            StringCorrector string_correct = new();
            strEvent += string_correct.DelSpace;
            strEvent += string_correct.DelPunct;
            strEvent += string_correct.UpperCase;

            strEvent(stroke);
            string_correct.CorrectStr2(stroke, 'X');
        }
    }
}
