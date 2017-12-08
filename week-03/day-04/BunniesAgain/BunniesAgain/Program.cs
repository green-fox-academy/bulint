using System;

namespace BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBunnies = 10;
            int ears = 0;
            EarCounter(numberOfBunnies, ears);
            Console.ReadLine();
        }
        public static void EarCounter(int numberOfBunnies, int ears)
        {
            if (numberOfBunnies < 1)
            {
                Console.WriteLine(ears);
            }
            else
            {
                if (numberOfBunnies % 2 == 0)
                {
                    EarCounter(--numberOfBunnies, ears += 3);
                }
                else
                {
                    EarCounter(--numberOfBunnies, ears += 2);
                }
            }
        }
    }
}
// We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
// (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
// have 3 ears, because they each have a raised foot. Recursively return the
// number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

