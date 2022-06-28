
namespace The_Fountain_of_Objects
{
    public class GameBoard<TSetBoard>
    {
        public int Rows { get; }
        public int Columns { get; }
        public TSetBoard[,] Map;

        public GameBoard(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Map = new TSetBoard[rows, columns];
        }
        //Tags Rooms
        public static void TagLocations(GameBoard<Game.RoomType> TagBoard, Game.RoomType BoardRoomType, Random DiceRoll)
        {
            if (BoardRoomType == Game.RoomType.Entry)
            {
                int row = 0;
                int col = 0;
                TagBoard.Map[row, col] = Game.RoomType.Entry;
            }
            else if (BoardRoomType == Game.RoomType.Fountain)
            {
                int row = 0;
                int col = 0;
                bool GoodTarget = false;
                (int RowRng1, int RowRng2, int ColRng1, int ColRng2, int Multiple) Settings = SetBoardRnds(TagBoard, BoardRoomType);

                do
                {
                    row = DiceRoll.Next(Settings.RowRng1, Settings.RowRng2);
                    col = DiceRoll.Next(Settings.ColRng1, Settings.ColRng2);
                    if (TagBoard.Map[row, col] == Game.RoomType.Regular) GoodTarget = true;
                } while (GoodTarget == false);
                TagBoard.Map[row, col] = Game.RoomType.Fountain;
            }
            else if (BoardRoomType == Game.RoomType.Pit)
            {
                int row = 0;
                int col = 0;
                bool GoodTarget = false;
                (int RowRng1, int RowRng2, int ColRng1, int ColRng2, int Multiple) Settings = SetBoardRnds(TagBoard, BoardRoomType);
                for (int i = 0; i < Settings.Multiple; i++)
                {
                    do
                    {
                        row = DiceRoll.Next(Settings.RowRng1, Settings.RowRng2);
                        col = DiceRoll.Next(Settings.ColRng1, Settings.ColRng2);
                        if (TagBoard.Map[row, col] == Game.RoomType.Regular) GoodTarget = true;
                    } while (GoodTarget == false);
                    TagBoard.Map[row, col] = Game.RoomType.Pit;
                }
            }
            else if (BoardRoomType == Game.RoomType.Maelstrom)
            {
                int row = 0;
                int col = 0;
                bool GoodTarget = false;
                (int RowRng1, int RowRng2, int ColRng1, int ColRng2, int Multiple) Settings = SetBoardRnds(TagBoard, BoardRoomType);
                for (int i = 0; i < Settings.Multiple; i++)
                {
                    do
                    {
                        row = DiceRoll.Next(Settings.RowRng1, Settings.RowRng2);
                        col = DiceRoll.Next(Settings.ColRng1, Settings.ColRng2);
                        if (TagBoard.Map[row, col] == Game.RoomType.Regular) GoodTarget = true;
                    } while (GoodTarget == false);
                    TagBoard.Map[row, col] = Game.RoomType.Maelstrom;
                }
            }
            else if (BoardRoomType == Game.RoomType.Amarok)
            {
                int row = 0;
                int col = 0;
                bool GoodTarget = false;
                (int RowRng1, int RowRng2, int ColRng1, int ColRng2, int Multiple) Settings = SetBoardRnds(TagBoard, BoardRoomType);
                for (int i = 0; i < Settings.Multiple; i++)
                {
                    do
                    {
                        row = DiceRoll.Next(Settings.RowRng1, Settings.RowRng2);
                        col = DiceRoll.Next(Settings.ColRng1, Settings.ColRng2);
                        if (TagBoard.Map[row, col] == Game.RoomType.Regular) GoodTarget = true;
                    } while (GoodTarget == false);

                    TagBoard.Map[row, col] = Game.RoomType.Amarok;
                }
            }
            else {/*not needed at this time*/ }
        }

        //set number of items in map based on room type
        public static (int, int, int, int, int) SetBoardRnds(GameBoard<Game.RoomType> TagBoard, Game.RoomType RoomType)
        {
            (int row1, int row2, int col1, int col2, int Multiple) targetrnds;

            if (TagBoard.Map.Length == 16)
            {
                if (RoomType == Game.RoomType.Fountain) return targetrnds = (1, 2, 2, 3, 1);
                else if (RoomType == Game.RoomType.Pit) return targetrnds = (0, 3, 0, 3, 1);
                else if (RoomType == Game.RoomType.Maelstrom) return targetrnds = (0, 3, 0, 3, 1);
                else return targetrnds = (0, 3, 0, 3, 1); //amarok
            }
            else if (TagBoard.Map.Length == 36)
            {
                if (RoomType == Game.RoomType.Fountain) return targetrnds = (1, 4, 2, 4, 1);
                else if (RoomType == Game.RoomType.Pit) return targetrnds = (0, 5, 0, 5, 2);
                else if (RoomType == Game.RoomType.Maelstrom) return targetrnds = (0, 5, 0, 5, 1);
                else return targetrnds = (0, 5, 0, 5, 2); //amarok
            }
            else if (TagBoard.Map.Length == 64)
            {
                if (RoomType == Game.RoomType.Fountain) return targetrnds = (1, 6, 2, 6, 1);
                else if (RoomType == Game.RoomType.Pit) return targetrnds = (0, 7, 0, 7, 4);
                else if (RoomType == Game.RoomType.Maelstrom) return targetrnds = (0, 7, 0, 7, 2);
                else return targetrnds = (0, 7, 0, 7, 3); //amarok
            }
            else return targetrnds = (0, 0, 0, 0, 0); //FailSafe
        }
        internal Game.RoomType CheckRoomType(GameBoard<Game.RoomType> tagBoard, (int PlayerRow, int PlayerCol) playerTracker)
        {
            if (tagBoard.Map[playerTracker.PlayerRow, playerTracker.PlayerCol] == Game.RoomType.Entry)
            {

                return Game.RoomType.Entry;

            }
            else if (tagBoard.Map[playerTracker.PlayerRow, playerTracker.PlayerCol] == Game.RoomType.Fountain)
            {
                return Game.RoomType.Fountain;
            }

            else return Game.RoomType.Regular; //REMOVE
        }
    }
            
}
