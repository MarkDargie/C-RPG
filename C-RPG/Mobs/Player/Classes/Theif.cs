using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Mobs.Player.Classes
{
    class Thief : Player
    {

        public Thief()
        {
            Spec = "Thief";
            Health = 90;
            Armour = 8;
            AbilityPointPool = 50;//energy
        }

        public override string ToString()
        {
            return base.ToString() + " Energy: " + AbilityPointPool;
        }
    }
}
