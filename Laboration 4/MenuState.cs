using System;

namespace Laboration_4
{
    class MenuState : GameState
       
    {
        public MenuState(GameSession gameSession) : base(gameSession) { }

        public override void Start(GameSession gameSession)
        {
            Console.Clear();
            Console.WriteLine("The Dungeon");
            if (gameSession.LevelIsRendered == true)
            {
                Console.WriteLine("C)ontinue");

            }
            Console.WriteLine("N)ew Game");
            Console.WriteLine("Q)uit");

            var userInput = Console.ReadKey(true);
            Console.Clear();
            switch (userInput.Key)
            {
                case ConsoleKey.C:
                    if (gameSession.LevelIsRendered == true)
                    {
                        gameSession.CurrentGameState = State.PLAYING;
                        gameSession.LevelIsRendered = false;
                        break;
                    }
                    else goto default;
                case ConsoleKey.N:
                    if (Program.IsStartMenu)
                    {
                        gameSession.CurrentGameState = State.LOADING;
                    }
                    else
                    {
                        GameSession.Instance = null;
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
