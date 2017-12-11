using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            var getMilk = new Thing("Get milk");
            var removeTheObstacles = new Thing("Remove the obstacles");
            var standUp = new Thing("Stand up");
            var eatLunch = new Thing("Eat lunch");

            fleet.Add(getMilk);
            fleet.Add(removeTheObstacles);
            fleet.Add(standUp);
            fleet.Add(eatLunch);
            standUp.Complete();
            eatLunch.Complete();
            fleet.Print();
            Console.ReadLine();
        }
    }
}

// Create a fleet of things to have this output:
// 1. [ ] Get milk
// 2. [ ] Remove the obstacles
// 3. [x] Stand up
// 4. [x] Eat lunch
// Hint: You have to create a Print method also