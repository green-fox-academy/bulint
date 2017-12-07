using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 126;
            int sum = 0;
            Console.WriteLine(SumDigit(number, sum));
            Console.ReadLine();

        }
        static int SumDigit(int number, int sum)
        {
            if (number % 10 < 1)
            {
                return sum;
            }
            return SumDigit(number / 10, sum += (number % 10));

        }
    }
}
