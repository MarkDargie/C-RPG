using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Mobs.Enemies
{
    class Succubus : Enemy
    {

        public Succubus()
        {
            type = "Succubus";
            Health = 69;
            Value = 2;
            level = 1;
            baseDamage = 5;
            Armour = 7;
            AbilityPointPool = 50;
        }


        public override string ToString()
        {
            return base.ToString() + @"

        .---.
       (_,/\ \
      (`a a(  )
      ) \=  ) (
     (.--' '--.)
     / (_)^(_) \
    | / \   / \ |
     \\ / . \ //
      \/\___/\/
      |  \_/  |
       \  /  /
        \/  /
         ( (
         |\ \
   jgs   | \ \
        /_Y/_Y

 *Slashes Whip*

";
        }

    }
}
