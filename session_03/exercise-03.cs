using System;

namespace _cslt.session_03
{
    internal class exercise_03
    {
        static void Main03()
        {
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Triangle Type (Equilateral, Isosceles, Scalene)");
                Console.WriteLine("2. Sum and Average of 10 Numbers");
                Console.WriteLine("3. Multiplication Table");
                Console.WriteLine("4. Number Triangle Pattern");
                Console.WriteLine("5. Sequential Number Pattern");
                Console.WriteLine("6. Harmonic Series");
                Console.WriteLine("7. Perfect Numbers in Range");
                Console.WriteLine("8. Check Prime Number");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: TriangleType(); break;
                    case 2: SumAverage(); break;
                    case 3: MultiplicationTable(); break;
                    case 4: Pattern1(); break;
                    case 5: Pattern2(); break;
                    case 6: HarmonicSeries(); break;
                    case 7: PerfectNumbers(); break;
                    case 8: PrimeCheck(); break;
                }

                Console.WriteLine("\nPress any key...");
                Console.ReadKey();

            } while (choice != 0);
        }

        // 1. Triangle type
        static void TriangleType()
        {
            Console.Write("Enter side a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Equilateral triangle");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Isosceles triangle");
                else
                    Console.WriteLine("Scalene triangle");
            }
            else
            {
                Console.WriteLine("Not a valid triangle");
            }
        }

        // 2. Sum and average
        static void SumAverage()
        {
            double sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                sum += Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {sum / 10}");
        }

        // 3. Multiplication table
        static void MultiplicationTable()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        // 4. Pattern: 1, 12, 123...
        static void Pattern1()
        {
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }

        // 5. Sequential pattern: 1, 2 3, 4 5 6...
        static void Pattern2()
        {
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int num = 1;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        // 6. Harmonic series
        static void HarmonicSeries()
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            Console.Write("Series: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i} ");
                sum += 1.0 / i;
            }

            Console.WriteLine($"\nSum = {sum}");
        }

        // 7. Perfect numbers
        static void PerfectNumbers()
        {
            Console.Write("Enter range (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perfect numbers:");

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }

                if (sum == i && i != 0)
                    Console.WriteLine(i);
            }
        }

        // 8. Prime check
        static void PrimeCheck()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Not a prime number");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? "Prime number" : "Not a prime number");
        }
    }
}