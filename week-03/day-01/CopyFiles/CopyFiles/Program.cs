using System;
using System.IO;

namespace CopyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\L\Documents\doksi.txt";
        }

        static bool CopyFiles(string path)
        {
            string[] content = File.ReadAllLines(path);
            using (StreamWriter outputFile = new StreamWriter(path + @"\doksika.txt", true))
            {
                outputFile.WriteLine(content);
            }

        }
    }
}

// Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
// It should take the filenames as parameters
// It should return a boolean that shows if the copy was successful