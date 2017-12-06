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

namespace PurpleSteps3D
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
            int x = 0;
            int y = 0;
            int size = 50;
            for (int i = 0; i < 9; i++)
            {
                PurpleBoxes(foxDraw, x, y, size);
                x += size;
                y += size;
                size = size + 50;
            }
        }
        public static void PurpleBoxes(FoxDraw foxDraw, int x, int y, int size)
        {
            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}
