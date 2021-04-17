using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Mobs.Enemies
{
    class Skeleton : Enemy
    {
        public Skeleton()
        {
            type = "Skeleton";
            Health = 50;
            Value = 2;
            level = 1;
            baseDamage = 5;
            Armour = 5;
        }

        public new int Attack()
        {
  
            Random random = new Random();
            int AttackDamage = random.Next(baseDamage, 21);
            Console.WriteLine("Skeleton DMG: " + AttackDamage);
            return AttackDamage;
        }

        public override string ToString()
        {

            return base.ToString() + @"
  .---.
 /     \
( () () )
 \  M  / 
  |HHH|
  `---'
'You're about to get Boned!' ";

        }


    }
}
