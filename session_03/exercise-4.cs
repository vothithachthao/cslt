using System;
using System.Linq;

namespace _cslt.session_03
{
    internal class exercise_4
    {
        static void Main4(string[] args)
        {
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Calculator (+, -, *, /)");
                Console.WriteLine("2. Function x = y^2 + 2y + 1");
                Console.WriteLine("3. Speed Calculator");
                Console.WriteLine("4. Sphere Surface and Volume");
                Console.WriteLine("5. Character Checker");
                Console.WriteLine("6. Even or Odd");
                Console.WriteLine("7. Largest of Three Numbers");
                Console.WriteLine("8. Coordinate Quadrant");
                Console.WriteLine("9. Triangle Type");
                Console.WriteLine("10. Sum and Average of 10 Numbers");
                Console.WriteLine("11. Multiplication Table");
                Console.WriteLine("12. Number Triangle Pattern");
                Console.WriteLine("13. Harmonic Series");
                Console.WriteLine("14. Perfect Numbers in Range");
                Console.WriteLine("15. Prime Number Check");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Calculator();
                        break;

                    case 2:
                        FunctionValues();
                        break;

                    case 3:
                        SpeedCalculator();
                        break;

                    case 4:
                        SphereCalculation();
                        break;

                    case 5:
                        CharacterChecker();
                        break;

                    case 6:
                        EvenOrOdd();
                        break;

                    case 7:
                        LargestOfThree();
                        break;

                    case 8:
                        CoordinateQuadrant();
                        break;

                    case 9:
                        TriangleType();
                        break;

                    case 10:
                        SumAndAverage();
                        break;

                    case 11:
                        MultiplicationTable();
                        break;

                    case 12:
                        NumberPattern();
                        break;

                    case 13:
                        HarmonicSeries();
                        break;

                    case 14:
                        PerfectNumbers();
                        break;

                    case 15:
                        PrimeCheck();
                        break;

                    case 0:
                        Console.WriteLine("Program ended.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                }

            } while (choice != 0);
        }

        // 1. Calculator
        static void Calculator()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+,-,*,/): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result = {result}");
        }

        // 2. Function values
        static void FunctionValues()
        {
            Console.WriteLine("y\tx = y^2 + 2y + 1");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"{y}\t{x}");
            }
        }

        // 3. Speed calculator
        static void SpeedCalculator()
        {
            Console.Write("Enter distance in meters: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double totalSeconds = hours * 3600 + minutes * 60 + seconds;

            double metersPerSecond = distance / totalSeconds;
            double kmPerHour = metersPerSecond * 3.6;
            double milesPerHour = kmPerHour / 1.609;

            Console.WriteLine($"Speed in km/h = {kmPerHour:F2}");
            Console.WriteLine($"Speed in miles/h = {milesPerHour:F2}");
        }

        // 4. Sphere calculation
        static void SphereCalculation()
        {
            Console.Write("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double surface = 4 * Math.PI * r * r;
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

            Console.WriteLine($"Surface Area = {surface:F2}");
            Console.WriteLine($"Volume = {volume:F2}");
        }

        // 5. Character checker
        static void CharacterChecker()
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if ("aeiouAEIOU".Contains(ch))
            {
                Console.WriteLine("It is a vowel.");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("It is a digit.");
            }
            else
            {
                Console.WriteLine("It is another symbol.");
            }
        }

        // 6. Even or odd
        static void EvenOrOdd()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");
        }

        // 7. Largest of three numbers
        static void LargestOfThree()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int largest = Math.Max(a, Math.Max(b, c));

            Console.WriteLine($"Largest number = {largest}");
        }

        // 8. Coordinate quadrant
        static void CoordinateQuadrant()
        {
            Console.Write("Enter X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("Quadrant I");
            else if (x < 0 && y > 0)
                Console.WriteLine("Quadrant II");
            else if (x < 0 && y < 0)
                Console.WriteLine("Quadrant III");
            else if (x > 0 && y < 0)
                Console.WriteLine("Quadrant IV");
            else
                Console.WriteLine("Point lies on axis");
        }

        // 9. Triangle type
        static void TriangleType()
        {
            Console.Write("Enter side 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Equilateral Triangle");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Isosceles Triangle");
            else
                Console.WriteLine("Scalene Triangle");
        }

        // 10. Sum and average
        static void SumAndAverage()
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }

            double average = sum / 10.0;

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }

        // 11. Multiplication table
        static void MultiplicationTable()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        // 12. Number pattern
        static void NumberPattern()
        {
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        // 13. Harmonic series
        static void HarmonicSeries()
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                Console.Write($"1/{i}");

                if (i < n)
                    Console.Write(" + ");
            }

            Console.WriteLine($"\nSum = {sum:F4}");
        }

        // 14. Perfect numbers
        static void PerfectNumbers()
        {
            Console.Write("Enter range limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perfect numbers:");

            for (int num = 1; num <= limit; num++)
            {
                int sum = 0;

                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        sum += i;
                }

                if (sum == num)
                    Console.WriteLine(num);
            }
        }

        // 15. Prime number check
        static void PrimeCheck()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (num <= 1)
                isPrime = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine("Prime number");
            else
                Console.WriteLine("Not a prime number");
        }
    }
}