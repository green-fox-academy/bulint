using System;

namespace AppendAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `nimals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end

            string[] nimals = { "kuty", "macsk", "cic" };

            for (int i = 0; i < nimals.Length; i++)
            {
                Console.WriteLine(nimals[i] + "a");
            }
            Console.ReadLine();
        }
    }
}