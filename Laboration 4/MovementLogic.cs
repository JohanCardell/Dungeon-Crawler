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
                var nextMoveX = currentPlayerX;
                var nextMoveY = currentPlayerY - 1;
                foreach (var tile in LevelEditor.dungeonTiles)
                {
                    if (tile.PositionX == nextMoveX && tile.PositionY == nextMoveY)
                    {
                        if (tile.IsPassable)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (directionkey == DirectionKey.Down)
            {
                var nextMoveX = currentPlayerX;
                var nextMoveY = currentPlayerY + 1;
                foreach (var tile in LevelEditor.dungeonTiles)
                {
                    if (tile.PositionX == nextMoveX && tile.PositionY == nextMoveY)
                    {
                        if (tile.IsPassable)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (directionkey == DirectionKey.Left)
            {
                var nextMoveX = currentPlayerX - 1;
                var nextMoveY = currentPlayerY;
                foreach (var tile in LevelEditor.dungeonTiles)
                {
                    if (tile.PositionX == nextMoveX && tile.PositionY == nextMoveY)
                    {
                        if (tile.IsPassable)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            if (directionkey == DirectionKey.Right)
            {
                var nextMoveX = currentPlayerX + 1;
                var nextMoveY = currentPlayerY;
                foreach (var tile in LevelEditor.dungeonTiles)
                {
                    if (tile.PositionX == nextMoveX && tile.PositionY == nextMoveY)
                    {
                        if (tile.IsPassable)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }


        //private static bool CheckNextMoveAvailability(int playerPositionX, int playerPositionY, int changeX, int changeY)
        //{
        //    var nextMoveX = playerPositionX + changeX;
        //    var nextMoveY = playerPositionY + changeY;
        //    foreach (var tile in LevelEditor.dungeonTiles)
        //    {
        //        if (tile.PositionX == nextMoveX && tile.PositionY == nextMoveY)
        //        {
        //            if (tile.IsPassable)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return false;
        //}










    }

}

