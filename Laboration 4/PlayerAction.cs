using System;
namespace Laboration_4
{
    class PlayerAction
    {
        public static string DrinkPotion(Player player)
        {
            string message = "You have not potion";
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
        public static Input GetInput()
        {
            while (true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:                       
                        return Input.UP;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        return Input.LEFT;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        return Input.DOWN;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        return Input.RIGHT;
                    case ConsoleKey.P:
                        return Input.DRINKPOTION;
                    case ConsoleKey.M:
                        return Input.MAINMENU;
                    default:
                        break;
                }
            }
        }
        public static void PerformAction(Input playerAction, GameSession gameSession)
        {
            switch (playerAction)
            {
                case Input.UP:
                case Input.DOWN:
                case Input.LEFT:
                case Input.RIGHT:
                    TargetPosition targetPosition = MovementLogic.GetTargetPosition(gameSession.Player, playerAction);
                    MovementLogic.InteractWithTarget(targetPosition, gameSession);
                    MovementLogic.Move(gameSession.Player, targetPosition, gameSession);
                    break;
                case Input.DRINKPOTION:
                    DrinkPotion(gameSession.Player);
                    break;
                case Input.MAINMENU:
                    gameSession.CurrentGameState = State.MENU;
                    break;
                default:
                    break;
            }
        }
    }
}