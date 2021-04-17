using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.StatusEffects
{
    public enum StatusEffect
    {
        None = 0,
        Poisoned = 1, //health reduction each turn
        Antidote = 2, //removed poisoned
        Sturdy = 3, //damage reduction (negates weak)
        Weak = 4, //Damage Increase  (negates sturdy)
        InCombat=5


    }
}
