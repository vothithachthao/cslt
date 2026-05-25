using System;
namespace session_07.exercise_strings
{
    class exercise
    {
        //Input a string and print it
        static void Main1()
        {
            string str;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            Console.WriteLine("You entered: " + str);
        }
        //Find the length of a string without using a library function
        static void Main2()
        {
            string str;
            int length = 0;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            foreach (char c in str)
            {
                length++;
            }
            Console.WriteLine("Length of the string: " + length);
        }
        //Separate individual characters from a string
        static void Main3()
        {
            string str;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            Console.WriteLine("Individual characters:");
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
        }
        //Print individual characters of the string in reverse order
        static void Main4()
        {
            string str;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            Console.WriteLine("Individual characters in reverse order:");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);
            }
        }
        //Count the total number of words in a string
        static void Main5()
        {
            string str;
            int wordCount = 0;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    wordCount++;
                }
            }
            // Adding 1 to count the last word
            wordCount++;
            Console.WriteLine("Total number of words: " + wordCount);
        }
        //Compare two strings without using a string library functions
        static void Main6()
        {
            string str1, str2;
            Console.Write("Enter first string: ");
            str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            str2 = Console.ReadLine();
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Strings are not equal.");
                return;
            }
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    Console.WriteLine("Strings are not equal.");
                    return;
                }
            }
            Console.WriteLine("Strings are equal.");
        }
        //Count the number of alphabets, digits and special characters in a string
        static void Main7()
        {
            string str;
            int alphabets = 0, digits = 0, specialChars = 0;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    alphabets++;
                }
                else if (char.IsDigit(c))
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }
            Console.WriteLine("Alphabets: " + alphabets);
            Console.WriteLine("Digits: " + digits);
            Console.WriteLine("Special Characters: " + specialChars);
        }
        //Count the number of vowels or consonants in a string
        static void Main8()
        {
            string str;
            int vowels = 0, consonants = 0;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    if ("AEIOUaeiou".IndexOf(c) >= 0)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }
            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }
        //Check whether a given substring is present in the given string
        static void Main9()
        {
            string str, substring;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            Console.Write("Enter a substring to search: ");
            substring = Console.ReadLine();
            if (str.Contains(substring))
            {
                Console.WriteLine("Substring is present in the string.");
            }
            else
            {
                Console.WriteLine("Substring is not present in the string.");
            }
        }
        //Search for the position of a substring within a string
        static void Main10()
        {
            string str, substring;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            Console.Write("Enter a substring to search: ");
            substring = Console.ReadLine();
            int position = str.IndexOf(substring);
            if (position >= 0)
            {
                Console.WriteLine("Substring found at position: " + position);
            }
            else
            {
                Console.WriteLine("Substring not found in the string.");
            }
        }
        //Check whether a character is an alphabet and not and if so, check for the case
        static void Main11()
        {
            char c;
            Console.Write("Enter a character: ");
            c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                {
                    Console.WriteLine("The character is an uppercase alphabet.");
                }
                else
                {
                    Console.WriteLine("The character is a lowercase alphabet.");
                }
            }
            else
            {
                Console.WriteLine("The character is not an alphabet.");
            }
        }
        //Find the number of times a substring appears in a given string
        static void Main12()
        {
            string str, substring;
            int count = 0;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            Console.Write("Enter a substring to search: ");
            substring = Console.ReadLine();
            int index = str.IndexOf(substring);
            while (index >= 0)
            {
                count++;
                index = str.IndexOf(substring, index + substring.Length);
            }
            Console.WriteLine("The substring appears " + count + " times in the string.");
        }
        // Insert a substring before the first occurrence of a string
        static void Main13()
        {
            string str, substring, newSubstring;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            Console.Write("Enter a substring to search: ");
            substring = Console.ReadLine();
            Console.Write("Enter a new substring to insert: ");
            newSubstring = Console.ReadLine();
            int index = str.IndexOf(substring);
            if (index >= 0)
            {
                string result = str.Substring(0, index) + newSubstring + str.Substring(index);
                Console.WriteLine("Resulting string: " + result);
            }
            else
            {
                Console.WriteLine("Substring not found in the string.");
            }
        }
    }
}