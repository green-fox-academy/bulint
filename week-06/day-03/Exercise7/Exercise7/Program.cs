using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var filteredCities = cities.Where(s => cities[0] == "A")
                && cities.Where(s => cities[s.Length] == "I");

        }
    }
}
