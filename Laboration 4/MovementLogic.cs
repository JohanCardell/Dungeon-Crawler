using System;
using System.Collections.Generic;

namespace Laboration_4
{
    static class MovementLogic
    {
        public static TargetPosition GetTargetPosition(GameAsset intruderGameAsset)
        {
            DirectionKey directionKey = MovementInput.Direction();
            TargetPosition targetPosition = new TargetPosition(0, 0);

            switch (directionKey)
            {
                case DirectionKey.Up:
                    targetPosition.PositionX = intruderGameAsset.PositionX;
                    targetPosition.PositionY = intruderGameAsset.PositionY - 1;
                    break;
                case DirectionKey.Down:
                    targetPosition.PositionX = intruderGameAsset.PositionX;
                    targetPosition.PositionY = intruderGameAsset.PositionY + 1;
                    break;
                case DirectionKey.Left:
                    targetPosition.PositionX = intruderGameAsset.PositionX - 1;
                    targetPosition.PositionY = intruderGameAsset.PositionY;
                    break;
                case DirectionKey.Right:
                    targetPosition.PositionX = intruderGameAsset.PositionX + 1;
                    targetPosition.PositionY = intruderGameAsset.PositionY;
                    break;
                case DirectionKey.NoDirection:
                    break;
            }
            return targetPosition;
        }
        public static void InteractWithTarget(TargetPosition targetPosition, GameSession gameSession)
        {
            Player player = gameSession.GetPlayer();
            foreach (GameAsset gameAsset in gameSession.CurrentGameAssets)
                if (gameAsset.PositionX == targetPosition.PositionX && gameAsset.PositionY == targetPosition.PositionY)
                {
                    if (gameAsset is IInteractable interactable)
                    {
                        interactable.Interact(player);
                    }
                }
        }

        public static void Move(GameAsset intruderGameAsset, TargetPosition targetPosition, GameSession gameSession)
        {
            // Remove target tile
            List<GameAsset> gameAssets = gameSession.CurrentGameAssets;
            GameAsset foundGameAsset;
            foreach (GameAsset gameAsset in gameAssets)
            {
                if (gameAsset.PositionX == targetPosition.PositionX && gameAsset.PositionY == targetPosition.PositionY && gameAsset.IsPassable)
                {
                    foundGameAsset = gameAsset;
                    gameSession.CurrentGameAssets.Remove(gameAsset);
                    // Spawn floor where player/monster used to be
                    gameSession.CurrentGameAssets.Add(new Floor(intruderGameAsset.PositionX, intruderGameAsset.PositionY));
                    // Move player/monster to the target tile
                    intruderGameAsset.PositionX = targetPosition.PositionX;

                    intruderGameAsset.PositionY = targetPosition.PositionY;
                    break;
                }

            }

        }
    }
}

