using System;

namespace Laboration_4
{
    class MenuState : GameState
    {
        public MenuState(GameSession gameSession) : base(gameSession) { }
        public override void Start(GameSession gameSession)
        {
            Console.Clear();
            Console.SetCursorPosition(60, 13);
            Console.WriteLine("The Dungeon");
            if (gameSession.LevelIsRendered == true) //Checks to see if the player already has an active game session
            {
                Console.WriteLine("C)ontinue");
            }
            Console.SetCursorPosition(60, 14);
            Console.WriteLine("N)ew Game");
            Console.SetCursorPosition(60, 15);
            Console.WriteLine("Q)uit");
            var userInput = Console.ReadKey(true);
            Console.Clear();
            switch (userInput.Key)
            {
                case ConsoleKey.C:
                    if (gameSession.LevelIsRendered == true)
                    {
                        gameSession.LevelIsRendered = false; //The level will be rendered again when returning to game session
                        gameSession.CurrentGameState = State.PLAYING;
                        break;
                    }
                    else goto default;
                case ConsoleKey.N:
                    if (Program.IsStartMenu) //Only the first time the player reaches the menu
                    {
                        gameSession.CurrentGameState = State.LOADING; 
                    }
                    else
                    {
                        GameSession.Instance = null; //Current game session is wiped and a new one is generated
                        Program.Main();
                    }
                    break;
                case ConsoleKey.Q:
                    gameSession.CurrentGameState = State.QUIT;
                    break;
                default:
                    break;
            }
        }
    }
}
