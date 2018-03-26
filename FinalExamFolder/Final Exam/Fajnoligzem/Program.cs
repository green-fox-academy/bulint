using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings1 = { "alma", "korte", "hahota" };
            string[] strings2 = { "alma", "banan", "hahota" };
            string[] strings3 = { "alma", "majom", "hahota", "megbukunk igeeeeeeeeeeeeeeeen" };
            string[] strings4 = { "alma", "korte", "hahota" };

            Console.WriteLine(IsSame(strings1, strings2));
            Console.WriteLine(IsSame(strings2, strings3));
            Console.WriteLine(IsSame(strings1, strings4));
            Console.ReadLine();
        }

        static bool IsSame(string[] param1, string[] param2)
        {
            int counter = 0;

            if (param1.Length != param2.Length)
                return false;

            for (int i = 0; i < param1.Length; i++)
            {
                if (param1[i] != param2[i])
                    counter++;
            }

            if (counter == 0)
                return true;
            else
                return false;
        }
    }
}

//Create a function that takes two arrays and decides if their content is the same
