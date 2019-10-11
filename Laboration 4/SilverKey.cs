namespace Laboration_4
{
    class SilverKey : Loot, IInteractable
    {
        public SilverKey(uint positionX, uint positionY)
        : this(positionX, positionY, false, false, 'F', Color.SILVER) { }//Game World symbol: 's'

        public SilverKey(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
        : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }

        public void Interact(Player player)
        {
            player.inventory.keys.Add(this);
            this.IsPassable = true;
        }
    }
}
