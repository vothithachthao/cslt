using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _cslt.session_05
{
    internal class ArrayFunctions
    {
        // 1. Calculate average value
        static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }

            return (double)sum / arr.Length;
        }
        // 2. Test if array contains a specific value
        static bool ContainsValue(int[] arr, int value)
        {
            foreach (int num in arr)
            {
                if (num == value)
                    return true;
            }
            return false;
        }
        // 3. Find index of an element
        static int FindIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return i;
            }
            return -1;
        }
        // 4. Remove a specific element
        static int[] RemoveElement(int[] arr, int value)
        {
            List<int> list = new List<int>();
            foreach (int num in arr)
            {
                if (num != value)
                    list.Add(num);
            }
            return list.ToArray();
        }
        // 5. Find maximum and minimum value
        static void FindMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }
        }
        // 6. Reverse array
        static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }
        // 7. Find duplicate values
        static void FindDuplicates(int[] arr)
        {
            Console.WriteLine("Duplicate values:");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                bool alreadyPrinted = false;
                for (int k = 0; k < i; k++)
                {
                    if (arr[k] == arr[i])
                    {
                        alreadyPrinted = true;
                        break;
                    }
                }
                if (isDuplicate && !alreadyPrinted)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
        // 8. Remove duplicate elements
        static int[] RemoveDuplicates(int[] arr)
        {
            List<int> unique = new List<int>();
            foreach (int num in arr)
            {
                if (!unique.Contains(num))
                {
                    unique.Add(num);
                }
            }
            return unique.ToArray();
        }
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Main7(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            // Create random array
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 20);
            }
            Console.WriteLine("Original array:");
            PrintArray(numbers);
            // 1
            Console.WriteLine("\nAverage: " + CalculateAverage(numbers));
            // 2
            Console.WriteLine("Contains 5? " + ContainsValue(numbers, 5));
            // 3
            Console.WriteLine("Index of 5: " + FindIndex(numbers, 5));
            // 4
            Console.WriteLine("\nArray after removing 5:");
            PrintArray(RemoveElement(numbers, 5));
            // 5
            int max, min;
            FindMaxMin(numbers, out max, out min);
            Console.WriteLine("\nMaximum value: " + max);
            Console.WriteLine("Minimum value: " + min);
            // 6
            Console.WriteLine("\nReversed array:");
            PrintArray(ReverseArray(numbers));
            // 7
            Console.WriteLine();
            FindDuplicates(numbers);
            // 8
            Console.WriteLine("\nArray after removing duplicates:");
            PrintArray(RemoveDuplicates(numbers));
        }
    }
    internal class BubbleSortAndLinearSearch
    {
        // Bubble Sort
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        // Linear Search
        static bool LinearSearch(string[] words, string target)
        {
            foreach (string word in words)
            {
                if (word.Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main7(string[] args)
        {
            // Bubble Sort
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(numbers);
            Console.WriteLine("\nSorted numbers:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            // Linear Search
            Console.Write("\nEnter a sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter a word to search: ");
            string target = Console.ReadLine();
            string[] words = sentence.Split(' ');
            bool found = LinearSearch(words, target);
            if (found)
            {
                Console.WriteLine("Word found in the sentence.");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }
    }
}