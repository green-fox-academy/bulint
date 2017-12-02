using System;
using System.Collections.Generic;

namespace Lists06
{
    class Program
    {
        public static void Main(string[] args)
        {
            var list1 = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            var list2 = new List<int> { 4, 8, 12, 16 };
            string result = String.Empty;
            int checker = 0;

            if (list2.Contains(0) && !list1.Contains(0))
            {
                checker += 1;
            }
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list2[j] = 0;
                        result += list2[j];
                    }
                }
            }

            if (int.Parse(result) == 0 && checker == 0)
            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();
        }
    }
}