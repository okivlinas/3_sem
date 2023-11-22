using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an int value: ");
            int intValue = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("int: " + intValue);

            Console.Write("Enter a uint value: ");
            uint uintValue = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("uint: " + uintValue);

            Console.Write("Enter a short value: ");
            short shortValue = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("short: " + shortValue);

            Console.Write("Enter an ushort value: ");
            ushort ushortValue = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("ushort: " + ushortValue);

            Console.Write("Enter a long value: ");
            long longValue = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("long: " + longValue);

            Console.Write("Enter an ulong value: ");
            ulong ulongValue = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("ulong: " + ulongValue);

            Console.Write("Enter a byte value: ");
            byte byteValue = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte: " + byteValue);

            Console.Write("Enter an sbyte value: ");
            sbyte sbyteValue = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte: " + sbyteValue);

            Console.Write("Enter an nint value: ");
            nint nintValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nint: " + nintValue);

            Console.Write("Enter an nuint value: ");
            nuint nuintValue = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("nuint: " + nuintValue);

            Console.Write("Enter a float value: ");
            float floatValue = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("float: " + floatValue);

            Console.Write("Enter a double value: ");
            double doubleValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("double: " + doubleValue);

            Console.Write("Enter a decimal value: ");
            decimal decimalValue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("decimal: " + decimalValue);

            Console.Write("Enter a char value: ");
            char charValue = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("char: " + charValue);

            Console.Write("Enter a bool value (true or false): ");
            bool boolValue = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("bool: " + boolValue);

            //

            int wumber = 42; 

            object boxedNumber = wumber;
            int unboxedNumber = (int)boxedNumber;

            //

            int YavNum1 = 1000;
            short YavSmallNum1 = (short)YavNum1;
            double YavNum2 = 3.14;
            int YavSmallNum2 = (int)YavNum2;
            long YavNum3 = 10000;
            byte YavSmall3 = (byte)YavNum3;
            char YavNum4 = 'A';
            int YavSmall4 = (int)YavNum4;
            float YavNum5 = 23.45f;
            double YavSmall5 = (double)YavNum5;

            int NeNum1 = 42;
            long NeSmall1 = NeNum1;
            float NeNum2 = 3.14f;
            double NeSmall2 = NeNum2;
            byte NeNum3 = 10;
            int NeSmall3 = NeNum3;
            short NeNum4 = 1000;
            int NeSmall4 = NeNum4;
            char NeNum5 = 'A';
            int NeSmall5 = NeNum5;

            //

            var implicitVar2 = "Hello World!";
            var implicitVar1 = 3.14;

            //

            int? variableIntNullabel = null;

            //

            //var implicitVar3 = "Hello World!";
            //var implicitVar3 = 3.14;

            //

            string str1 = "1_Hello_1";
            string str2 = "2_Hello_2";
            string str3 = "3_Hello_3";

            //
            if (str1 == str2)
            {
                Console.WriteLine("Равны");
            }
            else
            {
                Console.WriteLine("Не равны");
            }

            //

            string conc = str1 + str2 + str3;
            Console.WriteLine(conc);

            string copy = String.Copy(str1);
            Console.WriteLine(copy);

            string substr = str1.Substring(2, 5);
            Console.WriteLine(substr);

            string words_bad = "one two three four five";
            string[] words = words_bad.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string insrt = str1.Insert(2, "Inserted");
            Console.WriteLine(insrt);

            string rem = str2.Remove(2, 6);
            Console.WriteLine(rem);

            string interpolated = $"{str1} - {str2} - {str3}";
            Console.WriteLine(interpolated);

            //

            string emptyString = "";
            string nullString = null;

            if (string.IsNullOrEmpty(emptyString))
            {
                Console.WriteLine("Пустая строка");
            }

            if (string.IsNullOrEmpty(nullString))
            {
                Console.WriteLine("Null-строка");
            }

            string concatenated = emptyString + "Concatenated";
            Console.WriteLine("Сцепленная строка: " + concatenated);

            int length = emptyString.Length;
            Console.WriteLine("Длина пустой строки: " + length);

            string trimmed = nullString?.Trim();
            Console.WriteLine("Обрезанная null-строка: " + trimmed);

            //

            StringBuilder strBld = new StringBuilder("Oleg, Hello");
            Console.WriteLine(strBld.ToString());
            strBld.Remove(5, 4);
            Console.WriteLine(strBld.ToString());
            strBld.Insert(0, "Oh, ");
            strBld.Append(")))");
            Console.WriteLine(strBld.ToString());

            //

            int[,] matrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //

            string[] strArr = new string[]
            {
                "One", "Two", "Three", "Four", "Five"
            };


            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(i + ": " + strArr[i]);
            }
            Console.WriteLine("Array length: " + strArr.Length);

            Console.WriteLine("Введите позицию элемента для измениения от 0 до 4");
            int position = Convert.ToInt32(Console.ReadLine());
            if (position >= 0 && position < strArr.Length)
            {
                Console.Write("Введите новое значение: ");
                string NewValue = Console.ReadLine();
                strArr[position] = NewValue;

                Console.WriteLine("Новый:");
                for (int i = 0; i < strArr.Length; i++)
                {
                    Console.WriteLine(i + ": " + strArr[i]);
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }

            //

            double[][] jagArr = new double[3][];
            jagArr[0] = new double[2];
            jagArr[1] = new double[3];
            jagArr[2] = new double[4];

            for (int i = 0; i < jagArr.Length; i++)
            {
                for (int j = 0; j < jagArr[i].Length; j++)
                {
                    Console.Write($"Введите значение для элемента [{i}][{j}]: ");
                    jagArr[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("Введенный массив:");
            for (int i = 0; i < jagArr.Length; i++)
            {
                for (int j = 0; j < jagArr[i].Length; j++)
                {
                    Console.Write(jagArr[i][j] + " ");
                }
                Console.WriteLine();
            }

            //

            var implArr = new[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < implArr.Length; i++)
            {
                Console.Write("Array: " + implArr[i] + "  ");
            }
            var implStr = "Some string";
            Console.WriteLine("Implicit variable for string: " + implStr);

            //

            var tuple = (42, "Hello", 'A', "World", 123456UL);

            //

            Console.WriteLine(tuple);

            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);

            //

            var (num1, sstr1, char1, sstr2, ulong1) = tuple;
            Console.WriteLine(num1);      // Выводит: 42
            Console.WriteLine(sstr1);      // Выводит: Hello
            Console.WriteLine(char1);     // Выводит: A
            Console.WriteLine(sstr2);      // Выводит: World
            Console.WriteLine(ulong1);    // Выводит: 123456

            // Способ 2: Распаковка с использованием неявной типизации var
            (var num2, var sstr3, var char2, var sstr4, var ulong2) = tuple;
            Console.WriteLine(num2);      // Выводит: 42
            Console.WriteLine(sstr3);      // Выводит: Hello
            Console.WriteLine(char2);     // Выводит: A
            Console.WriteLine(sstr4);      // Выводит: World
            Console.WriteLine(ulong2);    // Выводит: 123456

            // Способ 3: Распаковка с использованием переменной _
            var (_, _, _, sstr5, _) = tuple;
            Console.WriteLine(sstr5);      // Выводит: World

            //

            var tuple1 = (42, "Hello");
            var tuple2 = (42, "World");

            bool areEqual = tuple1 == tuple2;
            bool areNotEqual = tuple1 != tuple2;

            Console.WriteLine($"Are equal: {areEqual}");          // Выводит: Are equal: False
            Console.WriteLine($"Are not equal: {areNotEqual}");    // Выводит: Are not equal: True

            //

            int[] nuumbers = { 10, 5, 8, 3, 6 };
            string teext = "Hello";

            var result = GetTuple(nuumbers, teext);

            Console.WriteLine($"Max: {result.max}");
            Console.WriteLine($"Min: {result.min}");
            Console.WriteLine($"Sum: {result.sum}");
            Console.WriteLine($"First letter: {result.firstLetter}");

        }
        static (int max, int min, int sum, char firstLetter) GetTuple(int[] nuumbers, string teext)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;

            foreach (int nuumber in nuumbers)
            {
                if (nuumber > max)
                    max = nuumber;

                if (nuumber < min)
                    min = nuumber;

                sum += nuumber;
            }

            char firstLetter = teext[0];

            return (max, min, sum, firstLetter);
        }

        //

        static void CheckedFunction()
        {
            checked
            {
                try
                {
                    int mxVal = int.MaxValue;
                    Console.WriteLine("Function with checked:");
                    Console.WriteLine($"int.MaxValue: {mxVal}");
                    Console.WriteLine($"Try to plus 1: {mxVal + 1}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }
        static void UncheckedFunction()
        {
            unchecked
            {
                int mxVal = int.MaxValue;
                Console.WriteLine("\nFunction with unchecked:");
                Console.WriteLine($"int.MaxValue: {mxVal}");
                Console.WriteLine($"Try to plus 1: {mxVal + 1}");
            }
        }
    }
}