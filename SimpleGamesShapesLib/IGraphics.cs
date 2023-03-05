using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGamesShapesLib
{
    public interface IGraphics
    {
        void DrawLine(int x1, int y1, int x2, int y2);
        void DrawCircle(int alpha, int red, int green, int blue, int x, int y, int D);
    }
}
