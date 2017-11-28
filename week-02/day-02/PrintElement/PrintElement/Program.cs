using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintElement
{
    class Program
    {
        // - Create an array variable named `af`
        //   with the following content: `[4, 5, 6, 7]`
        // - Print all the elements of `af`

        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };
            foreach (int numbers in af)
            {
                Console.WriteLine(numbers);
            }

            Console.ReadLine();
        }
    }
}
