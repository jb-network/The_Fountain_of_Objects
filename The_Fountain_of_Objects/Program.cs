//Set up new game
new GameMaster().NewGame();

public class GameMaster
{
    public void NewGame()
    {
        //Build Board
        Random DiceRoll = new Random();
        //Plan: Use board to track board movement
        //Plan: User boardtracker to keep track of Tags\Enums
        GameBoard<string> board = new GameBoard<string>(4, 4);
        GameBoard<RoomType> boardTracker = new GameBoard<RoomType>(4, 4);
        boardTracker.TagRooms(boardTracker, DiceRoll);

        //Set player name
        Console.WriteLine("Please Enter your name: ");
        string PlayerName = Console.ReadLine();

        //Set Starting Location


        //Build player object 
        Player PlayerID = new Player(PlayerName);
        //Set Starting Location
        int[] CurrentPlayerLocation = PlayerID.StartPlayerLocation();

        while (true)
        {
            //Move Player Test
            PlayerID.MovePlayer(board, boardTracker, PlayerID, CurrentPlayerLocation);
        }


        Console.Clear();
                     
        //Test set up
        Console.WriteLine("Compass test:");
        board.Compass();
        //Console.Write($"\n{board.GameMap[0, 0]}");
        Console.Write($"\nTotal Row Tiles: {board.GameMap.GetLength(0)}");
        Console.Write($"\nTotal Col Tiles: {board.GameMap.GetLength(1)}");
        Console.Write($"\nTotal Game Tiles: {board.GameMap.Length}");
        Console.WriteLine($"\nUsername: {PlayerID.Name}");

    }
}
public class GameBoard<TBoard>
{
    public int Rows { get; }
    public int Columns { get; }
    public readonly TBoard[,] GameMap;
    
    public GameBoard(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        GameMap = new TBoard[rows, columns];        
    }

    public void TagRooms(GameBoard<RoomType> BoardTracker, Random Diceroll)
    {
        //build out game room
        for (int Row = 0; Row < BoardTracker.GameMap.GetLength(0); Row++)
        {
            for (int Col = 0; Col < BoardTracker.GameMap.GetLength(1); Col++)
            {
                BoardTracker.GameMap[Row, Col] = RoomType.Regular;
            }
        }
        //Add special items to room
        BoardTracker.GameMap[0, 0] = RoomType.Entry;

        //Add fountain tag to possible 6 locations
        int RndRow = Diceroll.Next(1, 3);
        int RndCol = Diceroll.Next(1, 3);
        BoardTracker.GameMap[RndRow, RndCol] = RoomType.Fountain;
    }

        public void Compass()
    {        
        Console.WriteLine("             NORTH            ");
        Console.WriteLine("               |              ");
        Console.WriteLine("       WEST----|----EAST      ");
        Console.WriteLine("               |              ");
        Console.WriteLine("             SOUTH            ");
    }

    public void BoundryChecker()
    {
        //Add boundry checking logic
    }
}
public class Player
{
    public string Name { get; }

   
    public Player(string PlayerName)
    {
        Name = PlayerName;
    }
    public int[] StartPlayerLocation()
    {
        int PlayerRow = 0;
        int PlayerCol = 0;
        int[] PlayerTracker = new int[2] { PlayerRow, PlayerCol };
        return PlayerTracker;
    }
    
    public void UpdatePlayerLocation(GameBoard<string> board, Player PlayerID)
    {
        
    }

    public void MovePlayer(GameBoard<string> board, GameBoard<RoomType> boardtracker, Player PlayerID, int[] CurrentPlayerLocation)
    {
        Console.WriteLine("ENTER TEST MOVE:");
        Console.WriteLine("Test Tips: 1) North, 2)South, 3)East or 4)West (Only South will work for now)");
        int UserMoveChoice = Convert.ToInt16(Console.ReadLine());
        Direction UserDirection = UserMoveChoice switch
        {
            1 => Direction.North,
            2 => Direction.South,
            3 => Direction.East,
            4 => Direction.West,
        };
         
        if (UserDirection == Direction.South)
        {
            CurrentPlayerLocation[0] += 1;
            
  
        }
        Console.WriteLine(UserDirection);
        Console.ReadKey();
    }


}

public record CurrentLocation(int Row, int Column);
//Not sure on these
public enum RoomType { Regular, Fountain, Entry}
public enum Direction { North, South, East, West}


/*
// Future user input for expansion
//Test Gameboard deployment
Console.WriteLine("Enter test X...(int,int)");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter test Y...(int,int)");
int Y = Convert.ToInt32(Console.ReadLine());

GameBoard board = new GameBoard(X, Y);
Console.Write($"{board.GameMap[0,0]}");
*/

//GameBoard board = new GameBoard(3, 3);
//Console.Write($"{board.GameMap[0,0]}");
