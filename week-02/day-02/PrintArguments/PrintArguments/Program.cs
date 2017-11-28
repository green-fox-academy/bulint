using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// - Create a function called `printer`
//   which prints the input String parameters
// - It can have any number of parameters

// Examples
// printer("first")
// printer("first", "second")
// printer("first", "second", "third", "fourh")
// ...

namespace PrintArguments
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "i", "dont", "understand", "shit" };
            Printer(array);
            Console.ReadLine();
        }

        static void Printer(string[] myArray)
        {

            foreach (string item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
