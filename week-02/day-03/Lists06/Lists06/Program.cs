using System;
using System.Collections.Generic;

namespace Lists06
{
    class Program
    {
        public static void Main(string[] args)
        {
            var list1 = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?

            var list2 = new List<int> { 4, 8, 12, 16 };

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list2[j] = 0;
                    }
                }
            }

            string result = String.Empty;

            for (int i = 0; i < list2.Count; i++)
            {
                result += list2[i];
            }

            if (int.Parse(result) == 0)
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