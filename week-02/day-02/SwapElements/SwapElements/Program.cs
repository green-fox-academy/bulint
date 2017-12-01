using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = { "first", "second", "third" };
            abc.SetValue("third", 0);
            abc.SetValue("first", 2);

            foreach (var item in abc)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}