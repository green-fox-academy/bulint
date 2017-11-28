using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.

            Console.WriteLine("Give me a number");
            int number = Int32.Parse(Console.ReadLine());
            if (number % 2 != 0)
            {
                Console.WriteLine("The number is odd");
            }
            else
            {
                Console.WriteLine("The number is even");
            }

            Console.ReadLine();
        }
    }
}
