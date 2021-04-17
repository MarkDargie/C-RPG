using C_RPG.Mobs;
using C_RPG.StatusEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Items.Consumables.Food
{
    abstract class Food : Consumable
    {
        public int hpRestored { get; set; }
        public int abilityPoolPoints { get; set; }
        public bool overtime { get; set; }
        public int overtimeTurns { get; set; }
        public StatusEffect ConsumableEffect { get; set; }
        public bool Usable { get; set; }
        public string name { get; set; }



        public void Use(Entity entity )
        {
            bool inCombat = entity.statusEffects.Contains(StatusEffect.InCombat);
            if (!inCombat && Usable == true)
            {
                //don't consume food in combat.
                entity.statusEffects.Add(ConsumableEffect);
                entity.Health += (hpRestored/ (overtime?overtimeTurns:1));
                entity.AbilityPointPool += (abilityPoolPoints/ (overtime ? overtimeTurns : 1));

                Console.WriteLine(ToString());

            }
            else
            {
                Console.WriteLine(Usable? inCombat?"You can't use "+name+" in combat":"Strange..." : name+ " Is not useable!");
            }
        }

        public override string ToString() //overwrite this for more detail.
        {
            return name+ " Consumed.";
        }


    }
}
