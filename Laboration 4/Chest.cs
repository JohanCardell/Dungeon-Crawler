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

        public void Interact(Player player)
        {
            GameSession gameSession = new GameSession();
            const int treasureValue = 10;
            Random random = new Random();
            int diceroll = random.Next(1, 10);




            if (diceroll <= 5)
            {
                gameSession.Score+=treasureValue;
            }
            else if (diceroll >= 6 && diceroll <= 7)
            {
                player.inventory.potions.Add(new HealthPotion());
            }
            else if (diceroll >= 8 && diceroll <= 9)
            {
                player.inventory.swords.Add(new Sword(Color.SILVER));
            }
            else
            {
                player.inventory.swords.Add(new Sword(Color.GOLD));
            }
        }
    }
}
