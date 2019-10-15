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
