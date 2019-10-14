namespace Laboration_4
{
    class BronzeKey : Loot, IInteractable
    {
        public BronzeKey(int positionX, int positionY)
        :this(positionX, positionY,false,false,'F',Color.BRONZE){ }//Game World symbol: 'b'

        public BronzeKey(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
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
