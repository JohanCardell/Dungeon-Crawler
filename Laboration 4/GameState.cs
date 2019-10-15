namespace Laboration_4
{
    public class GameState
    {
        private GameSession gameSession;
        #region Getters and setters
        public GameSession GameSession 
        {
            get => gameSession;
            set => gameSession = value;
        }
        #endregion
        public GameState(GameSession gameSession)
        {
            GameSession = gameSession;
        }
        public virtual void Start(GameSession gameSession) { }
    }
}
