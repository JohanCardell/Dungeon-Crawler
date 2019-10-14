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
            gameSession.CurrentGameAssets = GenerateGameAssets(gameSession);
            gameSession.Player = gameSession.GetPlayerFromList();
            //IsLoaded = true;
            gameSession.CurrentGameState = State.PLAYING;

        }
        public void SetMapDimensions(GameSession gameSession)
        {
            gameSession.MaxMapRows = gameSession.CurrentGameWorld.GetLength(0);
            gameSession.MaxMapColumns = gameSession.CurrentGameWorld.GetLength(1);
        }
        public List<GameAsset> GenerateGameAssets(GameSession gameSession)
        {
            char[,] gameWorld = gameSession.CurrentGameWorld;
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

                    } else if (gameWorld[row, column] == 'E')
                    {
                        gameAssets.Add(new Exit(column, row));
                    }
                    else if (gameWorld[row, column] == 'X')
                    {
                        gameAssets.Add(new Boundary(column, row));
                    }
                    else if (gameWorld[row, column] == 'G')
                    {
                        gameAssets.Add(new Door(column, row, Color.GOLD));
                    }
                    else if (gameWorld[row, column] == 'S')
                    {
                        gameAssets.Add(new Door(column, row, Color.SILVER));
                    }
                    else if (gameWorld[row, column] == 'B')
                    {
                        gameAssets.Add(new Door(column, row, Color.BRONZE));
                    }
                    else if (gameWorld[row, column] == 'D')
                    {
                        gameAssets.Add(new Door(column, row, Color.NONE));
                    }
                    else if (gameWorld[row, column] == 'M')
                    {
                        gameAssets.Add(new Monster(column, row));
                    }
                    else if (gameWorld[row, column] == 'j')
                    {
                        gameAssets.Add(new Chest(column, row, Color.GOLD));
                    }
                    else if (gameWorld[row, column] == 'k')
                    {
                        gameAssets.Add(new Chest(column, row, Color.SILVER));
                    }
                    else if (gameWorld[row, column] == 'l')
                    {
                        gameAssets.Add(new Chest(column, row, Color.BRONZE));
                    }
                    else if (gameWorld[row, column] == 'g')
                    {
                        gameAssets.Add(new GoldKey(column, row));
                    }
                    else if (gameWorld[row, column] == 's')
                    {
                        gameAssets.Add(new SilverKey(column, row));
                    }
                    else if (gameWorld[row, column] == 'b')
                    {
                        gameAssets.Add(new BronzeKey(column, row));
                    }
                    else if (gameWorld[row, column] == '§')
                    {
                        gameAssets.Add(new Player(column, row));
                    }
                }
            }
            return gameAssets;
        }
    }
}
