using System.Collections.Generic;

namespace Laboration_4
{
    public class GameSession
    {
        public bool Win { get; set; }
        public int CurrentMoves { get; set; }
        public int MaxMapRows { get; set; }
        public int MaxMapColumns { get; set; }
        private int score = 1000;
        public int Score
        {
            get => score;
            set => score = 1000 - CurrentMoves - value;
        }
        public char[,] CurrentGameWorld { get; set; }
        public List<GameAsset> CurrentGameAssets { get; set; }
        public State CurrentGameState { get; set; }
        public StateMachine StateMachine { get; set; }
        public Player Player { get; set; }
        public Player GetPlayerFromList()
        {
            foreach (var element in CurrentGameAssets)
            {
                if (element is Player)
                {
                    return element as Player;
                }
            }
            return null;
        }
        protected GameSession() { }
        private static GameSession instance = null;
        public static GameSession Instance
        {
            get
            {
                if (GameSession.instance == null)
                {
                    GameSession.instance = new GameSession();
                }
                return GameSession.instance;
            }
            set => instance = value;
        }

    }
}