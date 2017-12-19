using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GreenFox
{
    public class FoxDraw
    {
        public const int TileSize = 50;

        private Canvas Canvas { get; set; }

        public FoxDraw(Canvas canvas)
        {
            Canvas = canvas;
        }

        public void AddImage(string source, double x, double y)
        {
            var image = new Image()
            {
                Width = TileSize,
                Height = TileSize,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }

        public void AddImage(Canvas canvas, double x, double y)
        {
            Canvas.Children.Add(canvas);
            SetPosition(canvas, x, y);
        }

        public void SetPosition(UIElement uIElement, double x, double y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }
    }
}