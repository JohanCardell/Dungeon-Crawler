using System.Collections;
using System.Collections.Generic;

namespace Laboration_4
{
    public class Player : GameAsset
    {
        private int healthPoints;
        private Material swordType;
        
        public int HealthPoints
        {
            get => healthPoints;
            set => healthPoints = value;
        }
        public int DamageOutput { get; internal set; }

        //public Material SwordType
        //{
        //    get => swordType;
        //    set => swordType = SwordType;
        //}
        public Player(uint positionX, uint positionY)
             : this(positionX, positionY, false, true, 'P')
        {
            this.healthPoints = 1000;
            this.swordType = Material.BRONZE;
        }
        public Player(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }
    }
}
