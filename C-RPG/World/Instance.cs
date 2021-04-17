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

        // Keep track of how many instances have been played
        public static int InstanceCount;

        public Instance(string _name, int _level)
        {
            name = _name;
            level = _level;
            numberofMobs = level + 1;
            mobs = GetMobs(numberofMobs);
            InstanceCount++;
        }

        /*
         * Create Array of Mobs for instance
         */
        public Enemy[] GetMobs(int mobSize)
        {
            Enemy[] enemies = new Enemy[mobSize];

            for(int i = 0; i < mobSize; i++)
            {
                enemies[i] = new Succubus();
            }
            return enemies;

        }

        /*
        * Write Mob's to Console
        */
        public void ShowMobs()
        {

            int reward = 0;

            for(int i = 0; i < mobs.Length; i++)
            {

                if (mobs[i].Health <= 0)
                {
                    reward += mobs[i].Value;
                    mobs = mobs.Where(mob => mob.Health > 0).ToArray();
                }

                Console.WriteLine(mobs[i].ToString() + "\n");
            }

        }
        
    }
}
