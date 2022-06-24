
namespace The_Fountain_of_Objects
{
    public class Game
    {
        public void NewGame() 
        { 
            Random DiceRoll = new Random();
            Menus GameMenus = new Menus();
            
           int UserSelection = GameMenus.GameBoardSetupMenu();

            GameBoard<int> MoveBoard = UserSelection switch
            {
                1 => new GameBoard<int>(4, 4),
                2 => new GameBoard<int>(6, 6),
                3 => new GameBoard<int>(8, 8),
            };
            GameBoard<RoomType> TagBoard = UserSelection switch
            {
                1 => new GameBoard<RoomType>(4, 4),
                2 => new GameBoard<RoomType>(6, 6),
                3 => new GameBoard<RoomType>(8, 8),
            };

            GameBoard<RoomType>.TagLocations(TagBoard, DiceRoll);


            Console.WriteLine(MoveBoard.Map.Length);
            Console.WriteLine(TagBoard.Map.Length);
            Console.ReadKey();
        }
        public enum RoomType { Regular, Fountain, Entry }

    }


}
