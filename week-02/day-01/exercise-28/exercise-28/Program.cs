using System;

namespace exercise_28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Random random = new Random();
            int number = random.Next(1, 10);
            Console.WriteLine("The random number is: " + number);
            string triangle = String.Empty;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(triangle += "*");
            }

            Console.ReadLine();
        }
    }
}