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
        public int baseDamage;
        public int Armour;

        /*
         * Take Damage Method
         */
        public virtual void TakeDamage(int rawDamageValue)
        {
            int damageValue = rawDamageValue - Armour;
            Health -= damageValue;
        }

        public int Health { get; set; }
        public List<StatusEffect> statusEffects { get; set; }
        public int AbilityPointPool { get; set; }

        public int Attack(int damageRoll)
        {

            int attackDamage = RollDamage(baseDamage, 20);
            Console.WriteLine(" Enemy Damage: " + attackDamage.ToString());
            return attackDamage;

            //Random random = new Random();
            //int attackdamage = random.Next(baseDamage, 21);
            //Console.WriteLine("enemy dmg: " + attackdamage);
            //return attackdamage;
        }

        public int RollDamage(int min, int max)
        {

            Random random = new Random();

            return random.Next(min, max);

        }

        public override string ToString()
        {
            return type + " HP: " + Health + " Lvl: " + level;
        }

    }
}
