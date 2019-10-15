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
            string message = "You don't have a matching key.";
            foreach (var key in player.inventory.keys)
            {
                if (key.AssetColor == this.AssetColor)
                {
                    message = ChestReward(gameSession, key, this.AssetColor);
                    this.IsPassable = true;
                    break;
                }
            }
            return message;
        }
        string ChestReward(GameSession gameSession, Loot key, Color color)
        {
            //Baseline values
            int chanceAtTreasure = 5;
            int chanceAtLowHealthPotion = 6;
            int chanceAtHighHealthPotion = 6;
            int chanceAtSilverSwordLow = 8;
            int chanceAtSilverSwordHigh = 9;
            int treasureScore = 100;
            switch (color)
            {
                case Color.BRONZE:
                    //Baseline values
                    break;
                case Color.SILVER:
                    chanceAtTreasure = 3;
                    chanceAtLowHealthPotion = 4;
                    chanceAtHighHealthPotion = 6;
                    chanceAtSilverSwordLow = 7;
                    chanceAtSilverSwordHigh = 8;
                    treasureScore = 250;
                    break;
                case Color.GOLD:
                    chanceAtTreasure = 2;
                    chanceAtLowHealthPotion = 3;
                    chanceAtHighHealthPotion = 5;
                    chanceAtSilverSwordLow = 6;
                    chanceAtSilverSwordHigh = 8;
                    treasureScore = 500;
                    break;
            }
            Player player = gameSession.Player;
            Random random = new Random();
            int lootRoll = random.Next(1, 10);
            string message = $"You opened a {color} chest, and a {color} key was removed from your inventory. ";
            player.inventory.keys.Remove(key);//Use key
            if (lootRoll <= chanceAtTreasure)
            {
                gameSession.Score += treasureScore;
                message += $"Your score increased by {treasureScore}";
            }
            else if (lootRoll >= chanceAtLowHealthPotion && lootRoll <= chanceAtHighHealthPotion)
            {
                player.inventory.potions.Add(new HealthPotion());
                message += $"Your got a health potion.";
            }
            else if (lootRoll >= chanceAtSilverSwordLow && lootRoll <= chanceAtSilverSwordHigh)
            {
                player.inventory.swords.Add(new Sword(Color.SILVER));
                message += $"Your current sword has been upgraded to a {this.AssetColor} sword.";
            }
            else
            {
                player.inventory.swords.Add(new Sword(Color.GOLD));
                message += $"Your current sword has been upgraded to a {this.AssetColor} sword.";
            }
            return message;
        }
     }
}