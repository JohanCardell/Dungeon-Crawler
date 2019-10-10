namespace Laboration_4
{
    class KeyLoot : Loot, IInteractable
    {
        public KeyLoot(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
: base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }

        public void Interact(Player player) { }
    }
}
