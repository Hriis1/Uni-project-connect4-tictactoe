using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleGames
{
    class TicTacToe : Game
    {
        public List<Shape> p1Circles = new List<Shape>();
        public List<Shape> p2Circles = new List<Shape>();
        private Color playerColor = Color.Red;

        private int placementCounter = 0;
        private int p1WinCounter = 0;
        private int p2WinCounter = 0;

        private bool winner = false;
        public TicTacToe()
        {

        }
        public bool GetWinner()
        {
            return winner;
        }
        public void ResetWinner()
        {
            winner = false;
        }
        public void PlayerMove(MouseEventArgs e, IGraphics graphics, Label p1Label, Label p2Label) 
        {
            Shape shape;
            if (e.Location.X>10 && e.Location.X <= 120)
            {
                if(e.Location.Y>10 && e.Location.Y<=120)
                {
                    if(LogicGrid[0,0]==LogicState.Empty)
                    {
                        shape = new DrawableCircle(new Point(25,25), 80);
                        if (p1 == true)
                        {
                            LogicGrid[0, 0] = LogicState.p1Piece;
                            this.playerColor = Color.Red;
                            this.p1Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p1 = false;
                            this.p2 = true;
                        }
                        else
                        {
                            shape = new DrawableRectangle(new Point(25, 25), 80);
                            LogicGrid[0, 0] = LogicState.p2Piece;
                            this.playerColor = Color.Blue;
                            this.p2Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p2 = false;
                            this.p1 = true;
                        }
                    }
                }
                else if (e.Location.Y > 120 && e.Location.Y <= 240)
                {
                    if (LogicGrid[1, 0] == LogicState.Empty)
                    {
                        shape = new DrawableCircle(new Point(25, 145), 80);
                        if (p1 == true)
                        {
                            LogicGrid[1, 0] = LogicState.p1Piece;
                            this.playerColor = Color.Red;
                            this.p1Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p1 = false;
                            this.p2 = true;
                        }
                        else
                        {
                            shape = new DrawableRectangle(new Point(25, 145), 80);
                            LogicGrid[1, 0] = LogicState.p2Piece;
                            this.playerColor = Color.Blue;
                            this.p2Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p2 = false;
                            this.p1 = true;
                        }
                    }
                }
                else if (e.Location.Y > 240 && e.Location.Y <= 360)
                {
                    if (LogicGrid[2, 0] == LogicState.Empty)
                    {
                        shape = new DrawableCircle(new Point(25, 265), 80);
                        if (p1 == true)
                        {
                            LogicGrid[2, 0] = LogicState.p1Piece;
                            this.playerColor = Color.Red;
                            this.p1Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p1 = false;
                            this.p2 = true;
                        }
                        else
                        {
                            shape = new DrawableRectangle(new Point(25, 265), 80);
                            LogicGrid[2, 0] = LogicState.p2Piece;
                            this.playerColor = Color.Blue;
                            this.p2Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p2 = false;
                            this.p1 = true;
                        }
                    }
                }
            }
            else if(e.Location.X > 120 && e.Location.X <= 240)
            {
                if (e.Location.Y > 10 && e.Location.Y <= 120)
                {
                    if (LogicGrid[0, 1] == LogicState.Empty)
                    {
                        shape = new DrawableCircle(new Point(145, 25), 80);
                        if (p1 == true)
                        {
                            LogicGrid[0, 1] = LogicState.p1Piece;
                            this.playerColor = Color.Red;
                            this.p1Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p1 = false;
                            this.p2 = true;
                        }
                        else
                        {
                            shape = new DrawableRectangle(new Point(145, 25), 80);
                            LogicGrid[0, 1] = LogicState.p2Piece;
                            this.playerColor = Color.Blue;
                            this.p2Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p2 = false;
                            this.p1 = true;
                        }
                    }
                }
                else if (e.Location.Y > 120 && e.Location.Y <= 240)
                {
                    if (LogicGrid[1, 1] == LogicState.Empty)
                    {
                        shape = new DrawableCircle(new Point(145, 145), 80);
                        if (p1 == true)
                        {
                            LogicGrid[1, 1] = LogicState.p1Piece;
                            this.playerColor = Color.Red;
                            this.p1Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p1 = false;
                            this.p2 = true;
                        }
                        else
                        {
                            shape = new DrawableRectangle(new Point(145, 145), 80);
                            LogicGrid[1, 1] = LogicState.p2Piece;
                            this.playerColor = Color.Blue;
                            this.p2Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p2 = false;
                            this.p1 = true;
                        }
                    }
                }
                else if (e.Location.Y > 240 && e.Location.Y <= 360)
                {
                    if (LogicGrid[2, 1] == LogicState.Empty)
                    {
                        shape = new DrawableCircle(new Point(145, 265), 80);
                        if (p1 == true)
                        {
                            LogicGrid[2, 1] = LogicState.p1Piece;
                            this.playerColor = Color.Red;
                            this.p1Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p1 = false;
                            this.p2 = true;
                        }
                        else
                        {
                            shape = new DrawableRectangle(new Point(145, 265), 80);
                            LogicGrid[2, 1] = LogicState.p2Piece;
                            this.playerColor = Color.Blue;
                            this.p2Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p2 = false;
                            this.p1 = true;
                        }
                    }
                }
            }
            else if (e.Location.X > 240 && e.Location.X <= 360)
            {
                if (e.Location.Y > 10 && e.Location.Y <= 120)
                {
                    if (LogicGrid[0, 2] == LogicState.Empty)
                    {
                        shape = new DrawableCircle(new Point(265, 25), 80);
                        if (p1 == true)
                        {
                            LogicGrid[0, 2] = LogicState.p1Piece;
                            this.playerColor = Color.Red;
                            this.p1Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p1 = false;
                            this.p2 = true;
                        }
                        else
                        {
                            shape = new DrawableRectangle(new Point(265, 25), 80);
                            LogicGrid[0, 2] = LogicState.p2Piece;
                            this.playerColor = Color.Blue;
                            this.p2Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p2 = false;
                            this.p1 = true;
                        }
                    }
                }
                else if (e.Location.Y > 120 && e.Location.Y <= 240)
                {
                    if (LogicGrid[1, 2] == LogicState.Empty)
                    {
                        
                        
                            shape = new DrawableCircle(new Point(265, 145), 80);
                            if (p1 == true)
                            {
                                LogicGrid[1, 2] = LogicState.p1Piece;
                                this.playerColor = Color.Red;
                                this.p1Circles.Add(shape);
                                shape.Paint(graphics, this.playerColor);
                                this.p1 = false;
                                this.p2 = true;
                            }
                            else
                            {
                            shape = new DrawableRectangle(new Point(265, 145), 80);
                            LogicGrid[1, 2] = LogicState.p2Piece;
                            this.playerColor = Color.Blue;
                            this.p2Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p2 = false;
                            this.p1 = true;
                        }
                        
                    }
                }
                else if (e.Location.Y > 240 && e.Location.Y <= 360)
                {
                    if (LogicGrid[2, 2] == LogicState.Empty)
                    {
                            shape = new DrawableCircle(new Point(265, 265), 80);
                            if (p1 == true)
                            {
                                LogicGrid[2, 2] = LogicState.p1Piece;
                                this.playerColor = Color.Red;
                                this.p1Circles.Add(shape);
                                shape.Paint(graphics, this.playerColor);
                                this.p1 = false;
                                this.p2 = true;
                            }
                            else
                            {
                            shape = new DrawableRectangle(new Point(265, 265), 80);
                            LogicGrid[2, 2] = LogicState.p2Piece;
                            this.playerColor = Color.Blue;
                            this.p2Circles.Add(shape);
                            shape.Paint(graphics, this.playerColor);
                            this.p2 = false;
                            this.p1 = true;
                        }
                    }
                }
            }

            CheckForWinner(p1Label, p2Label);
        }
        public override void InitGame(IGraphics g)
        {
            DrawableLine ln1 = new DrawableLine(new Point(10, 10), new Point(10, 360));
            DrawableLine ln2 = new DrawableLine(new Point(120, 10), new Point(120, 360));
            DrawableLine ln3 = new DrawableLine(new Point(240, 10), new Point(240, 360));
            DrawableLine ln4 = new DrawableLine(new Point(360, 10), new Point(360, 360));

            DrawableLine ln5 = new DrawableLine(new Point(10, 10), new Point(360, 10));
            DrawableLine ln6 = new DrawableLine(new Point(10, 120), new Point(360, 120));
            DrawableLine ln7 = new DrawableLine(new Point(10, 240), new Point(360, 240));
            DrawableLine ln8 = new DrawableLine(new Point(10, 360), new Point(360, 360));

            GameGrid.Add(ln1);
            GameGrid.Add(ln2);
            GameGrid.Add(ln3);
            GameGrid.Add(ln4);

            GameGrid.Add(ln5);
            GameGrid.Add(ln6);
            GameGrid.Add(ln7);
            GameGrid.Add(ln8);

            foreach (var item in GameGrid)
            {
                item.Paint(g);
            }
        }
        public override void InitLogicGrid()
        {
            LogicGrid = new LogicState[3, 3];
            for (int i = 0; i < LogicGrid.GetLength(0); i++)
            {
                for (int j = 0; j < LogicGrid.GetLength(1); j++)
                {
                    LogicGrid[i, j] = LogicState.Empty;
                }
            }

        }
        protected override void CheckForWinner(Label p1Label, Label p2Label)
        {
           
            //---------------------Chcek rows------------------------
            if(LogicGrid[0,0]==LogicGrid[0,1] && LogicGrid[0,0]==LogicGrid[0,2])
            {
                if(LogicGrid[0,0]==LogicState.p1Piece)
                {
                    MessageBox.Show("Player 1 wins!");
                    p1Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
                else if(LogicGrid[0, 0] == LogicState.p2Piece)
                {
                    MessageBox.Show("Player 2 wins!");
                    p2Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
            }
            if (LogicGrid[1, 0] == LogicGrid[1, 1] && LogicGrid[1, 0] == LogicGrid[1, 2])
            {
                if (LogicGrid[1, 0] == LogicState.p1Piece)
                {
                    MessageBox.Show("Player 1 wins!");
                    p1Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
                else if (LogicGrid[1, 0] == LogicState.p2Piece)
                {
                    MessageBox.Show("Player 2 wins!");
                    p2Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
            }
            if (LogicGrid[2, 0] == LogicGrid[2, 1] && LogicGrid[2, 0] == LogicGrid[2, 2])
            {
                if (LogicGrid[2, 0] == LogicState.p1Piece)
                {
                    MessageBox.Show("Player 1 wins!");
                    p1Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
                else if (LogicGrid[2, 0] == LogicState.p2Piece)
                {
                    MessageBox.Show("Player 2 wins!");
                    p2Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
            }


            //---------------------Chcek cows------------------------
            if (LogicGrid[0, 0] == LogicGrid[1, 0] && LogicGrid[0, 0] == LogicGrid[2, 0])
            {
                if (LogicGrid[0, 0] == LogicState.p1Piece)
                {
                    MessageBox.Show("Player 1 wins!");
                    p1Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
                else if (LogicGrid[0, 0] == LogicState.p2Piece)
                {
                    MessageBox.Show("Player 2 wins!");
                    p2Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
            }
            if (LogicGrid[0, 1] == LogicGrid[1, 1] && LogicGrid[0, 1] == LogicGrid[2, 1])
            {
                if (LogicGrid[0, 1] == LogicState.p1Piece)
                {
                    MessageBox.Show("Player 1 wins!");
                    p1Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
                else if (LogicGrid[0, 1] == LogicState.p2Piece)
                {
                    MessageBox.Show("Player 2 wins!");
                    p2Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
            }
            if (LogicGrid[0, 2] == LogicGrid[1, 2] && LogicGrid[0, 2] == LogicGrid[2, 2])
            {
                if (LogicGrid[0, 2] == LogicState.p1Piece)
                {
                    MessageBox.Show("Player 1 wins!");
                    p1Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
                else if (LogicGrid[0, 2] == LogicState.p2Piece)
                {
                    MessageBox.Show("Player 2 wins!");
                    p2Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
            }


            //---------------------Chcek diagonals------------------------
            if (LogicGrid[0, 0] == LogicGrid[1, 1] && LogicGrid[0, 0] == LogicGrid[2, 2])
            {
                if (LogicGrid[0, 0] == LogicState.p1Piece)
                {
                    MessageBox.Show("Player 1 wins!");
                    p1Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
                else if (LogicGrid[0, 0] == LogicState.p2Piece)
                {
                    MessageBox.Show("Player 2 wins!");
                    p2Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
            }
            if (LogicGrid[0, 2] == LogicGrid[1, 1] && LogicGrid[0, 2] == LogicGrid[2, 0])
            {
                if (LogicGrid[0, 2] == LogicState.p1Piece)
                {
                    MessageBox.Show("Player 1 wins!");
                    p1Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
                else if (LogicGrid[0, 2] == LogicState.p2Piece)
                {
                    MessageBox.Show("Player 2 wins!");
                    p2Wins++;
                    winner = true;
                    ResetGame(p1Label, p2Label);
                    return;
                }
            }

            if(p1Circles.Count+p2Circles.Count>=9)
            {
                MessageBox.Show("Tie!");
                winner = true;
                ResetGame(p1Label, p2Label);
                return;
            }
        }
        protected override void ResetGame(Label p1Label, Label p2Label)
        {
            for (int i = 0; i < LogicGrid.GetLength(0); i++)
            {
                for (int j = 0; j < LogicGrid.GetLength(1); j++)
                {
                    LogicGrid[i, j] = LogicState.Empty;
                }
            }
            p1Circles.RemoveRange(0, p1Circles.Count);
            p2Circles.RemoveRange(0, p2Circles.Count);
            p1 = true;
            p2 = false;
            p1WinCounter = 0;
            p2WinCounter = 0;
            p1Label.Text = "P1 wins: " + p1Wins;
            p2Label.Text = "P2 wins: " + p2Wins;

        }
    }
}
