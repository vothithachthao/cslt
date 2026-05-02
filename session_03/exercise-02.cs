using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _cslt.session_03
{
    internal class exercise_02
    {
            static void Main(string[] args)
            {
                int choice;

                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Check Even or Odd");
                    Console.WriteLine("2. Find Largest of Three Numbers");
                    Console.WriteLine("3. Determine Quadrant (XY)");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CheckEvenOdd();
                            break;
                        case 2:
                            FindLargest();
                            break;
                        case 3:
                            DetermineQuadrant();
                            break;
                        case 0:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                } while (choice != 0);
            }

            // 1. Even or Odd
            static void CheckEvenOdd()
            {
                Console.Write("Enter an integer: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                    Console.WriteLine("The number is Even.");
                else
                    Console.WriteLine("The number is Odd.");
            }

            // 2. Largest of three numbers
            static void FindLargest()
            {
                Console.Write("Enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter third number: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double max = a;

                if (b > max) max = b;
                if (c > max) max = c;

                Console.WriteLine($"The largest number is: {max}");
            }

            // 3. Quadrant determination
            static void DetermineQuadrant()
            {
                Console.Write("Enter X coordinate: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Y coordinate: ");
                double y = Convert.ToDouble(Console.ReadLine());

                if (x > 0 && y > 0)
                    Console.WriteLine("Point lies in Quadrant I.");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Point lies in Quadrant II.");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Point lies in Quadrant III.");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Point lies in Quadrant IV.");
                else if (x == 0 && y == 0)
                    Console.WriteLine("Point is at the Origin.");
                else if (x == 0)
                    Console.WriteLine("Point lies on the Y-axis.");
                else
                    Console.WriteLine("Point lies on the X-axis.");
            }
        }
    }
