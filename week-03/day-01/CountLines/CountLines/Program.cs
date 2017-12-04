using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\L\Desktop\doksi.txt";
            try
            {
                Console.WriteLine(NumberOfLines(path));
            }
            catch (Exception)
            {
                Console.WriteLine(0);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static int NumberOfLines(string fileName)
        {
            string[] content = File.ReadAllLines(fileName);
            int numberOfLines = content.Length;
            return numberOfLines;
        } 
    }
}

// Write a function that takes a filename as string,
// then returns the number of lines the file contains.
// It should return zero if it can't open the file, and
// should not raise any error.
