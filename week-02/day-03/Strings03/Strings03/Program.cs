using System;
using System.Text;

namespace Strings03
{
    class Program
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            string subquote1 = quote.Substring(0, 20);
            string subquote2 = quote.Substring(21);
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(subquote1);
            stringBuilder.Append(" always takes longer than ");
            stringBuilder.Append(subquote2);

            //quote = quote.Insert(21, "always ");
            //quote = quote.Insert(28, "takes ");
            //quote = quote.Insert(34, "longer ");
            //quote = quote.Insert(41, "than ");

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            Console.WriteLine(stringBuilder.ToString());
            Console.ReadLine();
        }
    }
}
