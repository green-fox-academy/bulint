﻿using System;
using System.Text;

namespace String04
{
    class Program
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            todoText = todoText.Insert(0, "My todo:\n");
            todoText = todoText.Insert(20, " - Download games\n");
            todoText = todoText.Insert(37, " - Diablo\n");

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
