using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                Divider(input);
            }

        }
        static void Divider(int number)
        {
            try
            { 
                int ten = 10;
                int result = ten / number;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fail");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
