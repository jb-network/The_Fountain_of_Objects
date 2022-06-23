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


new GameMaster().NewGame();

public class GameMaster
{
    public void NewGame()
    {
        //Build Board
        GameBoard<int> board = new GameBoard<int>(4, 4);
        GameBoard<string> boardTracker = new GameBoard<string>(4, 4);

        //Set player name
        Console.WriteLine("Please Enter your name: ");
        string PlayerName = Console.ReadLine();

        //Set Starting Location
        
        //Build player object 
        Player PlayerID = new Player(PlayerName);
        
        
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
    public CurrentLocation CurrentLocation { get; }

    public Player(string PlayerName)
    {
        Name = PlayerName;
        
    }


}

public record CurrentLocation(int Row, int Column);
//Not sure on these
public enum RoomType { Regular, Fountain, Entry}
public enum Direction { North, South, East, West}
