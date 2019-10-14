using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public enum Color {NONE, BRONZE, SILVER, GOLD, GREY, GREEN, RED, DARKRED }
    public enum State { MENU, LOADING, PLAYING, GAMEOVER, QUIT }

    class Program
    {
        public static bool IsStartMenu = true;
        public static void Main()
        {
            Console.CursorVisible = false;
            GameSession gameSession = GameSession.Instance;
            gameSession.StateMachine = new StateMachine();
            gameSession.StateMachine.states = new List<GameState>
            {
                new MenuState(gameSession),
                new LoadingGameState(gameSession),
                new PlayingGameState(gameSession),
                new GameOverState(gameSession)
            };
            if ( IsStartMenu == true)
            {
                gameSession.CurrentGameState = State.MENU;
                IsStartMenu = false;
            }
            else
            {
                gameSession.CurrentGameState = State.LOADING;
            }
            while (gameSession.CurrentGameState != State.QUIT)
            {
                gameSession.StateMachine.RunState(gameSession);
            }
        }
    }
}
