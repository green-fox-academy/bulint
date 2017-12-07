using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            NumberAdder(number);
        }
        static int NumberAdder(int number)
        {
            for (int i = 0; i < number; i++)
            {
                int addedNumbers =+ number;
            }
            Console.WriteLine(number);
            return NumberAdder(number);
        }
    }
}
