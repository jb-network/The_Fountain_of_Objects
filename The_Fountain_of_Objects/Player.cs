using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
	public class Player
	{
		public string PlayerName { get; }


		public Player(string PassedName)
		{
			PlayerName = PassedName;
		}

		public static (int, int) SetPlayerLocation(GameBoard<string> MoveBoard, Player GamePlayer)
		{
			(int row, int col) PlayerLocation = (0, 0);
			MoveBoard.Map[PlayerLocation.row, PlayerLocation.col] = GamePlayer.PlayerName;
			return PlayerLocation;
		}

		public static (int, int) UpdatePlayerLocation(Tuple tracker, Game.Direction MovePlayer, Player GamePlayer, GameBoard<string> MoveBoard)
		{

		}

	}
}
