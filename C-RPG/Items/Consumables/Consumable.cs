using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Mobs;
using C_RPG.StatusEffects;

namespace C_RPG.Items.Consumables
{
    interface Consumable
    {
        string name { get; set; }
        float hpRestored { get; set; }
        float abilityPoolPoints { get; set; }
        bool overtime { get; set; }
        bool usable { get; set; }
        int overtimeTurns { get; set; }
        StatusEffect ConsumableEffect { get; set; }

        void Consume(Entity entity);

    }
}
