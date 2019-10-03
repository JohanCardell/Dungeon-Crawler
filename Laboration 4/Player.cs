namespace Laboration_4
{
    class Player : GameAsset
    {
        public Player(int positionX, int positionY)
             : this(positionX, positionY, false, true, 'P') { }
        public Player(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }
    }
}
