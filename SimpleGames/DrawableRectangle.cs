using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGames
{
    class DrawableRectangle :Shape
    {
        private Point Position { get; set; }
        private int A { get; set; }

        public DrawableRectangle(Point pos, int a)
        {
            Position = pos;
            A = a;
        }
        public override void Paint(IGraphics graphics, Color color)
        {
            //Brush brush = new SolidBrush(color);
            //graphics.FillEllipse(brush,Position.X,Position.Y,D,D);

            graphics.DrawRectangle(color, Position.X, Position.Y, A);

        }
    }
}
