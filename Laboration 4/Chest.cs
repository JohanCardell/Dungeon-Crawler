using System;

namespace Laboration_4
{
    class Chest : GameObject, IInteractable
    {
        public Chest(uint positionX, uint positionY, Color color)
            : this(positionX, positionY, false, false, 'C', color)
        {
            AssetColor = color;
        }
        public Chest(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
        public string Interact(Player player)
        {
            GameSession gameSession = GameSession.Instance;
            //const int treasureValue = 10;
            Random random = new Random();
            int diceroll = random.Next(1, 10);
            string message = "You don't have a matching key.";
            foreach (var key in player.inventory.keys)
            {
                void ChestReward(int diceScore,
                    int diceLowHelthPotion,int diceHighHelthPotion,
                    int diceLowSilverSword,int diceHighSilverSword,
                    int tressureValue)
                {
                    message = $"You opened a {this.AssetColor} chest, and a {key.AssetColor} key was removed from your inventory. ";
                    player.inventory.keys.Remove(key);//use key
                    if (diceroll <= diceScore)
                    {
                        gameSession.Score +=tressureValue;
                        message += $"Your score increased by {tressureValue}";
                    }
                    else if (diceroll >= diceLowHelthPotion && diceroll <= diceHighHelthPotion)
                    {
                        player.inventory.potions.Add(new HealthPotion());
                        message += $"Your got a health potion.";
                    }
                    else if (diceroll >= diceLowSilverSword && diceroll <= diceHighSilverSword)
                    {
                        player.inventory.swords.Add(new Sword(Color.SILVER));
                        message += $"Your current sword has been upgraded to a {this.AssetColor} sword.";
                    }
                    else
                    {
                        player.inventory.swords.Add(new Sword(Color.GOLD));
                        message += $"Your current sword has been upgraded to a {this.AssetColor} sword.";
                    }
                }
                if (key.AssetColor == this.AssetColor && this.AssetColor == Color.BRONZE)
                {
                    ChestReward(5,6,7,8,9,10);
                    //message = $"You opened a {this.AssetColor} chest, and a {key.AssetColor} key was removed from your inventory. ";
                    //player.inventory.keys.Remove(key);//use key
                    //if (diceroll <= 5)
                    //{
                    //    gameSession.Score += treasureValue;
                    //    message += $"Your score increased by {treasureValue}";
                    //}
                    //else if (diceroll >= 6 && diceroll <= 7)
                    //{
                    //    player.inventory.potions.Add(new HealthPotion());
                    //    message += $"Your got a health potion.";
                    //}
                    //else if (diceroll >= 8 && diceroll <= 9)
                    //{
                    //    player.inventory.swords.Add(new Sword(Color.SILVER));
                    //    message += $"Your current sword has been updated to a {this.AssetColor} sword.";
                    //}
                    //else
                    //{
                    //    player.inventory.swords.Add(new Sword(Color.GOLD));
                    //    message += $"Your current sword has been updated to a {this.AssetColor} sword.";
                    //}
                }
                else if (key.AssetColor == this.AssetColor && this.AssetColor == Color.SILVER)
                {
                    ChestReward(3,4,6,7,8,25);
                }
                else if (key.AssetColor == this.AssetColor && this.AssetColor == Color.GOLD)
                {
                    ChestReward(2,3,5,6,8,50);
                }
                break;
            }
            return message;
        }
    }
}
