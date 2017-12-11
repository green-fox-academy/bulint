using System;
using System.Collections.Generic;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            var diceList = new List<Dice>();

            for (int i = 0; i < 6; i++)
            {
                diceList.Add(new Dice());
            }
            for (int j = 0; j < 6; j++)
            {
                diceList[j].Roll();
            }
            for (int l = 0; l < 6; l++)
            {
                while (diceList[l].GetCurrent(diceList[l]) != 6)
                {
                    diceList[l].ReRoll();
                }
                Console.WriteLine(diceList[l].GetCurrent(diceList[l]));
            }

            Console.ReadLine();
        }
    }
}
