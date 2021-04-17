using C_RPG.StatusEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Mobs.Enemies
{
    abstract class Enemy:Entity
    {

        public string type;
        public int Value;
        public int level;
        public int damage;

        public int Health { get; set; }
        public List<StatusEffect> statusEffects { get; set; }
        public int AbilityPointPool { get; set; }

        public virtual int Attack()
        {
            return 0;
        }

        public override string ToString()
        {
            return type + " HP: " + Health + " Lvl: " + level;
        }

    }
}
