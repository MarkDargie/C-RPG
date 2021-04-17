using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_RPG.Players;
using C_RPG.Mobs.Enemies;

namespace C_RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            GameMaster Game = new GameMaster();

            Game.intro();

            Player player = Game.CreatePlayer();

            Game.ShowPlayer(player);

            player.TakeDamage(15);

            Enemy skeleton = new Skeleton();

            Console.WriteLine("Skeleton: " + skeleton.type);

            Instance instance = new Instance("Dungeon", 1);

            Console.WriteLine(instance.mobs.Length);

            instance.ShowMobs();

            Console.ReadKey();

        }

    }
}
