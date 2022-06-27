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
            Console.WriteLine($"You carefully move {SelectedDirection} to the next room");
            Console.WriteLine("Press any key to make your next move");
            Console.ReadKey();
            Console.Clear();
        }

        public static void EntranceMessage()
        {
            Console.WriteLine("You see a small amout of sunlight peaking into this part of the cave.");  
            Console.WriteLine("This must be the cave exit.");            
        }

        public static void FoutainRoom(Fountain GameFoutain)
        {
            if (GameFoutain.FountainStatus == Game.FountainStatus.disabled)
            {
                Console.WriteLine();
                Console.WriteLine("You slowly enter the next room");
                Console.WriteLine("You hear the sound of water slowly dripping in the center of the room");
                Console.WriteLine("The Foutain of Objects is here!");
                Console.WriteLine("You look at the foutain, and it appears to be turned off");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You slowly enter the next room");
                Console.WriteLine("You hear rushing waters center from the Foutain of Objects");
                Console.WriteLine("You look at the foutain, and it appears to be turned on");
                Console.WriteLine("Now you just need to find your way back to the cave enterance");
                Console.WriteLine();
            }
        }
        public void FoutainTurnon()
        {
            Console.WriteLine();
            Console.WriteLine("You feel around the Foutain of Objects and find a loose stone around the front of the foutain");
            Console.WriteLine("Instinctively you push the stone and water begins to spout from the top of the foutain");
            Console.WriteLine("You head the waters flowing rapidly in the fountain, now you just need to find your way back to the cave enterance");
            Console.WriteLine();
        }

        public void FoutainTurnoff()
        {
            Console.WriteLine();
            Console.WriteLine("You are not sure why you would want to turn off the fountain, but you push a loose stone on the front of the fountain and turn it off");
            Console.WriteLine("The sound of flowing water changes to a slow drip, the fountin is now off");
            Console.WriteLine("You ask youself if that was a good idea, and contiune to explore the cave");
            Console.WriteLine();
        }

        public void OnExitWin(Player PlayerName)
        {
            Console.WriteLine();
            Console.WriteLine("You move toward the light at the exit of the cave");
            Console.WriteLine("\nYou ensured that the Foutain of Objects was turned on and flowing.");
            Console.WriteLine("You have saved the kingdom...for now");
            Console.WriteLine("Great tales of your cunningness and bravery will be told all around the kingdom");
            Console.WriteLine($"\nYou will be forever knows as: {PlayerName.PlayerName}, The Hero of the Land!");
            Console.WriteLine("Congratulations on your win!");
            Console.WriteLine("Press any key to end the game");
            Console.ReadKey();
            Console.Clear();
        }

        public void OnExitLose(Player PlayerName)
        {
            Console.WriteLine();
            Console.WriteLine("You move toward the light at the exit of the cave");
            Console.WriteLine("\nYou did not ensure that the Foutain of Objects was turned on before you left the cave");
            Console.WriteLine("You can't help but think about the death and destruction that will befall the kingdom because of your failure");
            Console.WriteLine("At least you can get a head start running to your hiding place before chaos appears");
            Console.WriteLine($"\nYou will be rememberd as: {PlayerName.PlayerName}, The Hero who Almost Was!");
            Console.WriteLine("You have lost the game.  Better luck next time!");
            Console.WriteLine("Press any key to end the game");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

