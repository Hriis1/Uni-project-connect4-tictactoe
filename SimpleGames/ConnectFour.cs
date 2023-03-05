using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleGames
{
    class ConnectFour : Game
    {
        public List<DrawableCircle> p1Circles = new List<DrawableCircle>();
        public List<DrawableCircle> p2Circles = new List<DrawableCircle>();

        private Color playerColor = Color.Red;

        private int placementCounter = 0;
        private int p1WinCounter = 0;
        private int p2WinCounter = 0;

        private bool winner = false;
        public ConnectFour()
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
        public void PlayerMove(MouseEventArgs e,IGraphics graphics,Label p1Label,Label p2Label)
        {
            
            DrawableCircle circle;
            if(e.Location.X>=10&&e.Location.X<=70)
            {
                if(LogicGrid[5,0]!=LogicState.Empty)
                {
                    return;
                }
                for (int i = 0; i < LogicGrid.GetLength(0); i++)
                {
                    if(LogicGrid[i,0]!=LogicState.Empty)
                    {
                        placementCounter++;
                    }
                    else 
                    {
                        if(p1==true)
                        {
                            LogicGrid[i, 0] = LogicState.p1Piece; 
                        }
                        else 
                        {
                            LogicGrid[i, 0] = LogicState.p2Piece;
                        }
                        break;
                    }
                }
                circle = new DrawableCircle(new Point(15, 315 - (placementCounter * 60)), 50);
                placementCounter = 0;
            }
            else if(e.Location.X > 70 && e.Location.X <= 130)
            {
                if (LogicGrid[5, 1] != LogicState.Empty)
                {
                    return;
                }
                for (int i = 0; i < LogicGrid.GetLength(0); i++)
                {
                    if (LogicGrid[i, 1] != LogicState.Empty)
                    {
                        placementCounter++;
                    }
                    else
                    {
                        if (p1 == true)
                        {
                            LogicGrid[i, 1] = LogicState.p1Piece;
                        }
                        else
                        {
                            LogicGrid[i, 1] = LogicState.p2Piece;
                        }
                        break;
                    }
                }
                circle = new DrawableCircle(new Point(75, 315 - (placementCounter * 60)), 50);
                placementCounter = 0;
            }
            else if(e.Location.X > 130 && e.Location.X <= 190)
            {
                if (LogicGrid[5, 2] != LogicState.Empty)
                {
                    return;
                }
                for (int i = 0; i < LogicGrid.GetLength(0); i++)
                {
                    if (LogicGrid[i, 2] != LogicState.Empty)
                    {
                        placementCounter++;
                    }
                    else
                    {
                        if (p1 == true)
                        {
                            LogicGrid[i, 2] = LogicState.p1Piece;
                        }
                        else
                        {
                            LogicGrid[i, 2] = LogicState.p2Piece;
                        }
                        break;
                    }
                }
                circle = new DrawableCircle(new Point(135, 315 - (placementCounter * 60)), 50);
                placementCounter = 0;
            }
            else if(e.Location.X > 190 && e.Location.X <= 250)
            {
                if (LogicGrid[5, 3] != LogicState.Empty)
                {
                    return;
                }
                for (int i = 0; i < LogicGrid.GetLength(0); i++)
                {
                    if (LogicGrid[i, 3] != LogicState.Empty)
                    {
                        placementCounter++;
                    }
                    else
                    {
                        if (p1 == true)
                        {
                            LogicGrid[i, 3] = LogicState.p1Piece;
                        }
                        else
                        {
                            LogicGrid[i, 3] = LogicState.p2Piece;
                        }
                        break;
                    }
                }
                circle = new DrawableCircle(new Point(195, 315 - (placementCounter * 60)), 50);
                placementCounter = 0;
            }
            else if (e.Location.X > 250 && e.Location.X <= 310)
            {
                if (LogicGrid[5, 4] != LogicState.Empty)
                {
                    return;
                }
                for (int i = 0; i < LogicGrid.GetLength(0); i++)
                {
                    if (LogicGrid[i, 4] != LogicState.Empty)
                    {
                        placementCounter++;
                    }
                    else
                    {
                        if (p1 == true)
                        {
                            LogicGrid[i, 4] = LogicState.p1Piece;
                        }
                        else
                        {
                            LogicGrid[i, 4] = LogicState.p2Piece;
                        }
                        break;
                    }
                }
                circle = new DrawableCircle(new Point(255, 315 - (placementCounter * 60)), 50);
                placementCounter = 0;
            }
            else if(e.Location.X > 310 && e.Location.X <= 375)
            {
                if (LogicGrid[5, 5] != LogicState.Empty)
                {
                    return;
                }
                for (int i = 0; i < LogicGrid.GetLength(0); i++)
                {
                    if (LogicGrid[i, 5] != LogicState.Empty)
                    {
                        placementCounter++;
                    }
                    else
                    {
                        if (p1 == true)
                        {
                            LogicGrid[i, 5] = LogicState.p1Piece;
                        }
                        else
                        {
                            LogicGrid[i, 5] = LogicState.p2Piece;
                        }
                        break;
                    }
                }
                circle = new DrawableCircle(new Point(315, 315 - (placementCounter * 60)), 50);
                placementCounter = 0;
            }
            else
            {
                if (LogicGrid[5, 6] != LogicState.Empty)
                {
                    return;
                }
                for (int i = 0; i < LogicGrid.GetLength(0); i++)
                {
                    if (LogicGrid[i, 6] != LogicState.Empty)
                    {
                        placementCounter++;
                    }
                    else
                    {
                        if (p1 == true)
                        {
                            LogicGrid[i, 6] = LogicState.p1Piece;
                        }
                        else
                        {
                            LogicGrid[i, 6] = LogicState.p2Piece;
                        }
                        break;
                    }
                }
                circle = new DrawableCircle(new Point(375, 315 - (placementCounter * 60)), 50);
                placementCounter = 0;
            }
            if (this.p1 == true)
            {
                this.playerColor = Color.Red;
                this.p1Circles.Add(circle);
                circle.Paint(graphics, this.playerColor);
                this.p1 = false;
                this.p2 = true;

            }
            else
            {
                this.playerColor = Color.Blue;
                this.p2Circles.Add(circle);
                circle.Paint(graphics, this.playerColor);
                this.p2 = false;
                this.p1 = true;
            }
            CheckForWinner(p1Label, p2Label);

        }
        public override void InitGame(IGraphics g)
        {
            DrawableLine ln1 = new DrawableLine(new Point(10, 10), new Point(10, 370));
            DrawableLine ln2 = new DrawableLine(new Point(70, 10), new Point(70, 370));
            DrawableLine ln3 = new DrawableLine(new Point(130, 10), new Point(130, 370));
            DrawableLine ln4 = new DrawableLine(new Point(190, 10), new Point(190, 370));
            DrawableLine ln5 = new DrawableLine(new Point(250, 10), new Point(250, 370));
            DrawableLine ln6 = new DrawableLine(new Point(310, 10), new Point(310, 370));
            DrawableLine ln7 = new DrawableLine(new Point(370, 10), new Point(370, 370));
            DrawableLine ln8 = new DrawableLine(new Point(430, 10), new Point(430, 370));
            


            DrawableLine ln10 = new DrawableLine(new Point(10, 10), new Point(430, 10));
            DrawableLine ln11 = new DrawableLine(new Point(10, 70), new Point(430, 70));
            DrawableLine ln12 = new DrawableLine(new Point(10, 130), new Point(430, 130));
            DrawableLine ln13 = new DrawableLine(new Point(10, 190), new Point(430, 190));
            DrawableLine ln14 = new DrawableLine(new Point(10, 250), new Point(430, 250));
            DrawableLine ln15 = new DrawableLine(new Point(10, 310), new Point(430, 310));
            DrawableLine ln16 = new DrawableLine(new Point(10, 370), new Point(430, 370));
            
            GameGrid.Add(ln1);
            GameGrid.Add(ln2);
            GameGrid.Add(ln3);
            GameGrid.Add(ln4);
            GameGrid.Add(ln5);
            GameGrid.Add(ln6);
            GameGrid.Add(ln7);
            GameGrid.Add(ln8);
           

            GameGrid.Add(ln10);
            GameGrid.Add(ln11);
            GameGrid.Add(ln12);
            GameGrid.Add(ln13);
            GameGrid.Add(ln14);
            GameGrid.Add(ln15);
            GameGrid.Add(ln16);
            
            
            foreach (var item in GameGrid)
            {
                item.Paint(g);
            }


        }
        public override void InitLogicGrid()
        {
            LogicGrid = new LogicState[6, 7];
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
            bool foundWinner = false;


            //---------------------Chcek rows------------------------
            for (int i = 0; i < LogicGrid.GetLength(0); i++)
            {
                for (int j = 0; j < LogicGrid.GetLength(1); j++)
                {
                    if (LogicGrid[i, j] == LogicState.p1Piece)
                    {
                        p1WinCounter++;
                        p2WinCounter = 0;
                    }
                    else if (LogicGrid[i, j] == LogicState.p2Piece)
                    {
                        p2WinCounter++;
                        p1WinCounter = 0;
                    }
                    else if (LogicGrid[i, j] == LogicState.Empty)
                    {
                        p1WinCounter = 0;
                        p2WinCounter = 0;
                    }

                    if (p1WinCounter >= 4)
                    {
                        MessageBox.Show("Player 1 wins!");
                        p1Wins++;
                        break;
                    }
                    else if (p2WinCounter >= 4)
                    {
                        MessageBox.Show("Player 2 wins!");
                        p2Wins++;
                        break;
                    }
                }
                if (p1WinCounter >= 4 || p2WinCounter >= 4)
                {
                    winner = true;
                    foundWinner = true;
                    ResetGame(p1Label,p2Label);
                    break;
                }
                p1WinCounter = 0;
                p2WinCounter = 0;
            }
            if (foundWinner == true)
            {
                return;
            }


            //---------------------Check cows--------------------

            for (int i = 0; i < LogicGrid.GetLength(1); i++)
            {
                for (int j = 0; j < LogicGrid.GetLength(0); j++)
                {
                    if (LogicGrid[j, i] == LogicState.p1Piece)
                    {
                        p1WinCounter++;
                        p2WinCounter = 0;
                    }
                    else if (LogicGrid[j, i] == LogicState.p2Piece)
                    {
                        p2WinCounter++;
                        p1WinCounter = 0;
                    }
                    else if (LogicGrid[j, i] == LogicState.Empty)
                    {
                        p1WinCounter = 0;
                        p2WinCounter = 0;
                    }

                    if (p1WinCounter >= 4)
                    {
                        MessageBox.Show("Player 1 wins!");
                        p1Wins++;
                        break;
                    }
                    else if (p2WinCounter >= 4)
                    {
                        MessageBox.Show("Player 2 wins!");
                        p2Wins++;
                        break;
                    }
                }
                if (p1WinCounter >= 4 || p2WinCounter >= 4)
                {
                    winner = true;
                    foundWinner = true;
                    ResetGame(p1Label, p2Label);
                    break;
                }
                p1WinCounter = 0;
                p2WinCounter = 0;
            }
            if (foundWinner == true)
            {
                return;
            }


            //----------------------------Check diagonals---------------------------
            bool diagonalWin = false;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i + 3 <= LogicGrid.GetLength(0) && j + 3 <= LogicGrid.GetLength(1))
                    {
                        if (LogicGrid[i, j] == LogicState.p1Piece &&
                           LogicGrid[i + 1, j + 1] == LogicState.p1Piece &&
                           LogicGrid[i + 2, j + 2] == LogicState.p1Piece &&
                           LogicGrid[i + 3, j + 3] == LogicState.p1Piece)
                        {
                            diagonalWin = true;
                            MessageBox.Show("Player 1 wins!");
                            p1Wins++;
                            break;
                        }
                        else if (LogicGrid[i, j] == LogicState.p2Piece &&
                           LogicGrid[i + 1, j + 1] == LogicState.p2Piece &&
                           LogicGrid[i + 2, j + 2] == LogicState.p2Piece &&
                           LogicGrid[i + 3, j + 3] == LogicState.p2Piece)
                        {
                            diagonalWin = true;
                            MessageBox.Show("Player 2 wins!");
                            p2Wins++;
                            break;
                        }
                    }
                }

                if (diagonalWin == true)
                {
                    winner = true;
                    foundWinner = true;
                    ResetGame(p1Label, p2Label);
                    break;
                }

            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 6; j >= 0; j--)
                {
                    if (i + 3 <= 7 && j - 3 >= 0)
                    {
                        if (LogicGrid[i, j] == LogicState.p1Piece &&
                           LogicGrid[i + 1, j - 1] == LogicState.p1Piece &&
                           LogicGrid[i + 2, j - 2] == LogicState.p1Piece &&
                           LogicGrid[i + 3, j - 3] == LogicState.p1Piece)
                        {
                            diagonalWin = true;
                            MessageBox.Show("Player 1 wins!");
                            p1Wins++;
                            break;
                        }
                        else if (LogicGrid[i, j] == LogicState.p2Piece &&
                           LogicGrid[i + 1, j - 1] == LogicState.p2Piece &&
                           LogicGrid[i + 2, j - 2] == LogicState.p2Piece &&
                           LogicGrid[i + 3, j - 3] == LogicState.p2Piece)
                        {
                            diagonalWin = true;
                            MessageBox.Show("Player 2 wins!");
                            p2Wins++;
                            break;
                        }
                    }
                }
                if (diagonalWin == true)
                {
                    winner = true;
                    foundWinner = true;
                    ResetGame(p1Label, p2Label);
                    break;
                }
            }
        }
        protected override void ResetGame(Label p1Label,Label p2Label)
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
            p2Label.Text= "P2 wins: " + p2Wins;

        }

        
    }
    
}
