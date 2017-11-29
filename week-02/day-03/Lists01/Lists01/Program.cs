using System;
using System.Collections.Generic;

namespace Lists01
{
    class Program
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList.Insert(5, "Saturn");

            // Saturn is missing from the planetList
            // Insert it into the correct position

            foreach (var item in planetList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
