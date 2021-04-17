using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Mobs.Player.Classes
{
    class Warrior : Player
    {

        public Warrior()
        {
            Spec = "Warrior";
            Health = 120;
            Armour = 10;
            AbilityPointPool = 50;
            baseDamage = 10;
        }

        //public override int StandardAttack()
        //{
        //    return base.StandardAttack();
        //}

        public override void TakeDamage(int rawDamageValue)
        {
            //int damageValue = rawDamageValue - Armour;
            Health -= rawDamageValue;

        }

        public override string ToString()
        {
            return base.ToString() + " Rage: " + AbilityPointPool;
        }

    }
}
