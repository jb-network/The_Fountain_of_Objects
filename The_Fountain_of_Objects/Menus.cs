
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

        internal void FoutainChoice(Fountain GameFoutain, DialogTree Dialog)
        {
            int FoutainChoice;
            do
            {
                
                Console.WriteLine("\n*******************************************************");
                Console.WriteLine($"The Foutain is currently {GameFoutain.FountainStatus}");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("Press 1 - to turn on the foutain");
                Console.WriteLine("Press 2 - to turn off the fountain");
                Console.WriteLine("Press 3 - to ignore the fountian");
                Console.WriteLine("*******************************************************");
                FoutainChoice = Convert.ToInt16(Console.ReadLine());
                if (FoutainChoice != 1 && FoutainChoice != 2 && FoutainChoice != 3)
                {
                    Console.WriteLine("The choice you selected is not valid");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (FoutainChoice != 1 && FoutainChoice != 2 && FoutainChoice != 3);
            if (FoutainChoice == 1 && GameFoutain.FountainStatus == Game.FountainStatus.disabled)
            {
                GameFoutain.FountainStatus = Game.FountainStatus.enabled;
                Dialog.FoutainTurnon();
            }
            else if(FoutainChoice == 1 && GameFoutain.FountainStatus == Game.FountainStatus.enabled)
                {
                Console.WriteLine("The foutain is aleady turned on, you just need to find your way out of the cave");
                }
            else if (FoutainChoice == 2 && GameFoutain.FountainStatus == Game.FountainStatus.enabled)
            {
                GameFoutain.FountainStatus = Game.FountainStatus.disabled;
                Dialog.FoutainTurnoff();
            }
            else if (FoutainChoice == 2 && GameFoutain.FountainStatus == Game.FountainStatus.disabled)
            {
                Console.WriteLine("The only sound coming from the foutian is a slow drip.");
                Console.WriteLine("The foutain is aleady turned off");
            }
            else //Player chooses not to interact with foutain
            {
                Console.WriteLine("You choose to ignore the foutain for now");
            }

        }
    }
}
