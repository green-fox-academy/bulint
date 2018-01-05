using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencies = numbers.GroupBy(n => n)
                .ToDictionary(n => n.Key, n => n.Count());

            foreach (var f in frequencies)
            {
                Console.WriteLine(f);
            }

            var frequenciesQuery =
                from n in numbers
                group n by n into g
                select g;

            foreach (var f in frequenciesQuery.ToDictionary(n => n.Key, n => n.Count()))
            {
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }
    }
}
