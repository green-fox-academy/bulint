using GreenFox;

namespace Wanderer
{
    public class Hero : Character
    {
        private FoxDraw foxDraw;
        private string heroImage = "Assets/hero-down.png";

        public Hero(FoxDraw foxDraw)
        {
            this.foxDraw = foxDraw;
        }

        public void CreateHero()
        {
            foxDraw.AddImage(heroImage, 0, 0);
        }
    }
}
