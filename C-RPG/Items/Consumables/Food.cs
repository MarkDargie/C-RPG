using C_RPG.Mobs;
using C_RPG.StatusEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Items.Consumables
{
    abstract class Food : Consumable
    {
        public float hpRestored { get; set; }
        public float abilityPoolPoints { get; set; }
        public bool overtime { get; set; }
        public int overtimeTurns { get; set; }
        public StatusEffect ConsumableEffect { get; set; }
        public bool usable { get; set; }
        public string name { get; set; }

        public void Consume(Entity entity )
        { 
            throw new NotImplementedException();
            //apply modification to entity
        }
    }
}
