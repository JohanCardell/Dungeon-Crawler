namespace Laboration_4
{
    class Player : GameAsset
    {
        private int hp;
        private Material swordType;
        public int HP
        {
            get => hp;
            set => hp = value;
        }
        public Material SwordType
        {
            get => swordType;
            set => swordType = SwordType;
        }
        public Player(int positionX, int positionY)
             : this(positionX, positionY, false, true, 'P')
        {
            this.hp = 1000;
            this.swordType = Material.Bronze;
        }
        public Player(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }
    }
}
