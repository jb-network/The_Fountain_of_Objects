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
            
    }
}
