using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Players
{
    class Player
    {
        public string Spec;
        public int Health;
        public int Armour;
        public int experiance = 0;

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


    /*
     Warrior Class
     */
    class Warrior: Player
    {
        public int rage = 50;

        public Warrior()
        {
            Spec = "Warrior";
            Health = 120;
            Armour = 10;
        }

        public override void TakeDamage(int rawDamageValue)
        {
            base.TakeDamage(rawDamageValue - Armour);

        }

        public override string ToString()
        {
            return base.ToString() + " Rage: " + rage;
        }

    }

    /*
     Mage Class
     */
    class Mage: Player
    {
        public int Mana = 50;

        public Mage()
        {
            Spec = "Mage";
            Health = 100;
            Armour = 5;
        }

        public override string ToString()
        {
            return base.ToString() + " Mana: " + Mana;
        }


    }

    /*
     Thief Class*/
    class Thief: Player
    {
        public int energy = 50;

        public Thief()
        {
            Spec = "Thief";
            Health = 90;
            Armour = 8;
        }
    }
}
