using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToCountLetterFrequencesIn = "kummerspeck";
            var frequencies = stringToCountLetterFrequencesIn.ToCharArray()
                .GroupBy(f => f)
                .ToDictionary(f => f.Key, f => f.Count());

            foreach (var f in frequencies)
            {
                Console.WriteLine(f);
            }

            var frequenciesQuery =
                from f in stringToCountLetterFrequencesIn
                group f by f into g
                select g;

            foreach (var f in frequenciesQuery.ToDictionary(f => f.Key, f => f.Count()))
            {
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }
    }
}
