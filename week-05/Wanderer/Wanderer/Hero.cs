using GreenFox;
using System.Windows;
using System.Windows.Input;

namespace Wanderer
{
    public class Hero : Character
    {
        private FoxDraw foxDraw;
        private string heroImageDown = "Assets/hero-down.png";
        private string heroImageUp = "Assets/hero-up.png";
        private string heroImageLeft = "Assets/hero-left.png";
        private string heroImageRight = "Assets/hero-right.png";
        private string floorImage = "Assets/floor.png";
        private int x = 0;
        private int y = 0;

        public Hero(FoxDraw foxDraw)
        {
            this.foxDraw = foxDraw;
            foxDraw.AddImage(heroImageDown, x, y);
        }

        public void MoveHeroUp()
        {
            foxDraw.AddImage(floorImage, x, y);
            y -= FoxDraw.TileSize;
            foxDraw.AddImage(heroImageUp, x, y);
        }

        public void MoveHeroDown()
        {
            foxDraw.AddImage(floorImage, x, y);
            y += FoxDraw.TileSize;
            foxDraw.AddImage(heroImageDown, x, y);
        }

        public void MoveHeroLeft()
        {
            foxDraw.AddImage(floorImage, x, y);
            x -= FoxDraw.TileSize;
            foxDraw.AddImage(heroImageLeft, x, y);
        }

        public void MoveHeroRight()
        {
            foxDraw.AddImage(floorImage, x, y);
            x += FoxDraw.TileSize;
            foxDraw.AddImage(heroImageRight, x, y);
        }
    }
}
