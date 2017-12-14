using System;

namespace DrawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (int j = i; j < input; j++)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < i * 2 - 1; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = input - 1; i >= 1; i--)
            {
                for (int j = input - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < i * 2 - 1; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}