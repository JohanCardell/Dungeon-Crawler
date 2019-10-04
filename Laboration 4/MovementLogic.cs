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
        private static bool CheckPassable(int xChang, int yChange, Player player)
        {
            var nextMoveX = player.PositionX + xChang;
            var nextMoveY = player.PositionY + yChange;
            
            
            
        }
    }

}

