using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace GoToCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Random random = new Random();
            int x = 0;
            int y = 0;
            for (int i = 0; i < 3; i++)
            {
                x = random.Next(500);
                y = random.Next(500);
                DrawToTheCenter(foxDraw, x, y);
            }
        }
        public static void DrawToTheCenter(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(x, y, 250, 250);
        }
    }
}
// create a line drawing function that takes 2 parameters:
// the x and y coordinates of the line's starting point
// and draws a line from that point to the center of the canvas.
// draw 3 lines with that function.
