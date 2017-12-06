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

namespace RainbowBoxes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Random random = new Random();
            double size = canvas.Width;
            for (double i = 0; i < 125; i++)
            {
                Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
                foxDraw.FillColor(randomColor);
                SquareDrawing(foxDraw, size);
                size = size - 4;
            }
        }
        public static void SquareDrawing(FoxDraw foxDraw, double size)
        {
            double x = (500 - size) / 2;
            foxDraw.DrawRectangle(x, x, size, size);
        }
    }
}