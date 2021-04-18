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
        public List<Item> inventory { get; set; } //inventory space of 10 placeholder
        public bool isAlive = true;

        public Player()
        {
            statusEffects = new List<StatusEffect>();
            inventory = new List<Item>();
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

        // Take Player Damage
        public virtual void TakeDamage(int rawDamageValue)
        {

            int damageValue = rawDamageValue;
            Health -= damageValue;

            if(Health <= 0)
            {
                isAlive = false;
            }

        }

        /*
         * Show All items in player inventory
         */
        public void ShowInventory()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ** Inventory ** ");

            int itemIndex = 1;

            foreach(Item item in this.inventory)
            {

                if(item == null)
                {
                    return;
                } else
                {
                    Console.WriteLine($"({itemIndex.ToString()}) {item.ToString()}");
                    itemIndex++;
                }

                
            }

            Console.ResetColor();
        }

        public void Rest()
        {

        }


        public override string ToString()
        {
            return "Spec: " + Spec + " Health: " + Health + " Armour: " + Armour;
        }
    }

}
