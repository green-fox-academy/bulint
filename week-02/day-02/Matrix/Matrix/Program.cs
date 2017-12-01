using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{

    // - Create (dynamically) a two dimensional array
    //   with the following matrix. Use a loop!
    //
    //   1 0 0 0
    //   0 1 0 0
    //   0 0 1 0
    //   0 0 0 1
    //
    // - Print this two dimensional array to the output

    class Program
    {
        static void Main(string[] args)
        {
            char zero = '0';
            char one = '1';
            Console.Write("How many lines do you want this matrix to have?: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (j == i)
                    {
                        Console.Write(one);
                    }
                    else
                    {
                        Console.Write(zero);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
