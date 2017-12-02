using System;
using System.Collections.Generic;

namespace Lists07
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            list[2] = "cannot";
            list[5] = "do";

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}