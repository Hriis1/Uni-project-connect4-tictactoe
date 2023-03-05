using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGames
{
    public partial class FormTicTacToe : Form, IGraphics
    {
        TicTacToe TicTac = new TicTacToe();
        public int p1Wins = 0;
        public int p2Wins = 0;
        public FormTicTacToe()
        {
            InitializeComponent();
            TicTac.InitLogicGrid();
        }

        public void DrawCircle(Color color, int x, int y, int D)
        {
            using (var graphics = CreateGraphics())
            {
                Brush brush = new SolidBrush(color);
                graphics.FillEllipse(brush, x, y, D, D);
            }
        }
        public void DrawRectangle(Color color, int x, int y, int A)
        {
            using (var graphics = CreateGraphics())
            {
                Brush brush = new SolidBrush(color);
                graphics.FillRectangle(brush, x, y, A, A);
            }
        }
        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            using (var graphics = CreateGraphics())
            {
                Pen p = new Pen(Color.Black);
                graphics.DrawLine(p, new Point(x1, y1), new Point(x2, y2));
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            TicTac.InitGame(this);
            foreach (var item in TicTac.p1Circles)
            {
                item.Paint(this, Color.Red);
            }
            foreach (var item in TicTac.p2Circles)
            {
                item.Paint(this, Color.Blue);
            }

        }

        private void FormTicTacToe_MouseDown(object sender, MouseEventArgs e)
        {
            bool NotInGrid = (e.Location.X < 10 || e.Location.X > 360 || e.Location.Y < 10 || e.Location.Y > 360);
            if (e.Button != MouseButtons.Left || NotInGrid)
            {
                return;
            }
            TicTac.PlayerMove(e, this,label2,label3);
            if (TicTac.GetWinner() == true)
            {
                Invalidate();
                TicTac.ResetWinner();
            }
        }

        private void FormTicTacToe_FormClosing(object sender, FormClosingEventArgs e)
        {
            p1Wins = TicTac.GetP1Wins();
            p2Wins = TicTac.GetP2Wins();
        }
    }
}
