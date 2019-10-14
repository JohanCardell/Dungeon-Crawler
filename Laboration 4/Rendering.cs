using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Rendering
    {
        public static void Level(GameSession gameSession)
        {
            List<GameAsset> gameAssets = gameSession.CurrentGameAssets;
            for (int row = 0; row < gameSession.MaxMapRows; row++)
            {
                for (int column = 0; column < gameSession.MaxMapColumns; column++)
                {
                    foreach (GameAsset asset in gameAssets)
                    {
                        if (asset.PositionX.Equals(column) && asset.PositionY.Equals(row))
                        {
                            if (asset.IsVisible)
                            {
                                switch (asset.AssetColor)
                                {
                                    case Color.NONE:
                                        break;
                                    case Color.BRONZE:
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        break;
                                    case Color.SILVER:
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        break;
                                    case Color.GOLD:
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        break;
                                    case Color.GREY:
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        break;
                                    case Color.RED:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                    case Color.GREEN:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                }
                                Console.Write(asset.MapRepresentation);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("~");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WindowTop = 0;
            gameSession.LevelIsRendered = true;
        }

        public static void Refresh(GameSession gameSession)
        {
            foreach (GameAsset gameAsset in gameSession.CurrentGameAssets)
            {
                for (int row = -1; row < 2; row++)
                {
                    for (int column = -1; column < 2; column++)
                    {
                        if (gameSession.Player.PositionX == gameAsset.PositionX + column && gameSession.Player.PositionY == gameAsset.PositionY + row)
                        {
                            gameAsset.IsVisible = true;
                            Console.SetCursorPosition(gameAsset.PositionX, gameAsset.PositionY);
                            switch (gameAsset.AssetColor)
                            {
                                case Color.NONE:
                                    break;
                                case Color.BRONZE:
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    break;
                                case Color.SILVER:
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    break;
                                case Color.GOLD:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    break;
                                case Color.GREY:
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                                case Color.RED:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                case Color.GREEN:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                            }
                            Console.Write(gameAsset.MapRepresentation);
                            Console.ResetColor();
                        }
                    }
                }
            }
        }
        public static void SideMenu()
        {
            List<String> sideMenu = new List<String>
            {
                "WASD or arrows",
                "to move",
                " ",
                "Press M",
                "to enter Menu",
                " ",
                "Press P",
                "to drink Potion",
                " ",
                "§ = you",
                "C = chest",
                "D = door",
                "E = exit",
                "M = monster"
            };
            int startLine = 5;
            foreach (String line in sideMenu)
            {
                Console.SetCursorPosition(105, startLine);
                Console.Write(line);
                startLine++;
            }
        }
        public static void PlayerInfoBar(GameSession gameSession)
        {
            ClearCurrentConsoleLine(25);
            Console.SetCursorPosition(0, 25);
            Player player = gameSession.Player;
            String playerHealth = player.CurrentHealthPoints + "/" + player.MaxHealthPoints;
            int numberOfPotions = player.inventory.potions.Count();
            int numberOfBronzeKeys = player.inventory.keys.Count(Loot => Loot.AssetColor is Color.BRONZE);
            int numberOfSilverKeys = player.inventory.keys.Count(Loot => Loot.AssetColor is Color.SILVER);
            int numberOfGoldKeys = player.inventory.keys.Count(Loot => Loot.AssetColor is Color.GOLD);
            Console.WriteLine("Health: {0}      Potions: {1}      Bronze Keys: {2}      Silver Keys: {3}      Gold Keys: {4}      Moves: {5}",
                                playerHealth, numberOfPotions, numberOfBronzeKeys, numberOfSilverKeys, numberOfGoldKeys, gameSession.CurrentMoves) ;
        }
        public static void PrintInteractableMessage(GameSession gameSession)
        {
            ClearCurrentConsoleLine(26);
            Console.SetCursorPosition(0, 26);
            Console.WriteLine(gameSession.InteractableMessage);
        }
        static void ClearCurrentConsoleLine(int line)
        {
            Console.SetCursorPosition(0, line);
            Console.WriteLine(new string(' ', Console.WindowWidth));
        }
    }
}
