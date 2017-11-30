using System;

namespace exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have

            Console.WriteLine("Number of chickens: ");
            int chickens = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of pigs: ");
            int pigs = int.Parse(Console.ReadLine());
            int chickenlegs = 0;
            int piglegs = 0;

            for (int i = 0; i < chickens; i++)
            {
                chickenlegs += 2;
            }
            for (int i = 0; i < pigs; i++)
            {
                piglegs += 4;
            }

            Console.WriteLine("Number of legs the farmer's chickens have: " + chickenlegs);
            Console.WriteLine("Number of legs the farmer's pigs have: " + piglegs);
            Console.ReadLine();
        }
    }
}