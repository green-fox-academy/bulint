using System;

namespace exercise_29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.Write("I am a number eating robot and I'm hungry. Please give me a number: ");
            int number = int.Parse(Console.ReadLine());
            char star = '*';

            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j < number; j++)
                {
                    Console.Write(' ');
                }
                for (int l = 0; l < i * 2 - 1; l++)
                {
                    Console.Write(star);
                }

                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
    
