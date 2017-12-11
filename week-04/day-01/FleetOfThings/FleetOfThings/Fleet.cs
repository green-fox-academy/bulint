using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        public List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public void Print()
        {
            for (int i = 0; i < Things.Count; i++)
            {
                if (Things[i].GetCompleted())
                {
                    Console.WriteLine(i + ". " + "[x] " + Things[i].Name);
                }
                else
                {
                    Console.WriteLine(i + ". " + "[ ] " + Things[i].Name);
                }
            }
        }
    }
}