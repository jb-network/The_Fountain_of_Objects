
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
                int FoutainRndRow = DiceRoll.Next(2, 3); 
                int FoutainRndCol = DiceRoll.Next(2, 3);
                TagBoard.Map[FoutainRndRow, FoutainRndCol] = Game.RoomType.Fountain;
            }
            else if (TagBoard.Map.Length == 36)
            {
                int FoutainRndRow = DiceRoll.Next(2, 5);
                int FoutainRndCol = DiceRoll.Next(2, 5);
                TagBoard.Map[FoutainRndRow, FoutainRndCol] = Game.RoomType.Fountain;
            }
            else
            {
                int FoutainRndRow = DiceRoll.Next(2, 7);
                int FoutainRndCol = DiceRoll.Next(2, 7);
                TagBoard.Map[FoutainRndRow, FoutainRndCol] = Game.RoomType.Fountain;
            }
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
