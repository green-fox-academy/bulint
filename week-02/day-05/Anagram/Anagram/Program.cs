using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram("dog");
        }

        static string Anagram(string input, string output, bool result)
        {
            char[] charray = input.ToCharArray(); 

            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];
            }

            if (input == output)
            {
                return result;
            }

        }
    }
}
