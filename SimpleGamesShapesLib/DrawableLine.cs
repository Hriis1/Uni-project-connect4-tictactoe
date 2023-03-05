using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleGamesShapesLib
{
    class DrawableLine
    {
       
        private int X1 { get; set; }
        private int Y1 { get; set; }
        private int X2 { get; set; }
        private int Y2 { get; set; }

        

        public DrawableLine(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        public void Paint(IGraphics graphics) 
        {
            //Pen p = new Pen(Color.Black);
            //graphics.DrawLine(p, Pt1, Pt2);
            graphics.DrawLine(X1,Y1,X2,Y2);
        }

    }
}
