using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int bunnies = 5;
            int ears = 0;
            EarCounter(bunnies, ears);
            Console.ReadLine();
        }
        public static void EarCounter(int bunnies, int ears)
        {
            if (bunnies < 1)
            {
                Console.WriteLine(ears);
            }
            else
            {
                EarCounter(--bunnies, ears += 2);
            }
        }
    }
}
// We have a number of bunnies and each bunny has two big floppy ears.
// We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
