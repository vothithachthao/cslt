using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _cslt.session_07.exercise_8
{
    internal class exercise_8
    {
        // Read a sentence and replace lowercase characters with uppercase and vice-versa
        static void Main1(string[] args)
        {
            Console.Write("Input the string : ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i]))
                    arr[i] = char.ToUpper(arr[i]);
                else if (char.IsUpper(arr[i]))
                    arr[i] = char.ToLower(arr[i]);
            }
            string result = new string(arr);
            Console.WriteLine("After conversion, the string is : " + result);
        }
        // Check the username and password
        static void Main2(string[] args)
        {
            string username, password;
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();
                Console.Write("Input a password: ");
                password = Console.ReadLine();
            } while (username != "abcd" || password != "1234");
            Console.WriteLine("Password entered successfully!");
        }
        //Search for the position of a substring within a string
        static void Main3(string[] args)
        {
            Console.Write("Input a String: ");
            string str = Console.ReadLine();
            Console.Write("Input a substring to be found in the string: ");
            string find = Console.ReadLine();
            int index = str.IndexOf(find);
            if (index != -1)
            {
                Console.WriteLine($"Found '{find}' in '{str}' at position {index}");
            }
            else
            {
                Console.WriteLine("Substring not found.");
            }
        }
        // Check whether a character is an alphabet and not and if so, check for the case
        static void Main4(string[] args)
        {
            Console.Write("Input a character: ");
            char ch = Convert.ToChar(Console.ReadLine());
            if (char.IsLetter(ch))
            {
                if (char.IsUpper(ch))
                {
                    Console.WriteLine("The character is uppercase.");
                }
                else
                {
                    Console.WriteLine("The character is lowercase.");
                }
            }
            else
            {
                Console.WriteLine("The character is not an alphabet.");
            }
        }
        // Find the number of times a substring appears in a given string
        static void Main5(string[] args)
        {
            Console.Write("Input the original string : ");
            string str = Console.ReadLine();
            Console.Write("Input the string to be searched for : ");
            string search = Console.ReadLine();
            int count = 0;
            int index = 0;
            while ((index = str.IndexOf(search, index)) != -1)
            {
                count++;
                index += search.Length;
            }
            Console.WriteLine($"The string '{search}' occurs {count} times");
        }
        // Insert a substring before the first occurrence of a string
        static void Main6(string[] args)
        {
            Console.Write("Input the original string : ");
            string original = Console.ReadLine();
            Console.Write("Input the string to be searched for : ");
            string search = Console.ReadLine();
            Console.Write("Input the string to be inserted : ");
            string insert = Console.ReadLine();
            int position = original.IndexOf(search);
            if (position != -1)
            {
                string modified = original.Insert(position, insert + " ");
                Console.WriteLine("The modified string is : " + modified);
            }
            else
            {
                Console.WriteLine("The search string was not found.");
            }
        }
        // Compare (less than, greater than, equal to) two substrings
        static void Main7(string[] args)
        {
            Console.Write("Input the first string : ");
            string str1 = Console.ReadLine();
            Console.Write("Input the second string : ");
            string str2 = Console.ReadLine();
            int comparison = string.Compare(str1, str2);
            if (comparison < 0)
            {
                Console.WriteLine($"'{str1}' is less than '{str2}'");
            }
            else if (comparison > 0)
            {
                Console.WriteLine($"'{str1}' is greater than '{str2}'");
            }
            else
            {
                Console.WriteLine($"'{str1}' is equal to '{str2}'");
            }
        }
        // Compare two substrings that only differ in case. The first comparison ignores case and the second comparison considers case
        static void Main8(string[] args)
        {
            Console.Write("Input the first string : ");
            string str1 = Console.ReadLine();
            Console.Write("Input the second string : ");
            string str2 = Console.ReadLine();
            int comparisonIgnoreCase = string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase);
            int comparisonCaseSensitive = string.Compare(str1, str2, StringComparison.Ordinal);
            if (comparisonIgnoreCase == 0)
            {
                Console.WriteLine($"Ignoring case, '{str1}' is equal to '{str2}'");
            }
            else
            {
                Console.WriteLine($"Ignoring case, '{str1}' is not equal to '{str2}'");
            }
            if (comparisonCaseSensitive == 0)
            {
                Console.WriteLine($"Considering case, '{str1}' is equal to '{str2}'");
            }
            else
            {
                Console.WriteLine($"Considering case, '{str1}' is not equal to '{str2}'");
            }
        }
        // Compare two substrings using different cultures and ignore the substring case
        static void Main9(string[] args)
        {
            Console.Write("Input the first string : ");
            string str1 = Console.ReadLine();
            Console.Write("Input the second string : ");
            string str2 = Console.ReadLine();
            int comparisonInvariantCultureIgnoreCase = string.Compare(str1, str2, StringComparison.InvariantCultureIgnoreCase);
            int comparisonCurrentCultureIgnoreCase = string.Compare(str1, str2, StringComparison.CurrentCultureIgnoreCase);
            if (comparisonInvariantCultureIgnoreCase == 0)
            {
                Console.WriteLine($"Using Invariant Culture and ignoring case, '{str1}' is equal to '{str2}'");
            }
            else
            {
                Console.WriteLine($"Using Invariant Culture and ignoring case, '{str1}' is not equal to '{str2}'");
            }
            if (comparisonCurrentCultureIgnoreCase == 0)
            {
                Console.WriteLine($"Using Current Culture and ignoring case, '{str1}' is equal to '{str2}'");
            }
            else
            {
                Console.WriteLine($"Using Current Culture and ignoring case, '{str1}' is not equal to '{str2}'");
            }
        }
        // Compare the last names of two people. It then lists them in alphabetical order
        static void Main10(string[] args)
        {
            Console.Write("Input the first full name (First Last): ");
            string fullName1 = Console.ReadLine();
            Console.Write("Input the second full name (First Last): ");
            string fullName2 = Console.ReadLine();
            string lastName1 = fullName1.Split(' ').Last();
            string lastName2 = fullName2.Split(' ').Last();
            int comparison = string.Compare(lastName1, lastName2);
            if (comparison < 0)
            {
                Console.WriteLine($"'{fullName1}' comes before '{fullName2}'");
            }
            else if (comparison > 0)
            {
                Console.WriteLine($"'{fullName2}' comes before '{fullName1}'");
            }
            else
            {
                Console.WriteLine($"Both names have the same last name: '{lastName1}'");
            }
        }
        // Compare four sets of words by using each member of the string comparison enumeration. The comparisons use the conventions of the English (United States) and Sami (Upper Sweden) cultures.
        static void Main11(string[] args)
        {
            string str1 = "Case";
            string str2 = "case";
            Console.WriteLine("case = Case (CurrentCulture): " +
            string.Equals(str1, str2, StringComparison.CurrentCulture));
            Console.WriteLine("case = Case (CurrentCultureIgnoreCase): " +
            string.Equals(str1, str2, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine("case = Case (InvariantCulture): " +
            string.Equals(str1, str2, StringComparison.InvariantCulture));
            Console.WriteLine("case = Case (InvariantCultureIgnoreCase): " +
            string.Equals(str1, str2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("case = Case (Ordinal): " +
            string.Equals(str1, str2, StringComparison.Ordinal));
            Console.WriteLine("case = Case (OrdinalIgnoreCase): " +
            string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase));
        }
        // Demonstrate that the Compare(String, String, Boolean) method is equivalent to using ToUpper or ToLower when comparing strings
        static void Main12(string[] args)
        {
            string str1 = "QRS";
            string str2 = "qrs";
            Console.WriteLine($"Comparing '{str1}' and '{str2}':");
            // Using ToUpper()
            bool upperCompare = str1.ToUpper() == str2.ToUpper();
            // Using Compare() with ignoreCase = true
            bool ignoreCaseCompare = string.Compare(str1, str2, true) == 0;
            Console.WriteLine("The Strings are equal when capitalized? " + upperCompare);
            Console.WriteLine("The Strings are equal when case is ignored? " + ignoreCaseCompare);
        }
        // Demonstrate how culture affects comparisons
        static void Main13(string[] args)
        {
            string str1 = "change";
            string str2 = "dollar";
            // English - United States culture
            CultureInfo enUS = new CultureInfo("en-US");
            // Czech - Czech Republic culture
            CultureInfo csCZ = new CultureInfo("cs-CZ");
            int resultEn = string.Compare(str1, str2, enUS, CompareOptions.None);
            int resultCs = string.Compare(str1, str2, csCZ, CompareOptions.None);
            Console.Write("For en-US: ");
            if (resultEn < 0)
                Console.WriteLine($"{str1} < {str2}");
            else if (resultEn > 0)
                Console.WriteLine($"{str1} > {str2}");
            else
                Console.WriteLine($"{str1} = {str2}");
            Console.Write("For cs-CZ: ");
            if (resultCs < 0)
                Console.WriteLine($"{str1} < {str2}");
            else if (resultCs > 0)
                Console.WriteLine($"{str1} > {str2}");
            else
                Console.WriteLine($"{str1} = {str2}");
        }
        // Compare two strings in following three different ways produce three different results
        static void Main14(string[] args)
        {
            string str1 = "sister";
            string str2 = "Sister";
            CultureInfo enUS = new CultureInfo("en-US");
            // a. Linguistic comparison (case-sensitive)
            int result1 = string.Compare(str1, str2, false, enUS);
            // b. Linguistic comparison (ignore case)
            int result2 = string.Compare(str1, str2, true, enUS);
            // c. Ordinal comparison
            int result3 = string.CompareOrdinal(str1, str2);
            PrintResult(str1, str2, result1);
            PrintResult(str1, str2, result2);
            PrintResult(str1, str2, result3);
        }
        static void PrintResult(string s1, string s2, int result)
        {
            if (result < 0)
            {
                Console.WriteLine($"'{s1}' comes before '{s2}'.");
            }
            else if (result > 0)
            {
                Console.WriteLine($"'{s1}' comes after '{s2}'.");
            }
            else
            {
                Console.WriteLine($"'{s1}' is the same as '{s2}'.");
            }
        }
        // Compare three versions of the letter "I". The results are affected by culture choice, whether the case is ignored, and whether an ordinal comparison is performed
        static void Main15(string[] args)
        {
            string s1 = "i";   // U+0069
            string s2 = "ı";   // U+0131 (dotless i)
            string s3 = "I";   // U+0049
            Console.WriteLine("Compare three versions of the letter I using different values of StringComparison.");
            Console.WriteLine("The current culture is en-US.\n");
            Console.WriteLine("StringComparison.CurrentCulture:");
            CompareStrings(s1, "LATIN SMALL LETTER I (U+0069)",
                           s2, "LATIN SMALL LETTER DOTLESS I (U+0131)",
                           StringComparison.CurrentCulture);
            CompareStrings(s1, "LATIN SMALL LETTER I (U+0069)",
                           s3, "LATIN CAPITAL LETTER I (U+0049)",
                           StringComparison.CurrentCulture);
            CompareStrings(s2, "LATIN SMALL LETTER DOTLESS I (U+0131)",
                           s3, "LATIN CAPITAL LETTER I (U+0049)",
                           StringComparison.CurrentCulture);
        }
        static void CompareStrings(string a, string nameA,
                                   string b, string nameB,
                                   StringComparison comparisonType)
        {
            int result = string.Compare(a, b, comparisonType);

            if (result < 0)
            {
                Console.WriteLine($"{nameA} is less than {nameB}");
            }
            else if (result > 0)
            {
                Console.WriteLine($"{nameA} is greater than {nameB}");
            }
            else
            {
                Console.WriteLine($"{nameA} is equal to {nameB}");
            }
        }
        // Demonstrate that you compare ordinals and compare using different sort orders
        static void Main16(string[] args)
        {
            string str1 = "xyz";
            string str2 = "XYZ";
            char ch1 = str1[1]; // y
            char ch2 = str2[1]; // Y
            Console.WriteLine("CompareOrdinal(\"xyz\"[1], \"XYZ\"[1]):");
            int ordinalResult = ch1.CompareTo(ch2);
            if (ordinalResult > 0)
            {
                Console.WriteLine($" '{ch1}' is greater than '{ch2}'");
            }
            else if (ordinalResult < 0)
            {
                Console.WriteLine($" '{ch1}' is less than '{ch2}'");
            }
            else
            {
                Console.WriteLine($" '{ch1}' is equal to '{ch2}'");
            }
            Console.WriteLine("Compare(\"xyz\"[1], \"XYZ\"[1]):");
            int cultureResult = string.Compare(
                ch1.ToString(),
                ch2.ToString(),
                StringComparison.CurrentCulture);
            if (cultureResult > 0)
            {
                Console.WriteLine($" '{ch1}' is greater than '{ch2}'");
            }
            else if (cultureResult < 0)
            {
                Console.WriteLine($" '{ch1}' is less than '{ch2}'");
            }
            else
            {
                Console.WriteLine($" '{ch1}' is equal to '{ch2}'");
            }
        }
        //  Perform an ordinal comparison of two strings that only differ in case
        static void Main17(string[] args)
        {
            string str1 = "JAVA";
            string str2 = "python";
            Console.WriteLine("Compare the numeric values of the corresponding Char objects in each string.");
            Console.WriteLine($"str1 = '{str1}', str2 = '{str2}'");
            int result = string.CompareOrdinal(str1, str2);
            if (result < 0)
            {
                Console.WriteLine($"String '{str1}' is less than String '{str2}'.");
            }
            else if (result > 0)
            {
                Console.WriteLine($"String '{str1}' is greater than String '{str2}'.");
            }
            else
            {
                Console.WriteLine($"String '{str1}' is equal to String '{str2}'.");
            }
        }
        // Compare a given string with a set of strings
        class TestClass
        {
        }

        class Program
        {
            static void Main18()
            {
                string baseString = "some text";

                object[] values =
                {
            new TestClass(),
            123,
            "some text",
            "Some Text"
        };

                foreach (object obj in values)
                {
                    string compareString;

                    if (obj is string)
                    {
                        compareString = (string)obj;
                    }
                    else
                    {
                        Console.WriteLine($"Bad argument: {obj} (type {obj.GetType().Name})");
                        compareString = obj.ToString();
                    }

                    int result = string.Compare(baseString, compareString, StringComparison.Ordinal);

                    Console.WriteLine($"Comparing '{baseString}' with '{compareString}': {result}");
                }
            }
        }
        // Compare the current string instance with another string
        static void Main19()
        {
            CompareStrings("apple", "apple");     // Equal
            CompareStrings("orange", "apple");    // Follows
            Console.WriteLine();
            CompareStrings("apple", "orange");    // Precedes
            CompareStrings("ABC", "abc");         // Precedes
            CompareStrings("xyz", "XYZ");         // Follows
        }

        static void CompareStrings(string str1, string str2)
        {
            int result = str1.CompareTo(str2);
            if (result == 0)
            {
                Console.WriteLine("The strings occur in the same position in the sort order.");
            }
            else if (result > 0)
            {
                Console.WriteLine("The first string follows the second in the sort order.");
            }
            else
            {
                Console.WriteLine("The first string precedes the second in the sort order.");
            }
        }
        // Concatenate three objects, objects with a variable and a 3-element object array
        static void Main20()
        {
            string searchString = "abcЙ ࠉ";
            string targetString = "Å";
            Console.WriteLine($"Search for the target string \"{targetString}\" in the string \"{searchString}\".");
            Console.WriteLine();
            CultureInfo culture = new CultureInfo("en-GB");
            Console.WriteLine($"Using the English (United Kingdom) - \"{culture.Name}\" culture:");
            // Case-sensitive
            Console.WriteLine("Case sensitive:");
            bool result1 = culture.CompareInfo.IsSuffix(
                searchString,
                targetString,
                CompareOptions.None);
            Console.WriteLine($" The string to search ends with the target string: {result1}");
            // Case-insensitive
            Console.WriteLine("Case insensitive:");
            bool result2 = culture.CompareInfo.IsSuffix(
                searchString,
                targetString,
                CompareOptions.IgnoreCase);
            Console.WriteLine($" The string to search ends with the target string: {result2}");
        }
    }
}