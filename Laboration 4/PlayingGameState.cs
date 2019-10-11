using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class PlayingGameState:  GameState
    {
        public PlayingGameState(GameSession gameSession) : base(gameSession) { }

        public override void Start(GameSession gameSession)
        {
        while (gameSession.GameOver == false)
            {
                Player player = gameSession.GetPlayer();
                Rendering.Level(gameSession);

                TargetPosition targetPosition = MovementLogic.GetTargetPosition(gameSession.GetPlayer());
                MovementLogic.InteractWithTarget(targetPosition, gameSession);
                MovementLogic.Move(player, targetPosition, gameSession);
                if (player.HealthPoints <= 0) gameSession.GameOver = true;
            }
        }
    }
}
