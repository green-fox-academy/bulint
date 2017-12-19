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
            Map map = new Map(foxDraw);

            map.GenerateMap();
        }
    }


}
