using System;

namespace Strings05
{
    class Program
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Reverse(reversed);
            Console.ReadLine();
        }
        public static void Reverse(string reverser)
        {
            string result = String.Empty;
            char[] array = reverser.ToCharArray();
            for (int i = reverser.Length - 1; i > -1 ; i--)
            {
                result += array[i];
            }
            reverser.Remove(0, 80);
            Console.WriteLine(result);
        }
    }
}
