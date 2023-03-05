using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace SimpleGames
{
    public enum LogicState
    {
        Empty=0,
        p1Piece=1,
        p2Piece=2
    }
    class Game
    {
        
        protected bool p1 = true;
        protected bool p2 = false;

        protected int p1Wins = 0;
        protected int p2Wins = 0;

        protected LogicState[,] LogicGrid;

        protected List<DrawableLine> GameGrid = new List<DrawableLine>();

        protected Game()
        {

        }
        public int GetP1Wins()
        {
            return p1Wins;
        }
        public int GetP2Wins()
        {
            return p2Wins;
        }
        public virtual void InitGame(IGraphics g) 
        {

        }
        public virtual void InitLogicGrid() 
        {

        }
        protected virtual void CheckForWinner(Label p1Label, Label p2Label)
        {

        }
        protected virtual void ResetGame(Label p1Label, Label p2Label) 
        {

        }




    }
}
