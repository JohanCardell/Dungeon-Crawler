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
            if (LoadingGameState.IsLoaded == true)
            {
                Console.WriteLine("C)ontinue");
            }
            Console.WriteLine("N)ew Game");
            Console.WriteLine("Q)uit");
            ConsoleKeyInfo userInput = Console.ReadKey();

            switch (userInput.Key)
            {
                case ConsoleKey.C:
                    if (LoadingGameState.IsLoaded == true)
                    {
                        gameSession.CurrentGameState = State.PLAYING;
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
