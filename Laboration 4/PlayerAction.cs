using System;

namespace Laboration_4
{
    public enum HotKey { NONE, UP, DOWN, LEFT, RIGHT, DRINKPOTION, MAINMENU}
    class PlayerAction
    {
        public static string DrinkPotion(Player player)
        {
            String message = "";
            foreach (HealthPotion potion in player.inventory.potions)
            {
                if (player.MaxHealthPoints - player.CurrentHealthPoints > potion.PotionPotency)
                {
                    player.CurrentHealthPoints += potion.PotionPotency;
                }
                else
                {
                    player.CurrentHealthPoints = player.MaxHealthPoints;
                }
                player.inventory.potions.Remove(potion);
                message = "You drank a potion";
                break;
            }
            return message;
        }

        public static HotKey PlayerInput()
        {
            bool tryAgain;
            do {
            tryAgain = false;
            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.Clear();
                switch (userInput.Key)
                {
                    case ConsoleKey.W:
                        return HotKey.UP;
                    case ConsoleKey.A:
                        return HotKey.LEFT;
                    case ConsoleKey.S:
                        return HotKey.DOWN;
                    case ConsoleKey.D:
                        return HotKey.RIGHT;
                    case ConsoleKey.P:
                        return HotKey.DRINKPOTION;
                    case ConsoleKey.M:
                        return HotKey.MAINMENU;
                    default:
                        tryAgain = true;
                        return HotKey.NONE;
                }
            } while (tryAgain);
        }

        public static void PerformAction(HotKey playerAction, GameSession gameSession)
        {
            switch (playerAction)
            {
                case HotKey.UP:
                case HotKey.DOWN:
                case HotKey.LEFT:
                case HotKey.RIGHT:
                    TargetPosition targetPosition = MovementLogic.GetTargetPosition(gameSession.Player, playerAction);
                    MovementLogic.InteractWithTarget(targetPosition, gameSession);
                    MovementLogic.Move(gameSession.Player, targetPosition, gameSession);
                    break;
                case HotKey.DRINKPOTION:
                    DrinkPotion(gameSession.Player);
                    break;
                case HotKey.MAINMENU:
                    gameSession.CurrentGameState = State.MENU;
                    break;
                default:
                    break;
            }
        }
    }
}