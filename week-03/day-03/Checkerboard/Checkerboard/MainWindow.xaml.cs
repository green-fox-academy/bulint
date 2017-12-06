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

namespace Checkerboard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int size = 50;
            int x1 = 0;
            int y1 = 0;
            int x2 = 50;
            int y2 = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Black(foxDraw, x1, y1, size);
                    White(foxDraw, x2, y2, size);
                    x1 += size * 2;
                    x2 += size * 2;
                }
                x1 = 0;
                x2 = 0;
                y1 += size;
                y2 += size;
                for (int l = 0; l < 5; l++)
                {
                    x1 += size;
                    White(foxDraw, x2, y2, size);
                    Black(foxDraw, x1, y1, size);
                    x1 += size;
                    x2 += size * 2;
                }
                x1 = 0;
                x2 = 50;
                y1 += size;
                y2 += size;
            }
        }
        public static void Black(FoxDraw foxDraw, int x1, int y1, int size)
        {
            foxDraw.FillColor(Colors.Black);
            foxDraw.DrawRectangle(x1, y1, size, size);
        }
        public static void White(FoxDraw foxDraw, int x2, int y2, int size)
        {
            foxDraw.FillColor(Colors.Crimson);
            foxDraw.DrawRectangle(x2, y2, size, size);
        }
    }
}
