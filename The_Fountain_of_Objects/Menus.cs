
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
    }
}
