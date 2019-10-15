using System.Collections.Generic;

namespace Laboration_4
{
    public class GameSession
    {
        private bool levelIsRendered;
        private bool win;
        private int currentMoves;
        private int maxMapRows;
        private int maxMapColumns;
        private int score = 1000;
        private char[,] currentGameWorld;
        private List<GameAsset> currentGameAssets;
        private State currentGameState;
        private StateMachine stateMachine;
        private Player player;
        private string interactableMessage;
        private bool hasHolyGrail;
        protected GameSession() { }
        private static GameSession instance = null;
        #region Getters and setters
        public bool LevelIsRendered
        {
            get => levelIsRendered;
            set => levelIsRendered = value;
        }
        public bool Win
        {
            get => win;
            set => win = value;
        }
        public int CurrentMoves
        {
            get => currentMoves;
            set => currentMoves = value;
        }
        public int MaxMapRows
        {
            get => maxMapRows;
            set => maxMapRows = value;
        }
        public int MaxMapColumns
        {
            get => maxMapColumns;
            set => maxMapColumns = value;
        }
        public int Score
        {
            get => score;
            set => score = 1000 - CurrentMoves - value;
        }
        public char[,] CurrentGameWorld
        {
            get => currentGameWorld;
            set => currentGameWorld = value;
        }
        public List<GameAsset> CurrentGameAssets
        {
            get => currentGameAssets;
            set => currentGameAssets = value;
        }
        public State CurrentGameState
        {
            get => currentGameState;
            set => currentGameState = value;
        }
        public StateMachine StateMachine
        {
            get => stateMachine;
            set => stateMachine = value;
        }
        public Player Player
        {
            get => player;
            set => player = value;
        }
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
        public string InteractableMessage 
        {
            get => interactableMessage;
            internal set=> interactableMessage = value;
        }
        public bool HasHolyGrail
        {
            get => hasHolyGrail;
            set => hasHolyGrail = value;
        }
        #endregion
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
    }
}