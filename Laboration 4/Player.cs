namespace Laboration_4
{
    public class Player : GameAsset
    {
        public Inventory inventory = new Inventory();
        private const int maxHealthPoints = 1000;
        private int currentHealthPoints;
        private Color swordType;

        public int MaxHealthPoints
        {
            get => maxHealthPoints;
        }
        public int CurrentHealthPoints
        {
            get => currentHealthPoints;
            set => currentHealthPoints = value;
        }
        public int DamageOutput { get; internal set; }

        //public Material SwordType
        //{
        //    get => swordType;
        //    set => swordType = SwordType;
        //}
        public Player(int positionX, int positionY)
             : this(positionX, positionY, false, true, '§', Color.RED)
        {
            CurrentHealthPoints = 1000;
            AssetColor = Color.BRONZE;
        }
        public Player(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
    }
}
