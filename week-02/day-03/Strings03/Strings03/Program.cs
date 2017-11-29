using System;

namespace Strings03
{
    class Program
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            quote = quote.Insert(21, "always ");
            quote = quote.Insert(28, "takes ");
            quote = quote.Insert(34, "longer ");
            quote = quote.Insert(41, "than ");

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}
