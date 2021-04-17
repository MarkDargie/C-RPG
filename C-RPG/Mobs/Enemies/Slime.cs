using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Mobs.Enemies
{
    class Slime : Enemy
    {

        public Slime()
        {
            type = "Slime";
            Health = 30;
            Value = 0;
            level = 1;
            baseDamage = 3;
            Armour = 0;
        }


    }
}
