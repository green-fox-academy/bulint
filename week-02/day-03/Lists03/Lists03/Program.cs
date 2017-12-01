using System;
using System.Collections.Generic;

namespace Lists03
{
    public class Program
    {
        public class AppendLetter
        {
            public static void Main(string[] args)
            {
                var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };

                // Add "a" to every string in the far list.

                for (int i = 0; i < far.Count; i++)
                {
                    far[i] += "a";
                }

                foreach (var item in far)
                {
                    Console.WriteLine(item);
                }

                Console.ReadLine();
            }
        }
    }
}