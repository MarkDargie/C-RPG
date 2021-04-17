using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Mobs.Enemies
{
    class Zombie : Enemy
    {

        public Zombie()
        {
            type = "Zombie";
            Health = 75;
            Value = 2;
            level = 1;
            baseDamage = 2;
        }

        public override string ToString()
        {
            return base.ToString() + " bruuhhhhhh ";
        }
    }
}
