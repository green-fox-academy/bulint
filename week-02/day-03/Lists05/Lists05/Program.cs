using System;
using System.Collections.Generic;

namespace Lists05
{
    class Program
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            // Check if the arrayList contains "7" if it contains print "Hoorray" otherwise print "Noooooo"
            // Do this again with a different solution using different list functions!

            if (List.Contains(7))
            {
                Console.WriteLine("Hoorray!!!11one");
            }
            else
            {
                Console.WriteLine("Noooooooooooo!!!11one");
            }

            Console.ReadLine();
        }
    }
}