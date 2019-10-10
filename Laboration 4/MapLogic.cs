using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class MapLogic
    {
        public static void RenderLevel(GameSession gameSession)
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
                                Console.Write(asset.MapRepresentation);
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
    }
}
