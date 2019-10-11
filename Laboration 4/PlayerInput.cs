using System;

namespace Laboration_4
{
    public enum DirectionKey { Up, Down, Left, Right, NoDirection }
    class PlayerInput
    {
        public static DirectionKey Direction()
        {
            bool tryAgain;
            do {
            tryAgain = false;
            Console.WriteLine("Input: W,A,S,D");
            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.Clear();
                switch (userInput.Key)
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

        public static void DrinkPotion()
        {
            Player player1;

        }
    }
}