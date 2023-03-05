using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGames
{
    public interface IGraphics
    {
        void DrawLine(int x1, int y1, int x2, int y2);
        void DrawCircle(Color color, int x, int y, int D);
        void DrawRectangle(Color color, int x, int y, int A);
    }
}
