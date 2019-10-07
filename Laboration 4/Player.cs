using System.Collections;
using System.Collections.Generic;

namespace Laboration_4
{
    public class Player : GameAsset
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
        //public IEnumerator GetEnumerator()
        //{
        //    return (IEnumerator)GetEnumerator();
        //}
        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator?view=netframework-4.8
        //http://james-ramsden.com/implement-ienumerable-c/
    }
}
