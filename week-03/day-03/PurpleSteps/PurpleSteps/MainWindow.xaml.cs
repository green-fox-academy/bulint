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

namespace PurpleSteps
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
            for (int i = 0; i < 11; i++)
            {
                PurpleBoxes(foxDraw, size, x, y);
                x += size;
                y += size;
            }
        }
        public static void PurpleBoxes(FoxDraw foxDraw, int size, int x, int y)
        {
            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}
