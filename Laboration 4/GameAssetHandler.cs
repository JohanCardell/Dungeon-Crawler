using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class GameAssetHandler
    {
       
        public static void Despawn(GameAsset gameAsset, GameSession gameSession, Enum tile)
        {
            gameSession.CurrentGameAssets.Remove(gameAsset);
            Spawn(gameAsset, gameSession, tile);
        }

        public static void Spawn(GameAsset despawnedGameAsset, GameSession gameSession, Enum tile)
        {
            //TODO switch for tile ENUM
            gameSession.CurrentGameAssets.Add(new Floor(despawnedGameAsset.PositionX, despawnedGameAsset.PositionY));
        }

        public static void MakeVisible(GameAsset gameAsset, Player player)
        {
            if (IsAdjacentToPlayer(gameAsset, player)) gameAsset.IsVisible = true;
        }

        public static bool IsAdjacentToPlayer(GameAsset gameAsset, Player player)
        {
            if (player.PositionX == gameAsset.PositionX + 1 && player.PositionY == gameAsset.PositionY + 1 ||
                player.PositionX == gameAsset.PositionX + 1 && player.PositionY == gameAsset.PositionY - 1 ||
                player.PositionX == gameAsset.PositionX - 1 && player.PositionY == gameAsset.PositionY + 1 ||
                player.PositionX == gameAsset.PositionX - 1 && player.PositionY == gameAsset.PositionY - 1)
            {
                return true;
            }
            else
                return false;
        }
            //foreach (var gameasset in GameSession.CurrentGameAssets)
            //{
            //    if (gameasset is Monster && gameasset.PositionX == player.PositionX)
            //    {
            //        Despawn(gameasset);
            //    }
            //}

    }
}

