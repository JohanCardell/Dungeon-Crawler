using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public enum Color {NONE, BRONZE, SILVER, GOLD, GREY, GREEN, RED }
    public enum Tile {NULL, FLOOR, WALL, BOUNDRY, DOOR }
    public enum State { MENU, LOADING, PLAYING, GAMEOVER, QUIT }

    class Program
    {
        public static void Main(string[] args)
        {
            var gameSession = new GameSession();
            gameSession.StateMachine = new StateMachine();
            gameSession.StateMachine.states = new List<GameState>
            {
                new MenuState(gameSession),
                new LoadingGameState(gameSession),
                new PlayingGameState(gameSession),
                new GameOverState(gameSession)
            };
            gameSession.NewGameState = State.MENU;
            while (gameSession.NewGameState != State.QUIT)
            {
                gameSession.StateMachine.EnterNewState(gameSession);
            }
        }
    }
}
