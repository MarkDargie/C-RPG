using C_RPG.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Items
{
    interface Item
    {
        bool Usable { get; set; }
        void Use(Entity entity);
    }
}
