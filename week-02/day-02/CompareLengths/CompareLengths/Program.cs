using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // - Create an array variable named `p1`
        //   with the following content: `[1, 2, 3]`
        // - Create an array variable named `p2`
        //   with the following content: `[4, 5]`
        // - Print if `p2` has more elements than `p1`

        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };

            if (p1[2] > p2[1])
            {
                Console.WriteLine("p2 has more elements than p1");
            }
            else
            {
                Console.WriteLine("p1 has more elements than p2");
            }
            Console.ReadLine();
        }
    }
}