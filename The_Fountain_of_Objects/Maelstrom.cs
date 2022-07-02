using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    public class Maelstrom
    {
        internal static (int,int) MaelstromActionsPlayer((int PlayerRow, int PlayerCol) playerTracker, GameBoard<Game.RoomType> TagBoard, GameBoard<string> MoveBoard, Random DiceRoll, bool GameOver, Player GamePlayer)
        {
            bool GoodTarget = false;
            (int RowRng1, int RowRng2, int ColRng1, int ColRng2) Settings = SetBoardRnds(TagBoard);
            {

                    MoveBoard.Map[playerTracker.PlayerRow, playerTracker.PlayerCol] = null;
                    playerTracker.PlayerRow = DiceRoll.Next(Settings.RowRng1, Settings.RowRng2);
                    playerTracker.PlayerCol = DiceRoll.Next(Settings.ColRng1, Settings.ColRng2);
                    MoveBoard.Map[playerTracker.PlayerRow, playerTracker.PlayerCol] = GamePlayer.PlayerName;
                    

                Game.RoomType CheckMap = TagBoard.Map[playerTracker.PlayerRow, playerTracker.PlayerCol];
                if (CheckMap == Game.RoomType.Entry)
                {
                    Console.WriteLine("You find yourself teleported to the cave enterance");
                   // DialogTree.EntranceMessage();
                   // GameOver = GameMenus.EntranceChoice(GameFoutain, Dialog, GameOver, GamePlayer);

                }
                else if (CheckMap == Game.RoomType.Fountain)
                {
                    Console.WriteLine("You find yourself teleported to the foutain room");
                   // DialogTree.FoutainRoom(GameFoutain);
                   // GameMenus.FoutainChoice(GameFoutain, Dialog);
                }

                else if (CheckMap == Game.RoomType.Maelstrom)
                {
                    Console.WriteLine("You find yourself teleported to another Maelstrom...strange, what are the odds");
                   // DialogTree.MaelstromRoom();
                   // Maelstrom.MaelstromActionsMoster(PlayerTracker, TagBoard, DiceRoll);
                    // PlayerTracker = Maelstrom.MaelstromActionsPlayer(PlayerTracker, TagBoard, MoveBoard, DiceRoll, GameOver, GamePlayer);
                }
                else if (CheckMap == Game.RoomType.Amarok)
                {
                    Console.WriteLine("You find yourself teleported into a room with an Amarok");
                    //DialogTree.AmarokRoom( GameOver,GamePlayer);
                }
                else if (CheckMap == Game.RoomType.Pit)
                {
                    Console.WriteLine("You find yourself teleported into a room with a pit trap");
                    //DialogTree.PitRoom(GameOver, GamePlayer);
                }
                else Console.WriteLine("Your very luck, you found yourself teleported into an empty room");
                {

                }
                return playerTracker;
                
                
            }
        }

        internal static void MaelstromActionsMoster((int PlayerRow, int PlayerCol) playerTracker, GameBoard<Game.RoomType> TagBoard, Random DiceRoll)
        {
            int SaveMaelstromRow = playerTracker.PlayerRow;
            int SaveMaelstromCol = playerTracker.PlayerCol;
            int MaelstromRow;
            int MaelstromCol;
            bool GoodTarget = false;

            (int RowRng1, int RowRng2, int ColRng1, int ColRng2) Settings = SetBoardRnds(TagBoard);

            {
                do
                {
                    MaelstromRow = DiceRoll.Next(Settings.RowRng1, Settings.RowRng2);
                    MaelstromCol = DiceRoll.Next(Settings.ColRng1, Settings.ColRng2);
                    if (TagBoard.Map[MaelstromRow, MaelstromCol] == Game.RoomType.Regular) GoodTarget = true;
                } while (GoodTarget == false);
                TagBoard.Map[MaelstromRow, MaelstromCol] = Game.RoomType.Maelstrom;
                TagBoard.Map[SaveMaelstromRow, SaveMaelstromCol] = Game.RoomType.Regular;
            }
        }

        public static (int, int, int, int) SetBoardRnds(GameBoard<Game.RoomType> TagBoard)
        {
            (int row1, int row2, int col1, int col2) targetrnds;

            if (TagBoard.Map.Length == 16) return targetrnds = (0, 3, 0, 3);
            else if (TagBoard.Map.Length == 36) return targetrnds = (0, 5, 0, 5);
            else /*(TagBoard.Map.Length == 64)*/ return targetrnds = (0, 7, 0, 7);
        }
    }
}
