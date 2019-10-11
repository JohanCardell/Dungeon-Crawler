namespace Laboration_4
{
    class GoldKey : Loot, IInteractable
    {
        public GoldKey(uint positionX, uint positionY)
        : this(positionX, positionY, false, false, 'F', Color.GOLD) { }//Game World symbol: 'g'

        public GoldKey(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
: base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }

        public void Interact(Player player) 
        {
            player.inventory.keys.Add(this);
            this.IsPassable = true;
        }
    }
}
