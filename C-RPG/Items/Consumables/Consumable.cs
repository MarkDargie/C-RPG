using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Mobs;
using C_RPG.StatusEffects;

namespace C_RPG.Items.Consumables
{
    interface Consumable:Item
    {
        string name { get; set; }
        int hpRestored { get; set; }
        int abilityPoolPoints { get; set; }
        string effect { get; set; }
        bool overtime { get; set; }
        bool Usable { get; set; }
        int overtimeTurns { get; set; }
        StatusEffect ConsumableEffect { get; set; }
        void Use(Entity entity);

    }
}
