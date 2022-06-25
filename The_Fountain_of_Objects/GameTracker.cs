using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    public class GameTracker
    {
        int Row;
        int Col;
        string Player;

        public GameTracker(int row, int col, Player GamePlayer, GameBoard<string> MoveBoard)
        {
            Row = row;
            Col = col;
            Player = GamePlayer.PlayerName;
            MoveBoard.Map[Row, Col] = Player;
        }
    }
}
