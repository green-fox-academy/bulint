using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = { 3, 4, 5, 6, 7 };
            Array.Reverse(aj);

            foreach (int item in aj)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}