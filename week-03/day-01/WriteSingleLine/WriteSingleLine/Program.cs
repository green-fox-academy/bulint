using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\L\Documents";
            try
            {
                using (StreamWriter outputFile = new StreamWriter(path + @"\doksi.txt", true))
                {
                    outputFile.WriteLine("Bodnár Bálint");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write the file: " + path);
            }
            finally
            {
                string[] content = File.ReadAllLines(path + @"\doksi.txt");
                foreach (var item in content)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }
}

// Open a file called "my-file.txt"
// Write your name in it as a single line
// If the program is unable to write the file,
// then it should print an error message like: "Unable to write file: my-file.txt"