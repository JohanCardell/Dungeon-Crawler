using System.Collections.Generic;

namespace Laboration_4
{
    class MovementLogic
    {
        public static bool CheckNextMove(Player player)
        {
            DirectionKey directionkey = Movement.Direction();
            int currentPlayerX = player.PositionX;
            int currentPlayerY = player.PositionY;
            if (directionkey == DirectionKey.Up)
            {
                CheckPassable(0, -1, player);
            }
            if (directionkey == DirectionKey.Down)
            {
                CheckPassable(0, 1, player);
            }
            if (directionkey == DirectionKey.Left)
            {
                CheckPassable(-1, 0, player);
            }
            if (directionkey == DirectionKey.Right)
            {
                CheckPassable(1, 0, player);
            }
            return false;
        }
        private static bool CheckPassable(int xChang, int yChange, List<DungeonTile> dungeonTiles, Player player)
        {
            int nextMoveX = player.PositionX + xChang;
            int nextMoveY = player.PositionY + yChange;
            foreach (DungeonTile item in dungeonTiles)
            {
                if (item.PositionX == nextMoveX && item.PositionY == nextMoveY && item.IsPassable)
                {
                    return true;
                }
                break;
            }
            return false;
        }
        //https://stackoverflow.com/questions/19903404/c-sharp-error-not-all-code-paths-return-a-value
    }

}

