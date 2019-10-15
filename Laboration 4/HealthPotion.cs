namespace Laboration_4
{
    public class HealthPotion : Loot, IInteractable
    {
        private const int potionPotency=100;
        #region Getters and setters
        public int PotionPotency
        {
            get => potionPotency;
        }
        #endregion
        public HealthPotion()
        : this(0, 0, false, false, 'p', Color.DARKRED) { }
        public HealthPotion(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
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
