using System.Windows;
using GreenFox;

namespace Wanderer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            ThereAintAThingICannotDraw map = new ThereAintAThingICannotDraw(foxDraw);
            Hero hero = new Hero(foxDraw);

            map.GenerateMap();
            hero.CreateHero();
        }
    }


}
