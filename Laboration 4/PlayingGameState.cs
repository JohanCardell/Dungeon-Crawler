using System;

namespace Laboration_4
{
    class PlayingGameState:  GameState
    {
        public PlayingGameState(GameSession gameSession) : base(gameSession) { }

        public override void Start(GameSession gameSession)
        {
            {
                if (gameSession.LevelIsRendered == false)
                {
                    Rendering.Level(gameSession);
                    Rendering.SideMenu();
                }
                Rendering.PlayerInfoBar(gameSession);
                Rendering.PrintInteractableMessage(gameSession);
                PlayerAction.PerformAction(PlayerAction.GetInput(), gameSession);
                Rendering.Refresh(gameSession);
                if (gameSession.Player.CurrentHealthPoints <= 0)
                {
                    gameSession.Win = false;
                    gameSession.CurrentGameState = State.GAMEOVER;
                }
            }
        }
    }
}
