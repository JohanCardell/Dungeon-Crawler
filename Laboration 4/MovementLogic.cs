using System.Collections.Generic;

namespace Laboration_4
{
    static class MovementLogic
    {
        public static TargetPosition GetTargetPosition(GameAsset intruderGameAsset, Input direction)
        //Allows a player to get the position of its next move 
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
                    if (gameAsset.MapRepresentation == 'E') //Player found the Exit tile and wins the game
                    {
                        if (gameSession.Player.hasTheHolyGrail == false)
                        {
                            System.Console.WriteLine("You need to find the Holy Grail before leaving");
                        }
                        else
                        {
                            gameSession.Win = true;
                            gameSession.CurrentGameState = State.GAMEOVER;
                        }
                    }
                    if (gameAsset is IInteractable interactable)
                    {
                        gameSession.InteractableMessage = interactable.Interact(gameSession.Player);
                    }
                }
        }
        public static void Move(GameAsset intruderGameAsset, TargetPosition targetPosition, GameSession gameSession)
        //Allows a game asset (player, monster(not yet implemented) etc) to move
        {
            List<GameAsset> gameAssets = gameSession.CurrentGameAssets;
            GameAsset targetGameAsset;
            foreach (GameAsset gameAsset in gameAssets)
            {
                //Finds the game asset the player is moving to
                if (gameAsset.PositionX == targetPosition.PositionX && gameAsset.PositionY == targetPosition.PositionY && gameAsset.IsPassable)
                {
                    targetGameAsset = gameAsset;
                    gameSession.CurrentGameAssets.Remove(targetGameAsset);

                    //Creates Floor object where the player used to be
                    gameSession.CurrentGameAssets.Add(new Floor(intruderGameAsset.PositionX, intruderGameAsset.PositionY));

                    // player/monster to the target tile
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

