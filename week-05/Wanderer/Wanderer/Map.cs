using System;
using GreenFox;

namespace Wanderer
{
    public class Map
    {
        private Random random = new Random();
        private FoxDraw foxDraw;
        const int TableWidth = 10;
        const int TableHeight = 11;
        private string floor;
        private string wall;
        private int x = 0;
        private int y = 0;

        public Map(FoxDraw foxDraw)
        {
            this.foxDraw = foxDraw;
            floor = "./Assets/floor.png";
            wall = "./Assets/wall.png";
        }

        public int[,] GenerateMap()
        {
            int[,] map = new int[,]
            {
                {0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                {0, 0, 0, 1, 0, 1, 0, 1, 1, 0 },
                {0, 1, 1, 1, 0, 1, 0, 1, 1, 0 },
                {0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                {1, 1, 1, 1, 0, 1, 1, 1, 1, 0 },
                {0, 1, 0, 1, 0, 0, 0, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 1, 0, 1, 0 },
                {0, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
                {0, 1, 1, 1, 0, 0, 0, 0, 1, 0 },
                {0, 0, 0, 1, 0, 1, 1, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 0, 0, 0, 0 }
            };

            for (int i = 0; i < TableHeight; i++)
            {
                for (int j = 0; j < TableWidth; j++)
                {
                    if (map[i,j] == 0)
                    {
                        foxDraw.AddImage(floor, x, y);
                    }
                    else
                    {
                        foxDraw.AddImage(wall, x, y);
                    }
                    x += FoxDraw.TileSize;
                }
                x = 0;
                y += FoxDraw.TileSize;
            }
            return map;
        }
    }
}
