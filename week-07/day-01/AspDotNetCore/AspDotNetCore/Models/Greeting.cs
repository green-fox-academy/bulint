using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCore
{
    public class Greeting
    {
        public int Id { get; set; }
        public string Content { get; set; }
        private static int counter;
        private static int counter2 = 1;

        public Greeting(string name)
        {
            Id = counter;
            Content = "Hello " + name;
        }

        public Greeting()
        {

        }

        public int IncreaseCounter()
        {
            return counter++;
        }

        public int IncreaseCounter2()
        {
            return counter2++;
        }
    }
}
