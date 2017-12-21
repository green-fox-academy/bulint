using System;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            garden.FlowerMaker(2);
            garden.TreeMaker(2);

            garden.FlowerList[0].color = "yellow";
            garden.FlowerList[1].color = "blue";
            garden.TreeList[0].color = "purple";
            garden.TreeList[1].color = "orange";

            garden.GetStatus();
            garden.Waterer(40);
            garden.GetStatus();
            garden.Waterer(70);
            garden.GetStatus();

            Console.ReadLine();
        }
    }
}
