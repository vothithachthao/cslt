using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _cslt.session_01
{
    internal class exercise_1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Two Numbers");
                Console.WriteLine("2. Swap Two Variables");
                Console.WriteLine("3. Multiply Floating Point Numbers");
                Console.WriteLine("4. Convert Feet to Meters");
                Console.WriteLine("5. Celsius <-> Fahrenheit");
                Console.WriteLine("6. Size of Data Types");
                Console.WriteLine("7. Print ASCII Value");
                Console.WriteLine("8. Area of Circle");
                Console.WriteLine("9. Area of Square");
                Console.WriteLine("10. Days to Years, Weeks, and Days");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": SumNumbers(); break;
                    case "2": SwapVariables(); break;
                    case "3": MultiplyFloats(); break;
                    case "4": FeetToMeters(); break;
                    case "5": TemperatureConverter(); break;
                    case "6": DataTypeSizes(); break;
                    case "7": AsciiValue(); break;
                    case "8": AreaCircle(); break;
                    case "9": AreaSquare(); break;
                    case "10": ConvertDays(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        //1. Add Two Numbers
        static void SumNumbers()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {a} + {b} = {a + b}");
        }

        // 2. Swap Values
        static void SwapVariables()
        {
            Console.Write("Enter a: ");
            string a = Console.ReadLine();
            Console.Write("Enter b: ");
            string b = Console.ReadLine();
            string temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }

        // 3. Multiply Floating Point Numbers
        static void MultiplyFloats()
        {
            Console.Write("Enter first float: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter second float: ");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"Product: {x * y}");
        }

        // 4. Feet to Meters
        static void FeetToMeters()
        {
            Console.Write("Enter feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meters = feet * 0.3048;
            Console.WriteLine($"{feet} feet is {meters} meters");
        }

        // 5. Celsius/Fahrenheit Converter
        static void TemperatureConverter()
        {
            Console.WriteLine("1. Celsius to Fahrenheit\n2. Fahrenheit to Celsius");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter Celsius: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine($"Fahrenheit: {(c * 9 / 5) + 32}");
            }
            else
            {
                Console.Write("Enter Fahrenheit: ");
                double f = double.Parse(Console.ReadLine());
                Console.WriteLine($"Celsius: {(f - 32) * 5 / 9}");
            }
        }

        // 6. Size of Data Types
        static void DataTypeSizes()
        {
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of bool: {sizeof(bool)} byte");
        }

        // 7. Print ASCII Value
        static void AsciiValue()
        {
            Console.Write("Enter a character: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nASCII value of '{c}' is: {(int)c}");
        }

        // 8. Area of Circle
        static void AreaCircle()
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Area: {area:F2}");
        }

        // 9. Area of Square
        static void AreaSquare()
        {
            Console.Write("Enter side length: ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area: {s * s}");
        }

        // 10. Days Conversion
        static void ConvertDays()
        {
            Console.Write("Enter total days: ");
            int total = int.Parse(Console.ReadLine());
            int years = total / 365;
            int weeks = (total % 365) / 7;
            int days = (total % 365) % 7;
            Console.WriteLine($"{years} Years, {weeks} Weeks, {days} Days");
        }
    }
}