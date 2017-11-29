using System;
using System.Text;

namespace Strings04
{
    class Program
    {
        public static void Main(string[] args)
        {
            string todoText = "\n - Buy milk";
            todoText = todoText.Insert(0, "My todo:");
            todoText = todoText.Insert(20, "\n - Download games");
            todoText = todoText.Insert(38, "\n     - Diablo");

            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(todoText);
            Console.ReadLine();
        }
    }
}
