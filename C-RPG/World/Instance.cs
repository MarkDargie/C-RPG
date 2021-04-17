using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Mobs.Enemies;

namespace C_RPG
{
    class Instance
    {
        public string name;
        public int level;
        public int numberofMobs;
        public Enemy[] mobs;

        public Instance(string _name, int _level)
        {
            name = _name;
            level = _level;
            numberofMobs = level + 1;
            mobs = GetMobs(numberofMobs);
        }

        /*
         * Create Array of Mobs for instance
         */
        public Enemy[] GetMobs(int mobSize)
        {
            Enemy[] enemies = new Enemy[mobSize];

            for(int i = 0; i < mobSize; i++)
            {
                enemies[i] = new Skeleton();
            }
            return enemies;

        }

        /*
        * Write Mob's to Console
        */
        public void ShowMobs()
        {
            foreach(Enemy mob in this.mobs)
            {
                Console.WriteLine("MOB: " + mob.ToString());
            }
        }
        
    }
}
