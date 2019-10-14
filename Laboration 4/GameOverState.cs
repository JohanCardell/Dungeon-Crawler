using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class GameOverState : GameState
    {
        public GameOverState(GameSession gameSession) : base(gameSession) { }
        
        public override void Start(GameSession gameSession)
        {
            Console.Clear();
            if(gameSession.Win == true)
            {
                Console.WriteLine("You found the the exit of the dungeon and make it out alive with all your loot! You've won!");
            }
            else
            {
                Console.WriteLine("Your greed for treasury finally cost you your life. You died!");
            }
            Console.WriteLine("Your final score is {0} points", gameSession.Score);
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadKey(true);
            gameSession.CurrentGameState = State.MENU;
            gameSession.LevelIsRendered = false;
            GameSession.Instance = null;
        }
    }
}
