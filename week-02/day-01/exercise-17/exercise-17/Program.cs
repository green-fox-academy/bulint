using System;

namespace exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            int Sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I want a number: ");
                Sum += int.Parse(Console.ReadLine());
            }

            int Average = Sum / 5;

            Console.WriteLine("Sum: " + Sum + ", Average: " + Average);
            Console.ReadLine();
        }
    }
}