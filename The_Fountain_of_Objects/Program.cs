

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
        //Test set up
        Console.WriteLine("Please Enter your name: ");
        string PlayerName = Console.ReadLine();
        Player PlayerID = new Player(PlayerName);
        GameBoard board = new GameBoard(3, 3);
        Console.Clear();
        //Test final set up
        Console.WriteLine("Compass test:");
        board.Compass();
        //Console.Write($"\n{board.GameMap[0, 0]}");
        Console.Write($"\nTotal Row Tiles: {board.GameMap.GetLength(0)}");
        Console.Write($"\nTotal Col Tiles: {board.GameMap.GetLength(1)}");
        Console.Write($"\nTotal Game Tiles: {board.GameMap.Length}");
        Console.WriteLine($"\nUsername: {PlayerID.Name}");
    }
}
public class GameBoard
{
    public int Rows { get; }
    public int Columns { get; }
    public readonly int[,] GameMap;

    public GameBoard(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        GameMap = new int[rows, columns];
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
    public int CurrentLocation { get; }

    public Player(string PlayerName)
    {
        Name = PlayerName;
    }

}
//Not sure on these
enum RoomType { Regular, Fountain, Entry, Wall}
enum Direction { North, South, East, West}
