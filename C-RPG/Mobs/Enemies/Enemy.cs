using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Mobs.Enemies
{
    abstract class Enemy
    {

        public string type;
        public int Health;
        public int Value;
        public int level;
        public int damage;

        public override string ToString()
        {
            return type + " HP: " + Health + " Lvl: " + level;
        }

    }
}
