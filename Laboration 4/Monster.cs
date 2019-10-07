using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Monster : GameObject, IInteractable
    {
        private int hp;
        private int damage;
        public int Hp
        {
            get => hp;
            set => hp = value;
        }
        public int Damage
        {
            get => damage;
            set => damage = value;
        }
        public Monster(int positionX, int positionY) 
            : this(positionX, positionY, false, true, 'M')
        {
            this.hp = 100;
            this.damage = 10;
        }
        public Monster(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }

        void IInteractable.Interact() { }
    }
}
