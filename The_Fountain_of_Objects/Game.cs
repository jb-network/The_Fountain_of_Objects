
namespace The_Fountain_of_Objects
{
    public class Game
    {
        public void NewGame() 
        {
            //Random object for program use
            Random DiceRoll = new Random();
            
            //Menu object created
            Menus GameMenus = new Menus();
            
            //Menu to get user input for the size of the board
            int UserSelection = GameMenus.GameBoardSetupMenu();
            
            //Build an array to track the players location on the board
            GameBoard<string> MoveBoard = UserSelection switch
            {
                1 => new GameBoard<string>(4, 4),
                2 => new GameBoard<string>(6, 6),
                3 => new GameBoard<string>(8, 8),
            };
            // An array to tag rooms layered on top of Moveboard
            GameBoard<RoomType> TagBoard = UserSelection switch
            {
                1 => new GameBoard<RoomType>(4, 4),
                2 => new GameBoard<RoomType>(6, 6),
                3 => new GameBoard<RoomType>(8, 8),
            };

            //intalize roomtype tags to array elements 
            GameBoard<RoomType>.TagLocations(TagBoard, DiceRoll);

            //Menu to get user name from the Player
            string PlayerName = GameMenus.GetPlayerName();

            //Build Player object
            Player GamePlayer = new Player(PlayerName);

            //Build Tracker object, intialize to location 0,0
            GameTracker Tracker = new GameTracker(0, 0, GamePlayer, MoveBoard);


            //End of set up

            //GameLoop - test movment loop
            int x = 3;
            while (x > 0)
            {
                Direction SelectedDirection = GameMenus.GetPlayerMove();
                Console.WriteLine(SelectedDirection);
                Tracker.UpdatePlayerLocation(SelectedDirection, MoveBoard, GamePlayer);
                x--;
            }


            //Main Testing Area
            Console.WriteLine(MoveBoard.Map.Length);
            Console.WriteLine(TagBoard.Map.Length);
            Console.WriteLine(GamePlayer.PlayerName);
            Console.ReadKey();

            //New Idea Testing Area
            Console.WriteLine("TESTING AREA");

            

            
            
            //End of set up
            

        }
        public enum RoomType { Regular, Fountain, Entry }
        public enum Direction { North, South, East, West}

    }


}
