using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Mobs;
using C_RPG.StatusEffects;

namespace C_RPG.Mobs.Player
{
    abstract class Player : Entity
    {
        public string Spec;
        public int Armour;
        public int experiance = 0;
        public int Health { get; set; }
        public List<StatusEffect> statusEffects { get; set; }
        public int AbilityPointPool { get; set; }

        public virtual void TakeDamage(int rawDamageValue)
        {

            int damageValue = rawDamageValue;
            Health -= damageValue;

        }


        public override string ToString()
        {
            return "Spec: " + Spec + " Health: " + Health + " Armour: " + Armour;
        }
    }

}
