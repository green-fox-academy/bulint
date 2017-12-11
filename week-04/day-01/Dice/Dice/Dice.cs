using System;

namespace Dice
{
    public class Dice
    {
        public static Random random = new Random();
        public int diceValue { get; set; }

        public void Roll()
        {
            diceValue = random.Next(1, 7);
        }

        public void ReRoll()
        {
            diceValue = random.Next(1, 7);
        }

        public int GetCurrent(Dice dice)
        {
            return dice.diceValue;
        }
    }
}
