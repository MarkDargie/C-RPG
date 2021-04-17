using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RPG.Items.Consumables.Food
{
    class ChickenWing : Food
    {
        public ChickenWing()
        {
            hpRestored = 10;
            name = "Chicken Wing";
            Usable = true;
        }
        


        public override string ToString() //overwrite this for more detail.
        {
            return "You consumed a "+name + ". You have recovered " + hpRestored.ToString() +" Health. Yum Yum.";
        }
    }
}
