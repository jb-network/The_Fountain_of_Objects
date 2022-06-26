using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class DialogTree
    {
        public void WallMessage()
        {
            Console.WriteLine("A massive cave wall stands in your path, you cannot move in that direction");
            Console.WriteLine("Press any key to make a different selection");
            Console.ReadKey();
            Console.Clear();
        }
        public void MoveMessage(Game.Direction SelectedDirection)
        {
            Console.WriteLine($"You carefully move to the {SelectedDirection}");
        }

        public static void EntranceMessage()
        {
            Console.WriteLine("You see a small amout of sunlight peaking into this part of the cave from around the corner.  This must be the cave exit.");            
        }
    }
}
