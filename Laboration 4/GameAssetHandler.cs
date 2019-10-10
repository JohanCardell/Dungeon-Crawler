using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class GameAssetHandler
    {
       

        public static void Despawn(GameAsset gameAssetToRemove, GameSession gameSession)
        {
            gameSession.CurrentGameAssets.Remove(gameAssetToRemove);
           // Spawn(gameAsset, gameSession, Tile.FLOOR);
        }

        public static void Spawn(GameAsset despawnedGameAsset, GameSession gameSession, Enum tile)
        {
            //TODO switch for tile ENUM
            gameSession.CurrentGameAssets.Add(new Floor(despawnedGameAsset.PositionX, despawnedGameAsset.PositionY));
        }

        
    }
            //if (player.PositionX == gameAsset.PositionX + 1 && player.PositionY == gameAsset.PositionY + 1 ||
            //    player.PositionX == gameAsset.PositionX + 1 && player.PositionY == gameAsset.PositionY - 1 ||
            //    player.PositionX == gameAsset.PositionX - 1 && player.PositionY == gameAsset.PositionY + 1 ||
            //    player.PositionX == gameAsset.PositionX - 1 && player.PositionY == gameAsset.PositionY - 1)
            //{
            //    return true;
            //}
            //else
            //    return false;
            //foreach (var gameasset in GameSession.CurrentGameAssets)
            //{
            //    if (gameasset is Monster && gameasset.PositionX == player.PositionX)
            //    {
            //        Despawn(gameasset);
            //    }
            //}

}

