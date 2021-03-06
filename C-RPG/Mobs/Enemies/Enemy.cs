using C_RPG.StatusEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Items;

namespace C_RPG.Mobs.Enemies
{
    abstract class Enemy:Entity
    {

        public string type;
        public int Value;
        public int level;
        public int baseDamage;
        public int Armour;
        public Item[] possibleRewards { get; set; }
        public Item[] guaranteedRewards { get; set; }

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

            //int attackDamage = RollDamage(baseDamage, 20);
            //Console.WriteLine(" Enemy Damage: " + attackDamage.ToString());
            //return attackDamage;

            int attackDamage = damageRoll + baseDamage;

            Console.WriteLine(" Enemy Atacked for : " + attackDamage);
            return attackDamage;
        }

        public int RollDamage(int min, int max)
        {

            Random random = new Random();

            return random.Next(min, max);

        }

        public virtual Item[] generatePossibleRewards()
        {
            Item[] possibleDrops = new Item[5];
            return possibleDrops;
        }

        public virtual Item[] generateGuaranteedRewards()
        {
            Item[] guaranteedDrops = new Item[5];
            return guaranteedDrops;
        }

        public override string ToString()
        {
            return type + " HP: " + Health + " Lvl: " + level;
        }

    }
}
