using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("If you give me a distance in kilometers, I will convert it to miles for you :) Otherwise I won't do anthing");
            int kilometers = Int32.Parse(Console.ReadLine());
            Console.WriteLine(kilometers * 0.621371192);
            Console.ReadLine();

        }
    }
}
