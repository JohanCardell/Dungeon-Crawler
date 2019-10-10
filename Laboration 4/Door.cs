namespace Laboration_4
{
    class Door : GameObject, IInteractable
    {
        private Material doorType;
        public Material DoorType
        {
            get => doorType;
            set => doorType = value;
        }
        public Door(uint positionX, uint positionY, Material doorType)
            : this(positionX, positionY, true, true, 'D')
        {
            this.doorType = doorType;
        }
        public Door(uint positionX, uint positionY, bool isPassable, bool isVisible)
            : this(positionX, positionY, isPassable, isVisible, 'D') { }

        public Door(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }

        public void Interact(Player player, Door door, GameSession gameSession)
        {
            //TODO check if player has the right key
            //if (key.Material == door.Material)
           // if (door.doorType == Ke
        }
    }
}
