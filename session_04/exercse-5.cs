using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _cslt.session_04
{
    internal class exercise_5
    {
        // 1. Find maximum of three numbers
        static int MaxOfThree(int a, int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }
        // Improved version: accept many parameters
        static int Max(params int[] numbers)
        {
            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n > max)
                    max = n;
            }
            return max;
        }
        // 2. Factorial function
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        // 3. Check prime number
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        // 4.1 Print all prime numbers less than n
        static void PrintPrimesLessThan(int n)
        {
            Console.WriteLine("Prime numbers less than " + n + ":");
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        // 4.2 Print first N prime numbers
        static void PrintFirstNPrimes(int n)
        {
            Console.WriteLine("First " + n + " prime numbers:");
            int count = 0;
            int number = 2;
            while (count < n)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            }
            Console.WriteLine();
        }
        // 5. Check perfect number
        static bool IsPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum == n;
        }
        // Print all perfect numbers less than 1000
        static void PrintPerfectNumbers()
        {
            Console.WriteLine("Perfect numbers less than 1000:");

            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfect(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        // 6. Check pangram
        static bool IsPangram(string str)
        {
            str = str.ToLower();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!str.Contains(c))
                    return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            // 1. Maximum number
            int x = 5, y = 3, z = 9;
            int m= MaxOfThree(x, y, z);
            Console.WriteLine($"Max of {x},{y},{z} is {m}");
            // 2. Factorial
            Console.WriteLine("Factorial of 5: " + Factorial(5));
            // 3. Prime check
            Console.WriteLine("Is 17 prime? " + IsPrime(17));
            // 4. Prime numbers
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            PrintPrimesLessThan(n);
            Console.Write("Enter N: ");
            int p = int.Parse(Console.ReadLine());
            PrintFirstNPrimes(m);
            // 5. Perfect number
            Console.WriteLine("Is 28 perfect? " + IsPerfect(28));
            PrintPerfectNumbers();
            // 6. Pangram
            string sentence = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("Is pangram? " + IsPangram(sentence));
        }
    }
}