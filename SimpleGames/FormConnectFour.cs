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
    public partial class FormConnectFour : Form, IGraphics
    {
        ConnectFour cn4 = new ConnectFour();
        public int p1Wins = 0;
        public int p2Wins = 0;
        public FormConnectFour()
        {
            InitializeComponent();
            cn4.InitLogicGrid();
            
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
                graphics.DrawLine(p, new Point(x1,y1), new Point(x2,y2));
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            cn4.InitGame(this);
            foreach (var item in cn4.p1Circles)
            {
                item.Paint(this, Color.Red);
            }
            foreach (var item in cn4.p2Circles)
            {
                item.Paint(this, Color.Blue);
            }
        }

        private void FormConnectFour_MouseDown(object sender, MouseEventArgs e)
        {
            bool NotInGrid = (e.Location.X < 10 || e.Location.X > 430 || e.Location.Y < 10 || e.Location.Y > 370);
            if (e.Button != MouseButtons.Left || NotInGrid)
            {
                return;
            }
            
                cn4.PlayerMove(e, this,label2,label3);
                if (cn4.GetWinner() == true)
                {
                    Invalidate();
                    cn4.ResetWinner();
                }
        }
        private void FormConnectFour_FormClosing(object sender, FormClosingEventArgs e)
        {
            p1Wins = cn4.GetP1Wins();
            p2Wins = cn4.GetP2Wins();
        }
    }
}
