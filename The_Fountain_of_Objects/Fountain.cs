using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Fountain
    {
        public Game.FountainStatus FountainStatus { get; set; }

        public Fountain(Game.FountainStatus CurrentStatus)
        {
            FountainStatus = CurrentStatus;
        }
    }

    

}
