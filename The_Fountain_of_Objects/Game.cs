
namespace The_Fountain_of_Objects
{
    public class Game
    {
        public void NewGame() 
        {
            //Var List
            Direction SelectedDirection;
            bool LegalMove = false;
            bool GameOver = false;

            //Foutain object created;
            Fountain GameFoutain = new Fountain(FountainStatus.disabled);

            //Dialog object created;
            DialogTree Dialog = new DialogTree();

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
            (int PlayerRow, int PlayerCol) PlayerTracker = (0,0);
            GameTracker Tracker = new GameTracker(0, 0, GamePlayer, MoveBoard, PlayerTracker);



            //End of set up

            //GameLoop            
            while (GameOver == false)
            {
                do {
                    //Checks for moves that will go outside of the array bounds
                    
                    SelectedDirection = GameMenus.GetPlayerMove();
                    LegalMove = Tracker.LegalMoveCheck(SelectedDirection, PlayerTracker, MoveBoard, Dialog);
                } while (LegalMove == false);

                //Moves player
                PlayerTracker = Tracker.UpdatePlayerLocation(SelectedDirection, MoveBoard, GamePlayer);
                Dialog.MoveMessage(SelectedDirection);
                
                //Room Check - tags for Room type
                RoomType TagInput = TagBoard.CheckRoomType(TagBoard, PlayerTracker);

                //RoomType Actions
                if (TagInput == RoomType.Entry)
                {
                    DialogTree.EntranceMessage();
                    GameOver = GameMenus.EntranceChoice(GameFoutain, Dialog, GameOver, GamePlayer);
                }
                else if (TagInput == RoomType.Fountain)
                {
                    DialogTree.FoutainRoom(GameFoutain);
                    GameMenus.FoutainChoice(GameFoutain, Dialog);

                }              
            }                           
    }
        public enum RoomType { Regular, Fountain, Entry }
        public enum Direction { North, South, East, West}
        public enum FountainStatus { enabled, disabled }

    }


}
