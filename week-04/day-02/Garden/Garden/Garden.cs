using System;
using System.Collections.Generic;

namespace Garden
{
    class Garden
    {
        private Random random;
        public List<Flower> FlowerList { get; set; }
        public List<Tree> TreeList { get; set; }
        public int TreeAmountToWater { get; set; }
        public int FlowerAmountToWater { get; set; }

        public Garden()
        {
            random = new Random();
        }

        public List<Flower> FlowerMaker(int amount)
        {
            FlowerList = new List<Flower>();
            for (int i = 0; i < amount; i++)
            {
                FlowerList.Add(new Flower(random.Next(10)));
            }
            return FlowerList;
        }

        public List<Tree> TreeMaker(int amount)
        {
            TreeList = new List<Tree>();
            for (int i = 0; i < amount; i++)
            {
                TreeList.Add(new Tree(random.Next(15)));
            }
            return TreeList;
        }

        public void Waterer(int amountToWaterWith)
        {
            Console.WriteLine("\nWatering With: " + amountToWaterWith + "\n");

            PlantAmountToWater();

            foreach (var flower in FlowerList)
            {
                if (flower.DoesNeedWater())
                {
                    flower.waterAmount = flower.waterAmount + amountToWaterWith / FlowerAmountToWater * 0.75;
                }
            }

            foreach (var tree in TreeList)
            {
                if (tree.DoesNeedWater())
                {
                    tree.waterAmount = tree.waterAmount + amountToWaterWith / TreeAmountToWater * 0.4;
                }
            }
        }

        public void GetStatus()
        {
            foreach (var flower in FlowerList)
            {
                if (flower.DoesNeedWater())
                {
                    Console.WriteLine(flower.color + " flower does need water");
                }
                else
                {
                    Console.WriteLine(flower.color + " flower does not need water");
                }
            }

            foreach (var tree in TreeList)
            {
                if (tree.DoesNeedWater())
                {
                    Console.WriteLine(tree.color + " tree does need water");
                }
                else
                {
                    Console.WriteLine(tree.color + " tree does not need water");
                }
            }
        }

        public void PlantAmountToWater()
        {
            foreach (var flower in FlowerList)
            {
                if (flower.DoesNeedWater())
                {
                    FlowerAmountToWater++;
                }
            }

            foreach (var tree in TreeList)
            {
                if (tree.DoesNeedWater())
                {
                    TreeAmountToWater++;
                }
            }
        }
    }
}
