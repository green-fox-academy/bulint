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
            int xBlack = 0;
            int yBlack = 0;
            int xWhite = size;
            int yWhite = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Black(foxDraw, xBlack, yBlack, size);
                    White(foxDraw, xWhite, yWhite, size);
                    xBlack += size * 2;
                    xWhite += size * 2;
                }
                xBlack = 0;
                xWhite = 0;
                yBlack += size;
                yWhite += size;
                for (int l = 0; l < 5; l++)
                {
                    xBlack += size;
                    White(foxDraw, xWhite, yWhite, size);
                    Black(foxDraw, xBlack, yBlack, size);
                    xBlack += size;
                    xWhite += size * 2;
                }
                xBlack = 0;
                xWhite = size;
                yBlack += size;
                yWhite += size;
            }
        }
        public static void Black(FoxDraw foxDraw, int xBlack, int yBlack, int size)
        {
            foxDraw.FillColor(Colors.Black);
            foxDraw.DrawRectangle(xBlack, yBlack, size, size);
        }
        public static void White(FoxDraw foxDraw, int xWhite, int yWhite, int size)
        {
            foxDraw.FillColor(Colors.Crimson);
            foxDraw.DrawRectangle(xWhite, yWhite, size, size);
        }
    }
}
