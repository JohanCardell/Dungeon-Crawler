using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class LoadingGameState:  GameState
    {
        public LoadingGameState(GameSession gameSession): base(gameSession) { }

        public override void Start(GameSession gameSession)
        {
            gameSession.CurrentGameWorld = GameWorld.initialGameWorld;
            SetMapDimensions (gameSession);
            gameSession.CurrentGameAssets = GenerateGameAssets(gameSession.CurrentGameWorld);
            gameSession.GameOver = false;
        }
        public void SetMapDimensions(GameSession gameSession)
        {
            gameSession.MaxMapRows = gameSession.CurrentGameWorld.GetLength(0);
            gameSession.MaxMapColumns = gameSession.CurrentGameWorld.GetLength(1);
        }
        public List<GameAsset> GenerateGameAssets(char[,] gameWorld)
        {
            List<GameAsset> gameAssets = new List<GameAsset>();
            for (int row = 0; row < gameWorld.GetLength(0); row++)
            {
                for (int column = 0; column < gameWorld.GetLength(1); column++)
                {
                    if (gameWorld[row, column] == '#')
                    {
                        gameAssets.Add(new Wall(column, row));
                    }
                    else if (gameWorld[row, column] == ' ')
                    {
                        gameAssets.Add(new Floor(column, row));
                    }
                    else if (gameWorld[row, column] == 'X')
                    {
                        gameAssets.Add(new Boundary(column, row));
                    }
                    else if (gameWorld[row, column] == 'D')
                    {
                        gameAssets.Add(new Door(column, row));
                    }
                    else if (gameWorld[row, column] == 'M')
                    {
                        gameAssets.Add(new Monster(column, row));
                    }
                    else if (gameWorld[row, column] == 'C')
                    {
                        gameAssets.Add(new Chest(column, row));
                    }
                    else if (gameWorld[row, column] == 'P')
                    {
                        gameAssets.Add(new Player(column, row));
                    }
                }
            }
            return gameAssets;
        }

    }
}
