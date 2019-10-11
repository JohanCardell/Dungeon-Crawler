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
            GameSession gameSession = new GameSession();
            Random random = new Random();
            const int treasureValue = 10;
            int diceroll = random.Next(1, 10);
            string message = "You don't have a matching key.";
            foreach (var key in player.inventory.keys)
            {
                if (key.AssetColor < this.AssetColor)
                {
                    message = $"You opened a {this.AssetColor} chest, and a {key.AssetColor} key was removed from your inventory. ";
                    player.inventory.keys.Remove(key);//use key
                    if (diceroll <= 5)
                    {
                        gameSession.Score += treasureValue;
                        message += $"Your score increased by {treasureValue}";
                    }
                    else if (diceroll >= 6 && diceroll <= 7)
                    {
                        player.inventory.potions.Add(new HealthPotion());
                        message += $"Your got a health potion.";
                    }
                    else if (diceroll >= 8 && diceroll <= 9)
                    {
                        player.inventory.swords.Add(new Sword(Color.SILVER));
                        message += $"Your current sword has been updated to a {this.AssetColor} sword.";
                    }
                    else
                    {
                        player.inventory.swords.Add(new Sword(Color.GOLD));
                        message += $"Your current sword has been updated to a {this.AssetColor} sword.";
                    }
                }
                break;
            }
            return message ;
        }

        void IInteractable.Interact(Player player)
        {

        }
    }
}
