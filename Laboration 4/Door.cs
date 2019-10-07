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
        public Door(int positionX, int positionY, Material doorType)
            : this(positionX, positionY, true, true, 'D')
        {
            this.doorType = doorType;
        }
        public Door(int positionX, int positionY, bool isPassable, bool isVisible)
            : this(positionX, positionY, isPassable, isVisible, 'D') { }

        public Door(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }

        void IInteractable.Interact() { }
    }
}
