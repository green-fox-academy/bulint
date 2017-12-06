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

namespace MiddleLines
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
            DrawGreenLines(foxDraw);
        }
        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.DarkSalmon);
            foxDraw.DrawLine(0, 175, 700, 175);

            var startPoint = new Point(350, 0);
            var endPoint = new Point(350, 350);
            foxDraw.StrokeColor(Colors.LawnGreen);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
//  draw a red horizontal line to the canvas' middle.
//  draw a green vertical line to the canvas' middle.