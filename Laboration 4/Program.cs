using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player(5,7);
            LevelEditor.GenerateStartLevel();
            Console.WriteLine(MovementLogic.CheckNextMove(player));

            Console.ReadKey(true);

            //GameState game = new GameState();
            //Player player = new Player(5,6);
            //game.SetPlayer(player);
            //Player gottenFromGameState = game.GetPlayer();
            ////if (player == gottenFromGameState)
            ////{
            ////    // will be true
            ////}
            ////GameState.StaticMethod();
            //var direction = Movement.Direction();
            ////kolla player position och räkna ut nästa koordinat. Koll aom spelaren kan stå där
            ////om spelaren kan stå där. ändra detta i gamestaten
        }
    }
}
