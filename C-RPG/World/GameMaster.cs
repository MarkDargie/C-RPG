using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Mobs.Player;
using C_RPG.Mobs.Player.Classes;
using C_RPG.Mobs.Enemies;
using C_RPG.Items.Consumables;

namespace C_RPG
{
    class GameMaster
    {

        /*
         * Create Player Class
         */
        public Player CreatePlayer()
        {

            Console.WriteLine("Select Class: (1) Warrior. (2) Mage. (3) Theif.");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Warrior player = new Warrior();
                return player;
            } else if (choice == "2")
            {
                Mage player = new Mage();
                return player;
            } else if (choice == "3")
            {
                Thief player = new Thief();
                return player;
            }
            else
            {
                return null;
            }

        }

        /*
         * Game Over: Player Choice to Play Again or Exit on Death
         */
        public void GameOver()
        {
            Console.Clear();
            Console.WriteLine("You Have Died: Play Again(1). Exit(2)");
      
        }

        /*
         * Show Player Stats from Player.ToString()
         */
        public void ShowPlayer(Player player)
        {
            Console.WriteLine( '\n' + player.ToString());
        }

        /*
         * Testing Dungeon Instance Functionality
         * NOTE: This will be changed later
         */
        public void StartDungeonInstance(Player player)
        {

            var random = new Random();

            // Create Instance
            Instance instance = CreateDungeonInstance(player.level);

            // Play instance while player is alive and there are mobs in the instance array
            while (player.isAlive && instance.mobs.Length > 0)
            {
                // Console Log Player and Mob Stats at start of each round
                instance.ShowMobs();
                ShowPlayer(player);

                // Player Action
                Console.WriteLine(" \n ACTION: (1) Attack. (2) Use Item. (3) Flee.");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    instance.mobs[0].TakeDamage(player.StandardAttack());
                }
                else if (action == "2")
                {
                    PlayerInventoryAction(player);
                }
                else
                {
                    Console.WriteLine("Action Invalid");
                }

                // Roll Mob Damage and Apply to Player Health
                foreach(Enemy mob in instance.mobs)
                {
                    // **Maybe make this a function in future**
                    int mobDamageRoll = mob.Attack(random.Next(1, 6));
                    player.TakeDamage(mobDamageRoll);
                }

            }

            // End instance
            // Reward XP + Items
            // Player Choice to Rest or Continue ? **make this a method** 
            if (!player.isAlive)
            {
                GameOver();
            }

        }

        // Show Player Inventory & Make Choice
        public void PlayerInventoryAction(Player player)
        {
            player.ShowInventory();
            Console.ReadLine();
            Console.ResetColor();
        }

        // Call once instance has been complete
        public void InstanceComplete()
        {

        }


        //public void EnemyAttack(Enemy enemy, Player player, int roll)
        //{

        //    int damageRoll = roll + enemy.baseDamage;

        //    player.TakeDamage(damageRoll);

        //    Console.WriteLine("ENEMY ACTION: " + damageRoll.ToString());
        //}

        public Instance CreateDungeonInstance(int playerLevel)
        {

            Instance instance = new Instance("Dungeon", playerLevel);
            return instance;
        }


        











        // Print Intro Screen
        public void intro()
        {

            Console.WriteLine(@"  __  __            _      _____                  _      _     
 |  \/  |          | |    |  __ \                (_)    ( )    
 | \  / | __ _ _ __| | __ | |  | | __ _ _ __ __ _ _  ___|/ ___ 
 | |\/| |/ _` | '__| |/ / | |  | |/ _` | '__/ _` | |/ _ \ / __|
 | |  | | (_| | |  |   <  | |__| | (_| | | | (_| | |  __/ \__ \
 |_|__|_|\__,_|_|__|_|\_\_|_____/_\__,_|_|  \__, |_|\___| |___/
  / ____|    |  __ \|  __ \ / ____|          __/ |             
 | |   ______| |__) | |__) | |  __          |___/              
 | |  |______|  _  /|  ___/| | |_ |                            
 | |____     | | \ \| |    | |__| |                            
  \_____|    |_|  \_\_|     \_____|                            
                                                               
     ");

        }


    }


}
