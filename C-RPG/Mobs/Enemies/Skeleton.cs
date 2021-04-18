using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Items;
using C_RPG.Items.Consumables.Food;

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
            AbilityPointPool = 50;
            possibleRewards = generatePossibleRewards();
        }

        public override Item[] generatePossibleRewards()
        {
            Item[] possibleDrops = new Item[3];

            for(int i =0; i < possibleDrops.Length; i++)
            {
                possibleDrops[i] = new ChickenWing();
            }

            return possibleDrops;

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
