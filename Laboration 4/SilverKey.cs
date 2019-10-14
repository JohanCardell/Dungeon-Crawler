namespace Laboration_4
{
    class SilverKey : Loot, IInteractable
    {
        public SilverKey(int positionX, int positionY)
        : this(positionX, positionY, false, false, 'F', Color.SILVER) { }//Game World symbol: 's'

        public SilverKey(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
        : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }

        public string Interact(Player player)
        {
            player.inventory.keys.Add(this);
            this.IsPassable = true;
            string message = $"A {this.AssetColor} key was added to your inventory.";
            return message;
        }
    }
}
