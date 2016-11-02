using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            int x= 200;
            int y = 200;
            Random rnd = new Random();
            Shapes.Move(eat,x, y);

            Turtle.PenUp();
            while (true)
            {
                Turtle.Move(10);
                if (((Turtle.X >= x) && (Turtle.X <= x+10)) && ((Turtle.Y >= y) && (Turtle.Y <= y+10)))
                {
                    x = rnd.Next(0, GraphicsWindow.Width-10);
                    y = rnd.Next(0, GraphicsWindow.Height-10);
                    Shapes.Move(eat, x, y);           
                }
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up") {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }

        }
    }
}
