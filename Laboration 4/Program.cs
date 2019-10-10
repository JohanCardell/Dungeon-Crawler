using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public enum Color {NONE, BRONZE, SILVER, GOLD, GREY, GREEN, RED }
    internal enum Tile {NULL, FLOOR, WALL, BOUNDRY, DOOR }
    internal enum State { MENU, LOADING, PLAYING, GAMEOVER }

    class Program
    {
        public static void Main(string[] args)
        {
            var gameSession = new GameSession();
            var stateMachine = new StateMachine();
            stateMachine.states = new List<GameState>
            {
                new MenuState(gameSession), 
                new LoadingGameState(gameSession),
                new PlayingGameState(gameSession),
                new GameOverState(gameSession)
            };
            stateMachine.EnterState(State.MENU, gameSession);
            stateMachine.EnterState(State.LOADING, gameSession);
            stateMachine.EnterState(State.PLAYING, gameSession);
            stateMachine.EnterState(State.GAMEOVER, gameSession);
            
            Console.ReadKey(true);
        }
    }
}
