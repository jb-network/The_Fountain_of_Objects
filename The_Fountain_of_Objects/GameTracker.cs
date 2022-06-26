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

        internal void UpdatePlayerLocation(Game.Direction SelectedDirection, GameBoard<string> MoveBoard, Player GamePlayer)
        {
            if (SelectedDirection == Game.Direction.North)
            {
                MoveBoard.Map[Row, Col] = null;
                Row = Row;
                Col --;
                MoveBoard.Map[Row, Col] = GamePlayer.PlayerName;
            }
            else if (SelectedDirection == Game.Direction.South)
            {
                MoveBoard.Map[Row, Col] = null;
                Row = Row;
                Col++;
                MoveBoard.Map[Row, Col] = GamePlayer.PlayerName;
            }
            else if (SelectedDirection == Game.Direction.East)
            {
                MoveBoard.Map[Row, Col] = null;
                Col = Col;
                Row++;
                MoveBoard.Map[Row, Col] = GamePlayer.PlayerName;
            }
            else if (SelectedDirection == Game.Direction.West)
            {
                MoveBoard.Map[Row, Col] = null;
                Col = Col;
                Row--;
                MoveBoard.Map[Row, Col] = GamePlayer.PlayerName;
            }

        }
    }
}
