
namespace The_Fountain_of_Objects
{
    public class Game
    {
        public void NewGame() 
        {
            
            Random DiceRoll = new Random();
            Menus GameMenus = new Menus();
            
            
           int UserSelection = GameMenus.GameBoardSetupMenu();

            GameBoard<string> MoveBoard = UserSelection switch
            {
                1 => new GameBoard<string>(4, 4),
                2 => new GameBoard<string>(6, 6),
                3 => new GameBoard<string>(8, 8),
            };
            GameBoard<RoomType> TagBoard = UserSelection switch
            {
                1 => new GameBoard<RoomType>(4, 4),
                2 => new GameBoard<RoomType>(6, 6),
                3 => new GameBoard<RoomType>(8, 8),
            };

            GameBoard<RoomType>.TagLocations(TagBoard, DiceRoll);

            string PlayerName = GameMenus.GetPlayerName();
            Player GamePlayer = new Player(PlayerName);
            //var SetTracker= Player.SetPlayerLocation(MoveBoard, GamePlayer);


            //End of set up
            


            //GameLoop
            while (true)
            {
                int UserMove = GameMenus.GetPlayerMove();
                Direction MovePlayer = UserMove switch
                {
                    1 => Direction.North,
                    2 => Direction.South,
                    3 => Direction.East,
                    4 => Direction.West,
                };
                var UpdateTracker = Player.UpdatePlayerLocation(SetTracker.Item1, SetTracker.Item2, MovePlayer, GamePlayer, MoveBoard);
            }


            //Main Testing Area
            Console.WriteLine(MoveBoard.Map.Length);
            Console.WriteLine(TagBoard.Map.Length);
            Console.WriteLine(GamePlayer.PlayerName);
            Console.ReadKey();

            //New Idea Testing Area
            Console.WriteLine("TESTING AREA");
            //var tracker = Player.LocationTracker(NewGame, MoveBoard, GamePlayer);
            Console.WriteLine($"{tracker.Item1}");
            

            Console.ReadKey();

            //End of set up
            

        }
        public enum RoomType { Regular, Fountain, Entry }
        public enum Direction { North, South, East, West}

    }


}
