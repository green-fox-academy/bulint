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

namespace FillWithRectangles
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
            DrawRectangle(foxDraw);
        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Aquamarine);
            foxDraw.FillColor(Colors.Aquamarine);
            foxDraw.DrawRectangle(15, 15, 15, 15);
            foxDraw.StrokeColor(Colors.Chocolate);
            foxDraw.FillColor(Colors.Chocolate);
            foxDraw.DrawRectangle(55, 55, 55, 55);
            foxDraw.StrokeColor(Colors.DarkRed);
            foxDraw.FillColor(Colors.DarkRed);
            foxDraw.DrawRectangle(100, 100, 100, 100);
            foxDraw.StrokeColor(Colors.Goldenrod);
            foxDraw.FillColor(Colors.Goldenrod);
            foxDraw.DrawRectangle(200, 200, 50, 50);
        }
    }
}
