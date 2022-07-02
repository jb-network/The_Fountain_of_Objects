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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You see a small amout of sunlight peaking into this part of the cave.");
            Console.ResetColor();
            Console.WriteLine("This must be the cave exit.");            
        }

        public static void FoutainRoom(Fountain GameFoutain)
        {
            if (GameFoutain.FountainStatus == Game.FountainStatus.disabled)
            {
                Console.WriteLine();
                Console.WriteLine("You slowly enter the next room");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You hear the sound of water slowly dripping near the center of the room");
                Console.ResetColor();
                Console.WriteLine("The Foutain of Objects is here!");
                Console.WriteLine("You look at the foutain, and it appears to be turned off");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You slowly enter the next room");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You hear rushing waters center from the Foutain of Objects");
                Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You hear the waters flowing rapidly in the fountain");
            Console.ResetColor();
            Console.WriteLine("Now you just need to find your way back to the cave enterance");
            Console.WriteLine();
        }

        public void FoutainTurnoff()
        {
            Console.WriteLine();
            Console.WriteLine("You are not sure why you would want to turn off the fountain, but you push a loose stone on the front of the fountain and turn it off");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The sound of flowing water changes to a slow drip, the fountin is now off");
            Console.ResetColor();
            Console.WriteLine("You ask youself if that was a good idea, and contiune to explore the cave");
            Console.WriteLine();
        }

        public void OnExitWin(Player PlayerName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You move toward the light at the exit of the cave");
            Console.ResetColor();
            Console.WriteLine("\nYou ensured that the Foutain of Objects was turned on and flowing.");
            Console.WriteLine("You have saved the kingdom...for now");
            Console.WriteLine("Great tales of your cunningness and bravery will be told all around the kingdom");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nYou will be forever knows as: {PlayerName.PlayerName}, The Hero of the Land!");
            Console.WriteLine("Congratulations on your win!");
            Console.ResetColor();
            Console.WriteLine("Press any key to end the game");
            Console.ReadKey();
            Console.Clear();
        }

        public void OnExitLose(Player PlayerName)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You move toward the light at the exit of the cave");
            Console.ResetColor();
            Console.WriteLine("\nYou did not ensure that the Foutain of Objects was turned on before you left the cave");
            Console.WriteLine("You can't help but think about the death and destruction that will befall the kingdom because of your failure");
            Console.WriteLine("At least you can get a head start running to your hiding place before chaos appears");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nYou will be rememberd as: {PlayerName.PlayerName}, The Hero who Almost Was!");
            Console.WriteLine("You have lost the game.  Better luck next time!");
            Console.ResetColor();
            Console.WriteLine("Press any key to end the game");
            Console.ReadKey();
            Console.Clear();
        }
        public void Pit()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nYou feel a warm draft, and smell the scent of stale air.");
            Console.WriteLine("There is a pit in a near by room");
            Console.ResetColor();

        }
        public void Amaork()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nYou smell the stench of an amarok nearby.");
            Console.ResetColor();

        }
        public void Maelstrom()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nYou hear the growling and groaning of a maelstrom nearby.");
            Console.ResetColor();
        }
        public void TransitionToMove()
        {
            Console.WriteLine("\nYou do not hear, smell or feel anything additional from the nearby rooms");
            Console.WriteLine("Press any key to make your next move");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MaelstromRoom()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nYou have entered a room with a Maelstrom");
            Console.WriteLine("The fearsome creature howls in the dark");
            Console.WriteLine("The ear piecering sound shakes the room");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A Flash of light appears");
            //check for other item
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("The Maelstrom has teleported you to a new location");
            Console.ResetColor();
            Console.WriteLine("Its common knowledge that Maelstroms retreat after generating a teleporting howl attack ");
            Console.WriteLine("The creature has moved to a new space, and you have no idea where you now are");
            Console.WriteLine("You think to yourself sarcastically...Well this should be fun...");
            Console.WriteLine("Press any key to make your next move");
            Console.ReadKey();
            Console.Clear();
        }
        public static bool PitRoom(bool GameOver, Player GamePlayer)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nYou have fallen into a deep dark pit");
            Console.WriteLine("As you fall, you feel several woodenspikes pierce your body on the way down");
            Console.WriteLine("You take one last breath, as a forever darkness covers you eyes");
            Console.WriteLine("You have died a painful death in a dark pit...alone and forgotten");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You will always be remembered as {GamePlayer.PlayerName} the broken");
            Console.WriteLine("You Game is over, and you have lost");
            Console.WriteLine("The Kingdom is lost to the darkness, you have failed in your quest");
            Console.ResetColor();
            Console.WriteLine("Press any key to end the game");
            Console.ReadKey();
            Console.Clear();
            GameOver = true;
            return GameOver;

        }
        public static bool AmarokRoom(bool GameOver, Player GamePlayer)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nYou walk into the next room and hear a deep growl");
            Console.WriteLine("A creature bites your arm and then your neck");
            Console.WriteLine("You feel pain and sadness as you become a snack for an Amarok");
            Console.WriteLine("You have died a sad, empty death as dog food");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You will always be remembered as {GamePlayer.PlayerName} Food of Dogs");
            Console.WriteLine("You Game is over, and you have lost");
            Console.WriteLine("The Kingdom is lost to the darkness, you have failed in your quest");
            Console.ResetColor();
            Console.WriteLine("Press any key to end the game");
            Console.ReadKey();
            Console.Clear();
            GameOver = true;
            return GameOver;

        }
    }
}


