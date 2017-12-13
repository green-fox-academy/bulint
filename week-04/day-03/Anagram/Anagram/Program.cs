using System;
using System.Linq;

namespace Anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public bool AnagramOrNot(string input1, string input2)
        {
            int sum = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1.Contains(input2[i]))
                {
                    sum += 0;
                }
                else
                {
                    sum += 1;
                }
            }
            if (sum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
