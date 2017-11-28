using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterFunction
{
    class Program
    {
        static void Greet(string al)
        {
            Console.WriteLine("Greetings dear, " + al + "!");
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`

            string al = "Greenfox";
            Greet(al);
        }
    }
}
