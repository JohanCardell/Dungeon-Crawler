using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class GameState
    {
        Player player;
        List<DungeonTile> dungeonTiles;
        List<Chest> chests;
    
        public void SetPlayer(Player player)
        {
            this.player = player;
        }

        public Player GetPlayer()
        {
            return this.player;
        }
        

        //public static void StaticMethod()
        //{
        //    Console.WriteLine("My Static Method");
        //}
        //void GetPlayerPosition()
        //{
        //    Player player2 = new Player(4,5);
        //}
    }
}
