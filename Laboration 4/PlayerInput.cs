using System;

namespace Laboration_4
{
    public enum DirectionKey { Up, Down, Left, Right, NoDirection }
    class PlayerInput
    {
        public static DirectionKey Direction()
        {
            bool tryAgain;
            do
            {
                tryAgain = false;
                Console.WriteLine("Input: W,A,S,D");
                ConsoleKeyInfo UserInput = Console.ReadKey();
                Console.Clear();
                switch (UserInput.Key)
                {
                    case ConsoleKey.W:
                        return DirectionKey.Up;
                    case ConsoleKey.A:
                        return DirectionKey.Left;
                    case ConsoleKey.S:
                        return DirectionKey.Down;
                    case ConsoleKey.D:
                        return DirectionKey.Right;
                    default:
                        Console.WriteLine("Invalid input");
                        tryAgain = true;
                        return DirectionKey.NoDirection;
                }
            } while (tryAgain);
        }
        public static string DrinkPotion(Player player)
        {
            string message = "";
            foreach (var potion in player.inventory.potions)
                {
                if (player.MaxHealthPoints - player.CurrentHealthPoints > potion.PotionPotency)
                {
                    player.CurrentHealthPoints +=potion.PotionPotency;
                }
                else
                {
                    player.CurrentHealthPoints = player.MaxHealthPoints;
                }
                player.inventory.potions.Remove(potion);
                message = "You drank a helath potion.";
             break;
            }
            return message;
        }

    }
}