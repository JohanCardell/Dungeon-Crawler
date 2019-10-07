using System;

namespace Laboration_4
{
    internal class StateMachine
    {
        internal System.Collections.Generic.List< GameState> states;

        public StateMachine()
        {
        }

        public void EnterState(State gameState, GameSession gameSession)
        {
            switch (gameState)
            {
                case State.MENU:
                    states[0].Start(gameSession);
                    break;
                case State.LOADING:
                    states[1].Start(gameSession);
                    break;
                case State.PLAYING:
                    states[2].Start(gameSession);
                    break;
                case State.GAMEOVER:
                    states[3].Start(gameSession);
                    break;
            }
        }
    }
}