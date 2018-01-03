using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            numbers.Where(n => n >= 0)
                .Select(n => n * n)
                .ToList()
                .ForEach(i => Console.WriteLine(i));

            Console.ReadLine();
        }
    }
}
