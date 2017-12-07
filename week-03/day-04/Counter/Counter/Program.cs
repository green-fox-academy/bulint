using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 666;
            RecursiveMethod(number);
            Console.ReadLine();
        }
        static int RecursiveMethod(int number)
        {
            if (number == 0)
            {
                Console.WriteLine(number);
                return 0;
            }
            else
            {
                Console.WriteLine(number);
                return RecursiveMethod(--number);
            }
        }
    }
}
