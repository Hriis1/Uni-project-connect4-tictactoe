using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace SimpleGames
{
    class DrawableLine
    {
        private Point Pt1 { get; set; }
        private Point Pt2 { get; set; }

        public DrawableLine(Point pt1, Point pt2)
        {
            Pt1 = pt1;
            Pt2 = pt2;
        }
        public void Paint(IGraphics graphics) 
        {
            //Pen p = new Pen(Color.Black);
            //graphics.DrawLine(p, Pt1, Pt2);
            graphics.DrawLine(Pt1.X, Pt1.Y, Pt2.X, Pt2.Y);
        }

    }
}
