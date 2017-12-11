using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt
{
    class Program
    {
        struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;
        }

        static void Main(string[] args)
        {
            PostIt PostIt1;
            PostIt PostIt2;
            PostIt PostIt3;

            PostIt1.BackgroundColor = "Orange";
            PostIt1.Text = "Idea 1";
            PostIt1.TextColor = "Blue";

            PostIt2.BackgroundColor = "Pink";
            PostIt2.Text = "Awesome";
            PostIt2.TextColor = "Black";

            PostIt3.BackgroundColor = "Yellow";
            PostIt3.Text = "Superb!";
            PostIt3.TextColor = "Green";
        }
    }
}
