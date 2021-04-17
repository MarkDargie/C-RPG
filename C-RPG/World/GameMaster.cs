using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Players;

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


        public void ShowPlayer(Player player)
        {
            Console.WriteLine(player.ToString());
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
