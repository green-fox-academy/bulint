using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a series of characters!!11one:  ");
            string input = Console.ReadLine();
            CreatePalindrome(input);
            Console.ReadLine();
        }

        static void CreatePalindrome(string palindrome)
        {
            char[] charray = palindrome.ToCharArray();
            for (int i = palindrome.Length - 1; i >= 0; i--)
            {
                palindrome += charray[i];
            }
            Console.WriteLine(palindrome);
        }
    }
}
