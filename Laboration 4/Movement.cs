using System;

namespace Laboration_4
{
    public enum DirectionKey { Up, Down, Left, Right, NoDirection }
    class Movement
    {

        //static public void Direction(Player player)
        //{
        //    Console.WriteLine("Input: W,A,S,D");
        //    ConsoleKeyInfo UserInput = Console.ReadKey();
        //    switch (UserInput.Key)
        //    {
        //        case ConsoleKey.W:
        //            player.PositionY++;
        //            //currenctGameState.SetPlayer(Player player2 = new Player(playerPositionX, playerPositionY - 1));
        //            break;
        //        case ConsoleKey.A:
        //            player.PositionX--;
        //            break;
        //        case ConsoleKey.S:
        //            player.PositionY--;
        //            break;
        //        case ConsoleKey.D:
        //            player.PositionX++;
        //            break;
        //        default:
        //            Console.WriteLine("Invalid input");
        //            break;
        //    }
        //}

        //static public void Direction(GameState gameState)
        //{
        //    Console.WriteLine("Input: W,A,S,D");
        //    ConsoleKeyInfo UserInput = Console.ReadKey();
        //    switch (UserInput.Key)
        //    {
        //        case ConsoleKey.W:
        //            gameState.GetPlayer().PositionY++;
        //            //currenctGameState.SetPlayer(Player player2 = new Player(playerPositionX, playerPositionY - 1));
        //            break;
        //        case ConsoleKey.A:
        //            gameState.GetPlayer().PositionY++;
        //            break;
        //        case ConsoleKey.S:
        //            gameState.GetPlayer().PositionY++;
        //            break;
        //        case ConsoleKey.D:
        //            gameState.GetPlayer().PositionY++;
        //            break;
        //        default:
        //            Console.WriteLine("Invalid input");
        //            break;
        //    }
        //}

        static public DirectionKey Direction()
        {
            Console.WriteLine("Input: W,A,S,D");
            ConsoleKeyInfo UserInput = Console.ReadKey();
            Console.Clear();
            switch (UserInput.Key)
            {
                case ConsoleKey.W:
                    return DirectionKey.Up;
                    break;
                case ConsoleKey.A:
                    return DirectionKey.Left;
                    break;
                case ConsoleKey.S:
                    return DirectionKey.Down;
                    break;
                case ConsoleKey.D:
                    return DirectionKey.Right;
                    break;
                default:
                    return DirectionKey.NoDirection;
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
