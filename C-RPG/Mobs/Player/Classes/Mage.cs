using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Items;
using C_RPG.Mobs.Player;

namespace C_RPG.Mobs.Player.Classes
{
    class Mage : Player
    {

        public Mage()
        {
            Spec = "Mage";
            Health = 100;
            Armour = 5;
            AbilityPointPool = 50;//mana
            //inventory = new Item[10];
            
        }

        public override string ToString()
        {
            return base.ToString() + " Mana: " + AbilityPointPool;
        }


    }

}
