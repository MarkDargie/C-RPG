using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Items;
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
        public int baseDamage { get; set; }
        public int level = 1;
        public List<StatusEffect> statusEffects { get; set; }
        public int AbilityPointPool { get; set; }
        public Item[] inventory { get; set; } //inventory space of 10 placeholder

        public Player()
        {
            statusEffects = new List<StatusEffect>();
            inventory = new Item[10];
        }

        /*
         *Base Attack For Player
         */
        public virtual int StandardAttack()
        {
            Random damageRoll = new Random();
            int attackDamage = damageRoll.Next(baseDamage, 21);
            return attackDamage;
        }

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
