using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class GameState
    {
        public GameSession GameSession { get; set; }
        public GameState(GameSession gameSession)
        {
            GameSession = gameSession;
        }
        public virtual void Start(GameSession gameSession) { }
    }
}
