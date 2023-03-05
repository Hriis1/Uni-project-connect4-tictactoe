using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGames
{
    class DrawableCircle : Shape
    {
        private Point Position { get; set; }
        private int D { get; set; }

        public DrawableCircle(Point pos, int d)
        {
            Position = pos;
            D = d;
        }
        /*public void DrawLine(Point pt1, Point pt2) 
        {

        }*/
        public override void Paint(IGraphics graphics, Color color)
        {
            //Brush brush = new SolidBrush(color);
            //graphics.FillEllipse(brush,Position.X,Position.Y,D,D);

            graphics.DrawCircle(color, Position.X, Position.Y, D);
           
        }
    }
}
