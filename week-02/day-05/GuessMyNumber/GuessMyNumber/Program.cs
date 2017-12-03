using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int lives = 5;
            Console.WriteLine("You have 5 lives. It's your turn to save the universe. Will you do what needs to be done? The evil prankster has \nthought of a number between 1 and 100 and you have to find out what the number is to save everyone..");
            int input = int.Parse(Console.ReadLine());

            if (input == randomNumber)
            {
                Console.WriteLine("OMG! You did it! Congratulations!");
            }
            else
            {
                while (input != randomNumber || lives > 0)
                {
                    if (input > randomNumber)
                    {
                        lives--;
                        Console.WriteLine("Go lower, you only have " + lives + " lives left!");
                    }
                    else if (lives == 0)
                    {
                        Console.WriteLine("You have lost all of your lives. Shame on you. Now we're all dead because of your incompetent ass");
                    }
                    else if (input < randomNumber)
                    {
                        lives--;
                        Console.WriteLine("Go higher, you only have " + lives + " lives left!");
                    }

                    input = int.Parse(Console.ReadLine());
                }
            }

            Console.ReadLine();
        }
    }
}
