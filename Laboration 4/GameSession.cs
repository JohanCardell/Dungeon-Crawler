using System.Collections.Generic;

namespace Laboration_4
{
    public class GameSession
    {
        public int MaxMapRows { get; set; }
        public int MaxMapColumns { get; set; }
        public char[,] CurrentGameWorld { get; set; }
        public List<GameAsset> CurrentGameAssets { get; set; }
        public bool GameOver { get; set; }
        public GameSession() { }

        private Player player;
        public void SetPlayer(Player player)
        {
            this.player = player;
        }
        public Player GetPlayer()
        {
            return this.player;
        }

    }
}