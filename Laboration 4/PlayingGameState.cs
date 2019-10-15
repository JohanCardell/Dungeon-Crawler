using System;

namespace Laboration_4
{
    class PlayingGameState:  GameState
    {
        public PlayingGameState(GameSession gameSession) : base(gameSession) { }
        public override void Start(GameSession gameSession)
        {
            {
                Console.CursorVisible = false;
                if (gameSession.LevelIsRendered == false) //Renders the static map layout and side menu
                {
                    Rendering.Level(gameSession);
                    Rendering.SideMenu();
                    gameSession.LevelIsRendered = true;
                }
                Rendering.Refresh(gameSession); //Refreshes a 3x3 box centered on the player
                Rendering.PlayerInfoBar(gameSession); //Displays info about current health, keys and potions
                Rendering.PrintInteractableMessage(gameSession);//Displays message from last interaction
                PlayerAction.PerformAction(PlayerAction.GetInput(), gameSession);
                if (gameSession.Player.CurrentHealthPoints <= 0)
                {
                    gameSession.Win = false;
                    gameSession.CurrentGameState = State.GAMEOVER;
                }
            }
        }
    }
}
