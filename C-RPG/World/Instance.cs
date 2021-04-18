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
        public List<Enemy> mobs;

        // Keep track of how many instances have been played
        public static int InstanceCount;

        public Instance(string _name, int _level)
        {
            name = _name;
            level = _level;
            numberofMobs = 1;
            mobs = GetMobs(numberofMobs);
            InstanceCount++;
        }

        /*
         * Create Array of Mobs for instance
         */
        public List<Enemy> GetMobs(int mobSize)
        {
            List<Enemy> enemies = new List<Enemy>();

            for(int i = 0; i < mobSize; i++)
            {
                enemies.Add(new Skeleton());
            }
            return enemies;

        }

        /*
        * Write Mob's to Console
        */
        public void ShowMobs()
        {

            int reward = 0;

            if(mobs.Count <= 0)
            {
                Console.WriteLine("All Mobs Cleared");
            }
            else
            {
                for (int i = 0; i < mobs.Count; i++)
                {

                    if (mobs[i].Health <= 0)
                    {
                        reward += mobs[i].Value;
                        mobs.Remove(mobs[i]);   
                    }

                    Console.WriteLine(mobs[i].ToString() + "\n");
                }
            }



        }

        /*
         * Calculate Instance XP reward from Mob Values
         * @Param: Instance Mobs Array
         * Rewards is equal to total of Mob Values + Number instace mobs
         */
        public int CalculateInstanceExperiance(List<Enemy> mobs)
        {
            int experianceReward = 0;

            for(int i =0; i < mobs.Count; i++)
            {
                experianceReward += mobs[i].Value;
            }

            return experianceReward + mobs.Count;
        }


        /* Calculate Possible Instance Item Rewards from Mob Drops
         * @Param: Instance Mobs Array
         * Returns array of all possible rewards from each instance mob
         */
        public Item[] CalculatePossibleItemRewards(List<Enemy> mobs)
        {
            List<Item> possibleItemRewards = new List<Item>();

            for(int i = 0; i < mobs.Count; i++)
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
        public Item[] CalculateGuaranteedItemRewards(List<Enemy> mobs)
        {
            List<Item> guaranteedItemRewards = new List<Item>();

            for(int i = 0; i < mobs.Count; i++)
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
