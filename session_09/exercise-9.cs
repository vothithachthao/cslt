using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _cslt.session_09
{
    internal class exercise_9
    {
        // Create a blank file on the disk
        static void Main1()
        {
            string path = "blankfile.txt";
            File.Create(path).Close();
            Console.WriteLine("Blank file created.");
        }
        // Remove a file from the disk
        static void Main2()
        {
            string path = "blankfile.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        // Create a file and add some text
        static void Main3()
        {
            string path = "sample.txt";
            File.WriteAllText(path, "Welcome to C# File Handling.");
            Console.WriteLine("Text written successfully.");
        }
        // Create a Text File and Read It
        static void Main4()
        {
            string path = "readfile.txt";
            File.WriteAllText(path, "This is a sample text file.");
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
        // Create a file and write an array of strings to the file
        static void Main5()
        {
            string path = "arrayfile.txt";
            string[] lines =
            {
            "Apple",
            "Banana",
            "Orange",
            "Mango"
            };
            File.WriteAllLines(path, lines);
            Console.WriteLine("Array written to file.");
        }
        // Append some text to an existing file
        static void Main6()
        {
            string path = "sample.txt";
            File.AppendAllText(path,
                "\nThis text is appended.");
            Console.WriteLine("Text appended.");
        }
        // Create and copy the file to another name and display the content
        static void Main7()
        {
            string source = "original.txt";
            string destination = "copy.txt";
            File.WriteAllText(source, "Hello World!");
            File.Copy(source, destination, true);
            Console.WriteLine(File.ReadAllText(destination));
        }
        // Create a file and move it into the same directory with another name
        static void Main8()
        {
            string source = "oldname.txt";
            string destination = "newname.txt";
            File.WriteAllText(source, "File moved.");
            File.Move(source, destination);
            Console.WriteLine("File renamed successfully.");
        }
        // Read the first line of a file
        static void Main9()
        {
            string path = "data.txt";
            string firstLine = File.ReadLines(path).First();
            Console.WriteLine("First Line: " + firstLine);
        }
        // Create and read the last line of a file
        static void Main10()
        {
            string path = "lastline.txt";
            File.WriteAllLines(path, new string[]
            {
            "Line 1",
            "Line 2",
            "Line 3"
            });
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine("Last Line: " +
                              lines[lines.Length - 1]);
        }
        // Create and read the last n lines of a file
        static void Main11()
        {
            int n = 2;
            string path = "nlines.txt";
            File.WriteAllLines(path, new string[]
            {
            "One",
            "Two",
            "Three",
            "Four",
            "Five"
            });
            var lines = File.ReadLines(path).ToList();
            var lastLines = lines.Skip(Math.Max(0, lines.Count - n));
            foreach (var line in lastLines)
            {
                Console.WriteLine(line);
            }
        }
        // Read a specific line from a file
        static void Main12()
        {
            string path = "data.txt";
            int lineNumber = 3;
            string[] lines = File.ReadAllLines(path);
            if (lineNumber <= lines.Length)
            {
                Console.WriteLine(lines[lineNumber - 1]);
            }
            else
            {
                Console.WriteLine("Line does not exist. ");
            }
        }
        // Count the number of lines in a file
        static void Main13()
        {
            string path = "data.txt";
            int count = File.ReadAllLines(path).Length;
            Console.WriteLine("Number of lines: " + count);
        }
        // Print the structure of specific folder (include files)
        static void DisplayDirectory(string path, int level)
        {
            string indent = new string(' ', level * 2);
            foreach (string dir in Directory.GetDirectories(path))
            {
                Console.WriteLine(indent + "[DIR] " +
                                  Path.GetFileName(dir));
                DisplayDirectory(dir, level + 1);
            }
            foreach (string file in Directory.GetFiles(path))
            {
                Console.WriteLine(indent + Path.GetFileName(file));
            }
        }
        static void Main14()
        {
            string folderPath = @"C:\TestFolder";
            DisplayDirectory(folderPath, 0);
        }
        // Read a text file, then statistic the appearance of characters and numbers
        static void Main15()
        {
            string path = "sample.txt";
            string text = File.ReadAllText(path);
            int letters = 0;
            int digits = 0;
            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                    letters++;
                if (char.IsDigit(ch))
                    digits++;
            }
            Console.WriteLine("Letters : " + letters);
            Console.WriteLine("Digits  : " + digits);
        }
    }
}
