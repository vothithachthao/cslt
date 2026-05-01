using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _cslt.session_02
{
    internal class exercise_2
    {
        static void Main2(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("31. Multiply Two Arrays");
                Console.WriteLine("32. Four Copies Last 4 Characters");
                Console.WriteLine("33. Multiple of 3 or 7");
                Console.WriteLine("34. String Starts with Word");
                Console.WriteLine("35. <100 and >200");
                Console.WriteLine("36. Range -10 to 10");
                Console.WriteLine("37. Remove 'HP'");
                Console.WriteLine("38. Extract 'PH'");
                Console.WriteLine("39. Largest & Smallest of 3");
                Console.WriteLine("40. Nearest to 20");
                Console.WriteLine("41. Count 'w' (1-3)");
                Console.WriteLine("42. First 4 lower, rest upper");
                Console.WriteLine("43. Starts with 'www'");
                Console.WriteLine("44. Every other character");
                Console.WriteLine("45. Count number in array");
                Console.WriteLine("46. First or last equal");
                Console.WriteLine("47. Sum array");
                Console.WriteLine("48. First = Last");
                Console.WriteLine("49. Compare 2 arrays");
                Console.WriteLine("50. Rotate array left");
                Console.WriteLine("0. Exit");

                Console.Write("Choose: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (c)
                {
                    case 31: MultiplyArrays(); break;
                    case 32: FourCopies(); break;
                    case 33: Multiple3or7(); break;
                    case 34: StartsWithWord(); break;
                    case 35: Check100_200(); break;
                    case 36: RangeCheck(); break;
                    case 37: RemoveHP(); break;
                    case 38: ExtractPH(); break;
                    case 39: LargestSmallest(); break;
                    case 40: Nearest20(); break;
                    case 41: CountW(); break;
                    case 42: CaseConvert(); break;
                    case 43: StartsWWW(); break;
                    case 44: EveryOther(); break;
                    case 45: CountNumber(); break;
                    case 46: FirstOrLast(); break;
                    case 47: SumArray(); break;
                    case 48: FirstLastEqual(); break;
                    case 49: CompareArrays(); break;
                    case 50: RotateLeft(); break;
                    case 0: return;
                }

                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
            }
        }

        // 31
        static void MultiplyArrays()
        {
            int[] a = { 1, 3, -5, 4 };
            int[] b = { 1, 4, -5, -2 };

            for (int i = 0; i < a.Length; i++)
                Console.Write((a[i] * b[i]) + " ");
        }

        // 32
        static void FourCopies()
        {
            Console.Write("Input string: ");
            string s = Console.ReadLine();

            if (s.Length < 4)
                Console.WriteLine(s);
            else
            {
                string last4 = s.Substring(s.Length - 4);
                Console.WriteLine($"{last4}.{last4}.{last4}.{last4}.");
            }
        }

        // 33
        static void Multiple3or7()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 3 == 0 || n % 7 == 0);
        }

        // 34
        static void StartsWithWord()
        {
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            Console.WriteLine(s.StartsWith("Hello"));
        }

        // 35
        static void Check100_200()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a < 100 && b > 200);
        }

        // 36
        static void RangeCheck()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(
                (a >= -10 && a <= 10) ||
                (b >= -10 && b <= 10));
        }

        // 37
        static void RemoveHP()
        {
            string s = "PHP Tutorial";
            if (s.Length >= 3 && s.Substring(1, 2) == "HP")
                Console.WriteLine(s.Remove(1, 2));
            else
                Console.WriteLine(s);
        }

        // 38
        static void ExtractPH()
        {
            string s = Console.ReadLine();
            if (s.StartsWith("PH"))
                Console.WriteLine("PH");
        }

        // 39
        static void LargestSmallest()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Largest: " + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Smallest: " + Math.Min(a, Math.Min(b, c)));
        }

        // 40
        static void Nearest20()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a == b) Console.WriteLine(0);
            else
            {
                int da = Math.Abs(20 - a);
                int db = Math.Abs(20 - b);
                Console.WriteLine(da < db ? a : b);
            }
        }

        // 41
        static void CountW()
        {
            string s = Console.ReadLine();
            int count = s.Count(c => c == 'w');
            Console.WriteLine(count >= 1 && count <= 3);
        }

        // 42
        static void CaseConvert()
        {
            string s = Console.ReadLine();

            if (s.Length < 4)
                Console.WriteLine(s.ToUpper());
            else
                Console.WriteLine(s.Substring(0, 4).ToLower() + s.Substring(4).ToUpper());
        }

        // 43
        static void StartsWWW()
        {
            string s = Console.ReadLine();
            Console.WriteLine(s.StartsWith("www"));
        }

        // 44
        static void EveryOther()
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i += 2)
                Console.Write(s[i]);
        }

        // 45
        static void CountNumber()
        {
            int[] arr = { 1, 5, 6, 5, 9 };
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(arr.Count(x => x == n));
        }

        // 46
        static void FirstOrLast()
        {
            int[] arr = { 10, 20, 30, 40 };
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(arr[0] == n || arr[arr.Length - 1] == n);
        }

        // 47
        static void SumArray()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("Sum: " + arr.Sum());
        }

        // 48
        static void FirstLastEqual()
        {
            int[] arr = { 1, 2, 3, 4, 1 };
            Console.WriteLine(arr[0] == arr[arr.Length - 1]);
        }

        // 49
        static void CompareArrays()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 5, 3 };

            Console.WriteLine(a[0] == b[0] || a[^1] == b[^1]);
        }

        // 50
        static void RotateLeft()
        {
            int[] arr = { 1, 2, 8 };
            int temp = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
                arr[i] = arr[i + 1];

            arr[arr.Length - 1] = temp;

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
