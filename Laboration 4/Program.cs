using System;
using System.Collections.Generic;

namespace Laboration_4
{
    public enum Color {NONE, BRONZE, SILVER, GOLD, GREY, GREEN, RED, DARKRED }
    public enum State { MENU, LOADING, PLAYING, GAMEOVER, QUIT }
    public enum Input { NONE, UP, DOWN, LEFT, RIGHT, DRINKPOTION, MAINMENU }
    class Program
    {
        public static bool IsStartMenu = true; 
        public static void Main()
        {
            Console.SetWindowSize( 128, 28);
            GameSession gameSession = GameSession.Instance;
            gameSession.StateMachine = new StateMachine();
            gameSession.StateMachine.states = new List<GameState>
            {
                new MenuState(gameSession),
                new LoadingGameState(gameSession),
                new PlayingGameState(gameSession),
                new GameOverState(gameSession)
            };
            if ( IsStartMenu == true)  //Start menu is only shown at start of game
            {
                gameSession.CurrentGameState = State.MENU;
                IsStartMenu = false;
            }
            else
            {
                gameSession.CurrentGameState = State.LOADING; //The player can choose to start a new game from in game menu
            }
            while (gameSession.CurrentGameState != State.QUIT)
            {
                gameSession.StateMachine.RunState(gameSession);
            }
        }
    }
}
