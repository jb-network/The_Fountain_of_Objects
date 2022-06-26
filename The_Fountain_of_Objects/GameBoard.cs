
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
        public static void TagLocations(GameBoard<Game.RoomType> TagBoard, Random DiceRoll)
        {            
            for (int Row = 0; Row < TagBoard.Map.GetLength(0); Row++)
            {
                for (int Col = 0; Col < TagBoard.Map.GetLength(1); Col++)
                {
                    TagBoard.Map[Row, Col] = Game.RoomType.Regular;
                }
            }
            TagBoard.Map[0, 0] = Game.RoomType.Entry;

            if (TagBoard.Map.Length == 16)
            {
                int RndRow = DiceRoll.Next(2, 3);
                int RndCol = DiceRoll.Next(2, 3);
                TagBoard.Map[RndRow, RndCol] = Game.RoomType.Fountain;
            }
            else if (TagBoard.Map.Length == 36)
            {
                int RndRow = DiceRoll.Next(2, 5);
                int RndCol = DiceRoll.Next(2, 5);
                TagBoard.Map[RndRow, RndCol] = Game.RoomType.Fountain;
            }
            else
            {
                int RndRow = DiceRoll.Next(2, 7);
                int RndCol = DiceRoll.Next(2, 7);
                TagBoard.Map[RndRow, RndCol] = Game.RoomType.Fountain;
            }
        }

        internal Game.RoomType CheckRoomType(GameBoard<Game.RoomType> tagBoard, (int PlayerRow, int PlayerCol) playerTracker)
        {
            if (tagBoard.Map[playerTracker.PlayerRow, playerTracker.PlayerCol] == Game.RoomType.Entry)
            {
                
                return Game.RoomType.Entry;

            }
            else return Game.RoomType.Regular; //REMOVE
        }
    }
}
