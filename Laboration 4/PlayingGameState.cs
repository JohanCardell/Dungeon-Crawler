using System;

namespace Laboration_4
{
    class PlayingGameState:  GameState
    {
        public PlayingGameState(GameSession gameSession) : base(gameSession) { }

        public override void Start(GameSession gameSession)
        {
            {
                Console.Clear();
                Rendering.Level(gameSession);
                Rendering.PlayerInfoBar(gameSession);
                Rendering.PrintInteractableMessage(gameSession);
                PlayerAction.PerformAction(PlayerAction.PlayerInput(), gameSession);
                if (gameSession.Player.CurrentHealthPoints <= 0)
                {
                    gameSession.Win = false;
                    gameSession.CurrentGameState = State.GAMEOVER;
                }
            }
        }
    }
}
