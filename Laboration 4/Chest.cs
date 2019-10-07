using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Chest:GameObject, IInteractable
    {
        private Material chestType;
        public Material ChestType
        {
            get => chestType;
            set => chestType = value;
        }
        public Chest(int positionX, int positionY,Material chestType) 
            : this(positionX, positionY, true, true, 'C')
        {
            this.chestType = chestType;
        }
        public Chest(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }

        void IInteractable.Interact() { }
    }
}
