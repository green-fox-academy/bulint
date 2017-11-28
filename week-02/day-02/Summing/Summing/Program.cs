using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter

            int n = 5;
            Sum(n);
            Console.ReadLine();
        }

        static void Sum(int summary)
        {
            int sum = 0;

            for (int i = 0; i <= summary; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }

    }
}
