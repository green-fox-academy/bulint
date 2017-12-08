using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            int power = 2;
            ToTheSky(power, number);
            Console.ReadLine();
        }
        public static void ToTheSky(int power, int number)
        {
            if (power == 1)
            {
                Console.WriteLine(number);
            }
            else
            {
                ToTheSky(--power, number * number);
            }
        }
    }
}
// Given base and n that are both 1 or more, compute recursively (no loops)
// the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
