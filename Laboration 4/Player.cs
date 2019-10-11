using System.Collections;
using System.Collections.Generic;

namespace Laboration_4
{
    public class Player : GameAsset
    {
        public Inventory inventory = new Inventory();
        private int healthPoints;
        private Color swordType;
        
        
        public int HealthPoints
        {
            get => healthPoints;
            set => healthPoints = value;
        }
        public int DamageOutput { get; internal set; }
        public int CurrentHealthPoints { get; internal set; }
        public object MaxHealthPoints { get; internal set; }

        //public Material SwordType
        //{
        //    get => swordType;
        //    set => swordType = SwordType;
        //}
        public Player(uint positionX, uint positionY)
             : this(positionX, positionY, false, true, '§', Color.RED)
        {
            HealthPoints = 1000;
            AssetColor = Color.BRONZE;
        }
        public Player(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
    }
}
