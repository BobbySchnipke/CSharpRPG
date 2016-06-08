using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedBattleGame
{
    //this class will be used to create the object of the player
    public class Player1
    {
        // each propery is allowed to receive and set an integer to calculate 
        //how much of each property is available
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Magic { get; set; }
        public int Defense { get; set; }
    }
}
