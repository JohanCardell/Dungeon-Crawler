using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class MapLogic
    {
        public static void RenderLevel(List<GameAsset> gameAssets, int maxMapColumns, int maxMapRows)
        {
            for (int row = 0; row < maxMapRows; row++)
            {
                for (int column = 0; column < maxMapColumns; column++)
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
    }
}
