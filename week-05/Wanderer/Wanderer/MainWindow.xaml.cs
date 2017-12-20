using System.Windows;
using GreenFox;
using System.Windows.Input;

namespace Wanderer
{
    public partial class MainWindow : Window
    {
        Hero hero;


        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            Draw map = new Draw(foxDraw);

            map.GenerateMap();
            hero = new Hero(foxDraw);
        }

        public void PressThemButtons(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                hero.MoveHeroLeft();
            }
            else if (e.Key == Key.Up)
            {
                hero.MoveHeroUp();
            }
            else if (e.Key == Key.Down)
            {
                hero.MoveHeroDown();
            }
            else if (e.Key == Key.Right)
            {
                hero.MoveHeroRight();
            }
        }
    }
}
