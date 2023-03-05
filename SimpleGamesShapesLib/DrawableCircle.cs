using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGamesShapesLib
{
    class DrawableCircle
    {
        private int XPos { get; set; }
        private int YPos { get; set; }
        private int D { get; set; }

        public DrawableCircle(int x, int y, int d)
        {
            XPos = x;
            YPos = y;
            D = d;
        }
        /*public void DrawLine(Point pt1, Point pt2) 
        {

        }*/
        public void Paint(IGraphics graphics, int alpha, int red, int green, int blue)
        {
            
            //Brush brush = new SolidBrush(color);
            //graphics.FillEllipse(brush,Position.X,Position.Y,D,D);

            graphics.DrawCircle(alpha,red,green,blue, XPos, YPos, D);
           
        }
    }
}
