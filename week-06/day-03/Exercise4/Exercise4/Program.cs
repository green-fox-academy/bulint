using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 9, 2, 8, 6, 5 };

            IEnumerable<double> numbersQueryWithLambda = numbers.Select(n => n * n)
                .Where(n => n > 20)
                .Select(n => Math.Sqrt(n));

            foreach (var n in numbersQueryWithLambda)
            {
                Console.WriteLine(n);
            }

            IEnumerable<double> numbersQuery =
                from n in numbers
                let squaredValue = n * n
                where squaredValue > 20
                select Math.Sqrt(squaredValue);

            foreach (double n in numbersQuery)
            {
                Console.WriteLine(n);
            }


            Console.ReadLine();
        }
    }
}
