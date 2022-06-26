
namespace The_Fountain_of_Objects
{
    internal class Menus
    {
        public int GameBoardSetupMenu()
        {
            int UserSelection = 0;
            do
            {
                Console.WriteLine("Please select a gameboard size:");
                Console.WriteLine(" 1 - Small Map (4x4)");
                Console.WriteLine(" 2 - Medium Map (6x6)");
                Console.WriteLine(" 3 - Large Map (8x8)");
                UserSelection = Convert.ToInt16(Console.ReadLine());
            }while (UserSelection < 0 && UserSelection < 3);
            return UserSelection;
        }

        public string GetPlayerName()
        {
            string GetPlayerName;
            Console.WriteLine("Please enter your name");
            GetPlayerName = Console.ReadLine();
            if (GetPlayerName == null || GetPlayerName == "") GetPlayerName = "Player";
            return GetPlayerName;

        }

        public Game.Direction GetPlayerMove()
        {
            int GetMove;
            Console.WriteLine("Please select a Direction to move");
            Console.WriteLine("1 - Move North");
            Console.WriteLine("2 - Move South");
            Console.WriteLine("3 - Move East");
            Console.WriteLine("4 - Move West");
            GetMove = Convert.ToInt16(Console.ReadLine());
            
            Game.Direction UserMove = GetMove switch
            {
                1 => Game.Direction.North,
                2 => Game.Direction.South,
                3 => Game.Direction.East,
                4 => Game.Direction.West,
            };

            return UserMove;

        }
    }
}
