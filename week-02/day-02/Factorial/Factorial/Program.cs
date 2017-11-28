using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            int n = 5;
            Factorio(n);
            Console.ReadLine();
        }

        static void Factorio(int factorio)
        {

            int sum = 1;

            for (int i = 1; i < factorio + 1; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}
