using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Mobs.Enemies;
using C_RPG.Items;

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
                enemies[i] = new Skeleton();
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

        /*
         * Calculate Instance XP reward from Mob Values
         * @Param: Instance Mobs Array
         * Rewards is equal to total of Mob Values + Number instace mobs
         */
        public int CalculateInstanceExperiance(Enemy[] mobs)
        {
            int experianceReward = 0;

            for(int i =0; i < mobs.Length; i++)
            {
                experianceReward += mobs[i].Value;
            }

            return experianceReward + mobs.Length;
        }


        /* Calculate Possible Instance Item Rewards from Mob Drops
         * @Param: Instance Mobs Array
         * Returns array of all possible rewards from each instance mob
         */
        public Item[] CalculatePossibleItemRewards(Enemy[] mobs)
        {
            List<Item> possibleItemRewards = new List<Item>();

            for(int i = 0; i < mobs.Length; i++)
            {
                for(int x = 0; x < mobs[i].possibleRewards.Length; x++)
                {
                    possibleItemRewards.Add(mobs[i].possibleRewards[x]);
                }
            }

            return possibleItemRewards.ToArray();
        }


        /* Calculate Guaranteed Instance Item Rewards from Mob Drops
         * @Param: Instance Mobs Array
         * Returns array of all rewards from each instance mob
         */
        public Item[] CalculateGuaranteedItemRewards(Enemy[] mobs)
        {
            List<Item> guaranteedItemRewards = new List<Item>();

            for(int i = 0; i < mobs.Length; i++)
            {
                for(int x = 0; x <  mobs[i].guaranteedRewards.Length; x++)
                {
                    guaranteedItemRewards.Add(mobs[i].guaranteedRewards[x]);
                }
            }

            return guaranteedItemRewards.ToArray();
        }
        
    }
}
