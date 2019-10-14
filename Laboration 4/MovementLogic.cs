using System;
using System.Collections.Generic;

namespace Laboration_4
{
    static class MovementLogic
    {
        public static TargetPosition GetTargetPosition(GameAsset intruderGameAsset, Input direction)
        {
            TargetPosition targetPosition = new TargetPosition(0, 0);

            switch (direction)
            {
                case Input.UP:
                    targetPosition.PositionX = intruderGameAsset.PositionX;
                    targetPosition.PositionY = intruderGameAsset.PositionY - 1;
                    break;
                case Input.DOWN:
                    targetPosition.PositionX = intruderGameAsset.PositionX;
                    targetPosition.PositionY = intruderGameAsset.PositionY + 1;
                    break;
                case Input.LEFT:
                    targetPosition.PositionX = intruderGameAsset.PositionX - 1;
                    targetPosition.PositionY = intruderGameAsset.PositionY;
                    break;
                case Input.RIGHT:
                    targetPosition.PositionX = intruderGameAsset.PositionX + 1;
                    targetPosition.PositionY = intruderGameAsset.PositionY;
                    break;
                case Input.NONE:
                    break;
            }
            return targetPosition;
        }
        public static void InteractWithTarget(TargetPosition targetPosition, GameSession gameSession)
        {
            foreach (GameAsset gameAsset in gameSession.CurrentGameAssets)
                if (gameAsset.PositionX == targetPosition.PositionX && gameAsset.PositionY == targetPosition.PositionY)
                {
                    if (gameAsset.MapRepresentation == 'E')
                    {
                        gameSession.Win = true;
                        gameSession.CurrentGameState = State.GAMEOVER; //PLAYER FOUND EXIT
                    }
                    if (gameAsset is IInteractable interactable)
                    {
                        gameSession.InteractableMessage = interactable.Interact(gameSession.Player);
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
                    gameSession.CurrentMoves += 1;
                    gameSession.Score -= 1;
                    break;
                }

            }

        }
    }
}

