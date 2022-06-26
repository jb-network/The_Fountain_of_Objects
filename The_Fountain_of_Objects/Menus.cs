
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
                Console.Clear();
            }while (UserSelection < 0 && UserSelection < 3);
            return UserSelection;
        }
        public string GetPlayerName()
        {
            string GetPlayerName;
            Console.WriteLine("Please enter your name");
            GetPlayerName = Console.ReadLine();
            Console.Clear();
            if (GetPlayerName == null || GetPlayerName == "") GetPlayerName = "Player";
            return GetPlayerName;

        }
        public Game.Direction GetPlayerMove()
        {
            
            Console.WriteLine("Please select a Direction to move");
            Console.WriteLine("1 - Move North");
            Console.WriteLine("2 - Move South");
            Console.WriteLine("3 - Move East");
            Console.WriteLine("4 - Move West");
            int GetMove = Convert.ToInt16(Console.ReadLine());
            
            Game.Direction UserMove = GetMove switch
            {
                1 => Game.Direction.North,
                2 => Game.Direction.South,
                3 => Game.Direction.East,
                4 => Game.Direction.West,
            };

            return UserMove;

        }

        internal void EntranceChoice()
        {
            int EntChoice;
            do
            {
                Console.WriteLine("Press 1 - to Exit the cave");
                Console.WriteLine("Press 2 - to keep exploring the cave");
                EntChoice = Convert.ToInt16(Console.ReadLine());
                if (EntChoice != 1 && EntChoice != 2)
                {
                    Console.WriteLine("The choice you selected is not valid");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (EntChoice != 1 && EntChoice != 2);
            if (EntChoice == 1)
            {
                Console.WriteLine("MAY ADD WIN/LOSE CHECK");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Have fun exploring more");
            }
        }
    }
}
