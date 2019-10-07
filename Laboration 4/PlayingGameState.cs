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
                MapLogic.RenderLevel(gameSession.CurrentGameAssets, gameSession.MaxMapColumns, gameSession.MaxMapRows);
                Console.ReadKey(true);
            }
        }
    }
}
