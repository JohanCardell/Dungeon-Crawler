using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Rendering
    {
        public static void Level(GameSession gameSession)
        {
            RemoveFogOfWar(gameSession);
            List<GameAsset> gameAssets = gameSession.CurrentGameAssets;
            for (uint row = 0; row < gameSession.MaxMapRows; row++)
            {
                for (uint column = 0; column < gameSession.MaxMapColumns; column++)
                {
                    foreach (GameAsset asset in gameAssets)
                    {
                        if (asset.PositionX.Equals(column) && asset.PositionY.Equals(row))
                        {
                            if (asset.IsVisible)
                            {
                                switch (asset.AssetColor)
                                {
                                    case Color.NONE:
                                        break;
                                    case Color.BRONZE:
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        break;
                                    case Color.SILVER:
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        break;
                                    case Color.GOLD:
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        break;
                                    case Color.GREY:
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        break;
                                    case Color.RED:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                    case Color.GREEN:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                }
                                Console.Write(asset.MapRepresentation);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void RemoveFogOfWar(GameSession gameSession)
        {
            foreach (GameAsset element in gameSession.CurrentGameAssets)
            {
                for (int row = -1; row < 2; row++)
                {
                    for (int column = -1; column < 2; column++)
                    {
                        if (gameSession.Player.PositionX == element.PositionX + column && gameSession.Player.PositionY == element.PositionY + row)
                        {
                            element.IsVisible = true;
                        }
                    }
                }
            }
        }
        public static void PlayerInfoBar(GameSession gameSession)
        {
            Player player = gameSession.Player;
            String playerHealth = player.CurrentHealthPoints + "/" + player.MaxHealthPoints;
            int numberOfPotions = player.inventory.potions.Count();
            int numberOfBronzeKeys = player.inventory.keys.Count(Loot => Loot.AssetColor is Color.BRONZE);
            int numberOfSilverKeys = player.inventory.keys.Count(Loot => Loot.AssetColor is Color.SILVER);
            int numberOfGoldKeys = player.inventory.keys.Count(Loot => Loot.AssetColor is Color.GOLD);
            Console.WriteLine("Health: {0}      Potions: {1}      Bronze Keys: {2}      Silver Keys: {3}      Gold Keys: {4}      Moves: {5}",
                                playerHealth, numberOfPotions, numberOfBronzeKeys, numberOfSilverKeys, numberOfGoldKeys, gameSession.CurrentMoves) ;
            Console.WriteLine("Commands:");
            Console.WriteLine("Up: W");
            Console.WriteLine("Down: S");
            Console.WriteLine("Left: A");
            Console.WriteLine("Right: D");
            Console.WriteLine("Use potion: P");
            Console.WriteLine("Menu: M");
        }
    }
}
