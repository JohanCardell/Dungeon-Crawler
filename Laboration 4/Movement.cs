using System;

namespace Laboration_4
{
    public enum DirectionKey { Up, Down, Left, Right, NoDirection }
    class Movement
    {
        static public DirectionKey Direction()
        {
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
                    return DirectionKey.NoDirection;
            }
        }
    }
}
