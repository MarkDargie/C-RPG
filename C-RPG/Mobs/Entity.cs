using C_RPG.StatusEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Mobs
{
    interface Entity
    {

        int Health { get; set; }
        int AbilityPointPool { get; set; }
        List<StatusEffect> statusEffects { get; set; }
    }
}
