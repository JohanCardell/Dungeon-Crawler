namespace Laboration_4
{
    public class HealthPotion : Loot, IInteractable
    {
        private const int potionPotency=100;
        public int PotionPotency
        {
            get => potionPotency;
        }
        public HealthPotion()
        : this(0, 0, false, false, 'p', Color.DARKRED) { }
        public HealthPotion(uint positionX, uint positionY)
        : this(positionX, positionY, false, false, 'p', Color.DARKRED) { }//Game World symbol: 'p'
        public HealthPotion(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
        : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
        public string Interact(Player player)
        {
            player.inventory.potions.Add(this);
            this.IsPassable = true;
            string message = "You picked up a health potion";
            return message;
        }
    }
}
