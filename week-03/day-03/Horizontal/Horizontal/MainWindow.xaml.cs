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

namespace Horizontal
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
            for (int i = 0; i < 3; i++)
            {
                int x = random.Next(500);
                int y = random.Next(500);
                LineDrawing(foxDraw, x, y);
            }


        }
        public static void LineDrawing(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(x, y, x + 50, y);
        }
    }
}
// create a line drawing function that takes 2 parameters:
// the x and y coordinates of the line's starting point
// and draws a 50 long horizontal line from that point.
// draw 3 lines with that function.
