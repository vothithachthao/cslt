using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _cslt.session_03
{
    internal class exercise_3
    {
            static void Main(string[] args)
            {
                int choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Basic Calculator (+, -, *, x, /)");
                    Console.WriteLine("2. Display function x = y^2 + 2y + 1 (y from -5 to 5)");
                    Console.WriteLine("3. Calculate Speed (km/h and miles/h)");
                    Console.WriteLine("4. Sphere Surface and Volume");
                    Console.WriteLine("5. Check Character Type");
                    Console.WriteLine("0. Exit");
                    Console.Write("Choose an option: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Calculator();
                            break;
                        case 2:
                            DisplayFunction();
                            break;
                        case 3:
                            CalculateSpeed();
                            break;
                        case 4:
                            SphereCalculation();
                            break;
                        case 5:
                            CheckCharacter();
                            break;
                        case 0:
                            Console.WriteLine("Exiting program...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                } while (choice != 0);
            }

            // 1. Calculator
            static void Calculator()
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, x, /): ");
                string op = Console.ReadLine();

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                    case "x":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Cannot divide by zero!");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator!");
                        return;
                }

                Console.WriteLine($"Result: {result}");
            }

            // 2. Function display
            static void DisplayFunction()
            {
                Console.WriteLine("y\t x = y^2 + 2y + 1");

                for (int y = -5; y <= 5; y++)
                {
                    int x = y * y + 2 * y + 1;
                    Console.WriteLine($"{y}\t {x}");
                }
            }

            // 3. Speed calculation
            static void CalculateSpeed()
            {
                Console.Write("Enter distance (km): ");
                double distance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter hours: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter minutes: ");
                int minutes = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter seconds: ");
                int seconds = Convert.ToInt32(Console.ReadLine());

                double totalHours = hours + (minutes / 60.0) + (seconds / 3600.0);

                double speedKmH = distance / totalHours;
                double speedMilesH = speedKmH * 0.621371;

                Console.WriteLine($"Speed: {speedKmH:F2} km/h");
                Console.WriteLine($"Speed: {speedMilesH:F2} miles/h");
            }

            // 4. Sphere calculation
            static void SphereCalculation()
            {
                Console.Write("Enter radius: ");
                double r = Convert.ToDouble(Console.ReadLine());

                double surface = 4 * Math.PI * r * r;
                double volume = (4.0 / 3.0) * Math.PI * r * r * r;

                Console.WriteLine($"Surface: {surface:F2}");
                Console.WriteLine($"Volume: {volume:F2}");
            }

            // 5. Character check
            static void CheckCharacter()
            {
                Console.Write("Enter a character: ");
                char ch = Console.ReadKey().KeyChar;
                Console.WriteLine();

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
        }
    }
}