using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double a = 5;
            double b = 10;
            double c = 15;
            double volume = a * b * c;
            double surfaceArea = 2 * (a * b + a * c + b * c);
            Console.WriteLine("Surface Area: " + surfaceArea);
            Console.WriteLine("Volume: " + volume);
            Console.ReadLine();
            
        }
    }
}