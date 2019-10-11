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
            Player player = gameSession.GetPlayer();
            foreach (GameAsset element in gameSession.CurrentGameAssets)
            {
                for (int row = -1; row < 2; row++)
                {
                    for (int column = -1; column < 2; column++)
                    {
                        if (player.PositionX == element.PositionX + column && player.PositionY == element.PositionY + row)
                        {
                            element.IsVisible = true;
                        }
                    }
                }
            }
        }
        static void PlayerInfoBar(GameSession gameSession)
        {
            Player player = gameSession.GetPlayer();
            String PlayerHealth = player.CurrentHealthPoints + "/" + player.MaxHealthPoints;
            String NumberOfPotions = player.inventory.potions

        }
    }
}
