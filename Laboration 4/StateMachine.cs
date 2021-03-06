﻿namespace Laboration_4
{
    public class StateMachine
    {
        public System.Collections.Generic.List< GameState> states;
        public StateMachine() { }
        public void RunState(GameSession gameSession)
        {
            switch (gameSession.CurrentGameState)
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