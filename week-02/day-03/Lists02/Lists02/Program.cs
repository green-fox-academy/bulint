using System;
using System.Collections.Generic;

namespace Lists02
{
    class Program
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();
            girls.AddRange(boys);
            order = girls;
            order.Remove("Joe");
            order.Insert(1, "Joe");
            order.Remove("Fred");
            order.Insert(3, "Fred");
            order.Remove("Béla");
            order.Insert(5, "Béla");
            order.Remove("Todd");
            order.Insert(7, "Todd");
            order.Remove("Neef");
            order.Insert(9, "Neef");

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            foreach (var item in order)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}