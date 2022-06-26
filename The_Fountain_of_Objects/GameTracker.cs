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
        (int PlayerRow, int PlayerCol) PlayerTracker;

        public GameTracker(int row, int col, Player GamePlayer, GameBoard<string> MoveBoard, (int, int) playerTracker)
        {
            Row = row;
            Col = col;
            Player = GamePlayer.PlayerName;
            MoveBoard.Map[Row, Col] = Player;
            PlayerTracker = playerTracker;
        }

        internal (int,int) UpdatePlayerLocation(Game.Direction SelectedDirection, GameBoard<string> MoveBoard, Player GamePlayer)
        {
            if (SelectedDirection == Game.Direction.North)
            {
                MoveBoard.Map[Row, Col] = null;
                Row = Row;
                Col --;
                MoveBoard.Map[Row, Col] = GamePlayer.PlayerName;
                PlayerTracker.PlayerRow = Row;
                PlayerTracker.PlayerCol = Col;
                return PlayerTracker;
            }
            else if (SelectedDirection == Game.Direction.South)
            {
                MoveBoard.Map[Row, Col] = null;
                Row = Row;
                Col++;
                MoveBoard.Map[Row, Col] = GamePlayer.PlayerName;
                PlayerTracker.PlayerRow = Row;
                PlayerTracker.PlayerCol = Col;
                return PlayerTracker;
            }
            else if (SelectedDirection == Game.Direction.East)
            {
                MoveBoard.Map[Row, Col] = null;
                Col = Col;
                Row++;
                MoveBoard.Map[Row, Col] = GamePlayer.PlayerName;
                PlayerTracker.PlayerRow = Row;
                PlayerTracker.PlayerCol = Col;
                return PlayerTracker;
            }
            else //West
            {
                MoveBoard.Map[Row, Col] = null;
                Col = Col;
                Row--;
                MoveBoard.Map[Row, Col] = GamePlayer.PlayerName;
                PlayerTracker.PlayerRow = Row;
                PlayerTracker.PlayerCol = Col;
                return PlayerTracker;
            }

        }
        internal bool LegalMoveCheck(Game.Direction SelectedDirection, (int PlayerRow, int PlayerCol) playerTracker, GameBoard<string> MoveBoard, DialogTree Dialog)
        {

            if (SelectedDirection == Game.Direction.North && PlayerTracker.PlayerRow == 0)
            {
                Dialog.WallMessage();
                return false;
            }
            else if (SelectedDirection == Game.Direction.West && PlayerTracker.PlayerCol == 0)
            {
                Dialog.WallMessage();
                return false;
            }
            else if (SelectedDirection == Game.Direction.South && PlayerTracker.PlayerCol == MoveBoard.Map.GetLength(1)-1)
            {
                Dialog.WallMessage();
                return false;
            }
            else if (SelectedDirection == Game.Direction.East && PlayerTracker.PlayerRow == MoveBoard.Map.GetLength(0)-1)
            {
                Dialog.WallMessage();
                return false;
            }
            else return true;
        }
    }
}
