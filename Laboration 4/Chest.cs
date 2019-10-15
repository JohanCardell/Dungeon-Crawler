using System;

namespace Laboration_4
{
    class Chest : GameObject, IInteractable
    {
        public Chest(int positionX, int positionY, Color color)
            : this(positionX, positionY, false, false, 'C', color)
        {
            AssetColor = color;
        }
        public Chest(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
        public string Interact(Player player)
        {
            GameSession gameSession = GameSession.Instance;
            Random random = new Random();
            int diceroll = random.Next(1, 10);
            string message = "You don't have a matching key.";
            foreach (var key in player.inventory.keys)
            {
                void ChestReward(int diceScore,//If random number is<=diceScore, player gets score.
                    int diceLowHelthPotion,int diceHighHelthPotion,//If random number is<=diceLowHealthPotion and >=diceHighHealthPotion,player gets health potion. 
                    int diceLowSilverSword,int diceHighSilverSword,//If random number is<=diceLowSilverSword and >=diceHighSilverSword,player gets a silver sword.If none of the above is true, a golden sword is rewarded.
                    int tressureValue)//Determins the number of points player gets from the chest.
                {
                    message = $"You opened a {this.AssetColor} chest, and a {key.AssetColor} key was removed from your inventory. ";
                    player.inventory.keys.Remove(key);//Use key
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
                    ChestReward(5, 6, 7, 8, 9, 100);
                    this.IsPassable = true;
                }
                else if (key.AssetColor == this.AssetColor && this.AssetColor == Color.SILVER)
                {
                    ChestReward(3,4,6,7,8,250);
                    this.IsPassable = true;
                }
                else if (key.AssetColor == this.AssetColor && this.AssetColor == Color.GOLD)
                {
                    ChestReward(2,3,5,6,8,500);
                    this.IsPassable = true;
                }
                break;
            }
            return message;
        }
    }
}
