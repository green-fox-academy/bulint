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

namespace CenteredBoxes
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
            for (double i = 0; i < 3; i++)
            {
                double size = random.Next(500);
                SquareDrawing(foxDraw, size);
            }
        }
        public static void SquareDrawing(FoxDraw foxDraw, double size)
        {
            double x = (500 - size) / 2;
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.White);
            foxDraw.DrawRectangle(x, x, size, size);
        }
    }
}
// create a square drawing function that takes 1 parameter:
// the square size
// and draws a square of that size to the center of the canvas.
// draw 3 squares with that function.