using System;
using GreenFox;

namespace Wanderer
{
    public class ThereAintAThingICannotDraw
    {
        private Random random = new Random();
        private FoxDraw foxDraw;
        const int TableWidth = 10;
        const int TableHeight = 11;
        private string floorImage;
        private string wallImage;
        private int x = 0;
        private int y = 0;
        private int[,] map;

        public ThereAintAThingICannotDraw(FoxDraw foxDraw)
        {
            this.foxDraw = foxDraw;
            floorImage = "./Assets/floor.png";
            wallImage = "./Assets/wall.png";
            map = new int[,]
            {
                { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 1, 0, 1, 1, 0 },
                { 0, 1, 1, 1, 0, 1, 0, 1, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0 },
                { 0, 1, 0, 1, 0, 0, 0, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 1, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 1, 1, 0, 1, 0 },
                { 0, 1, 1, 1, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 1, 0, 1, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0 }
            };
        }

        public int[,] GenerateMap()
        {
            for (int i = 0; i < TableHeight; i++)
            {
                for (int j = 0; j < TableWidth; j++)
                {
                    if (map[i,j] == 0)
                    {
                        foxDraw.AddImage(floorImage, x, y);
                    }
                    else
                    {
                        foxDraw.AddImage(wallImage, x, y);
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
