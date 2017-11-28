using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubling
{
    class Program
    {
        public static int Doubling(int i)
        {
            return i * 2;
        }

        static void Main(string[] args)
        {
            // - Create an integer variable named `ak` and assign the value `123` to it
            // - Create a function called `doubling` that doubles it's input parameter
            // - Print the result of `doubling(ak)`

            int ak = 123;
            Console.WriteLine(Doubling(ak));
            Console.ReadLine();

        }
    }
}
