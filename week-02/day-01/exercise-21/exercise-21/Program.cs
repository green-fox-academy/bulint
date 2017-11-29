using System;

namespace exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Random random = new Random();
            int boys = random.Next(0, 20);
            int girls = random.Next(0, 20);
            int partypeople = boys + girls;

            if (boys == girls && partypeople > 20)
            {
                Console.WriteLine("The party is excellent!");
            }
            else if (partypeople > 20 && boys != girls)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (partypeople < 20)
            {
                Console.WriteLine("Average party...");
            }
            else if (girls == 0)
            {
                Console.WriteLine("Sausage party");
            }

            Console.ReadLine();

        }
    }
}