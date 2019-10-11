namespace Laboration_4
{
    class BronzeKey : Loot, IInteractable
    {
        public BronzeKey(uint positionX, uint positionY)
        :this(positionX, positionY,false,false,'F',Color.BRONZE){ }//Game World symbol: 'b'

        public BronzeKey(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
: base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }

        public void Interact(Player player) { }
    }
}
