using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Mobs.Player;
using C_RPG.Mobs.Enemies;
using C_RPG.Items.Consumables.Food;

namespace C_RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            // Set Console Window Size
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            GameMaster Game = new GameMaster();

            Game.intro();

            Player player = Game.CreatePlayer();
            player.inventory[0] = new ChickenWing();

            Game.ShowPlayer(player);

            Game.StartDungeonInstance(player);


            //player.inventory[0].Use(player);

            //Game.ShowPlayer(player);


            Console.ReadKey();

        }

    }
}
