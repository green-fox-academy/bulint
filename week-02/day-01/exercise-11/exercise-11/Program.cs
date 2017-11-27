using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            // make it bigger by 10

            Console.WriteLine(a + 10);

            int b = 100;
            // make it smaller by 7

            Console.WriteLine(b - 7);

            int c = 44;
            // please double c's value

            Console.WriteLine(c * 2);

            int d = 125;
            // please divide by 5 d's value

            Console.WriteLine(d / 5);

            int e = 8;
            // please cube of e's value

            Console.WriteLine(e * e * e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)

            if (f1 > f2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            if ((g2 * 2) > g1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            long h = 1357988018575474;
            // tell if it has 11 as a divisor (print as a boolean)

            if (h % 11 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            if (f1 > f2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)
            if (j % 3 == 0)
            {
                Console.WriteLine(true);
            }
            else if (j % 5 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            string k = "Apple";
            //fill the k variable with its cotnent 4 times

            k = k + k + k + k;

            Console.WriteLine(k);

            Console.ReadLine();
        }
    }
}
