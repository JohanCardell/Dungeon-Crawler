using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class MenuState : GameState
    {
        public MenuState(GameSession gameSession) : base(gameSession) { }

        public override void Start(GameSession gameSession)
        {
            Console.WriteLine("The Dungeon");
            Console.WriteLine("P)play the game");
            Console.WriteLine("Q)uit");
            ConsoleKeyInfo userInput = Console.ReadKey();

            switch (userInput.Key)
            {
                case ConsoleKey.P:
                    gameSession.NewGameState = State.LOADING;
                    break;
                case ConsoleKey.Q:
                    gameSession.NewGameState = State.QUIT;
                    break;
                default:
                    break;
            }
        }
    }
}
