using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Mobs.Player;
using C_RPG.Mobs.Player.Classes;
using C_RPG.Mobs.Enemies;

namespace C_RPG
{
    class GameMaster
    {


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

        public void GameOver()
        {
            Console.WriteLine("You Have Died: Play Again(1). Exit(2)");
        }

        public void ShowPlayer(Player player)
        {
            Console.WriteLine( '\n' + player.ToString());
        }

        //public void AttackAction(Enemy target)
        //{

        //}

        /*
         * Testing Dungeon Instance Functionality
         * NOTE: This will be changed later
         */
        public void StartDungeonInstance(Player player)
        {

            var random = new Random();

            Instance instance = CreateDungeonInstance(player.level);

            while (instance.mobs.Length > 0)
            {
                instance.ShowMobs();

                ShowPlayer(player);

                Console.WriteLine(" \n ACTION: (1) Attack. (2) Use Item. (3) Flee.");
                string action = Console.ReadLine();

                if (action == "1")
                {
                    instance.mobs[0].TakeDamage(player.StandardAttack());
                }
                else
                {
                    Console.WriteLine("Action Invalid");
                }

                for (int i = 0; i < instance.mobs.Length; i++)
                {

                    int roll = random.Next(1, 11);
                    EnemyAttack(instance.mobs[i], player, roll);

                }
            }    

        }


        public void EnemyAttack(Enemy enemy, Player player, int roll)
        {

            int damageRoll = roll + enemy.baseDamage;

            player.TakeDamage(damageRoll);

            Console.WriteLine("ENEMY ACTION: " + damageRoll.ToString());
        }

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
