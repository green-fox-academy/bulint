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

namespace ColoredBox
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
            DrawColoredBox(foxDraw);
        }
        public static void DrawColoredBox(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(50, 50, 50, 150);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(50, 50, 150, 50);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(150, 150, 50, 150);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(150, 150, 150, 50);
        }
    }
}
// draw a box that has different colored lines on each edge.
