using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Chest:GameObject, IInteractable
    {
        const char ChestMapRepresentation = 'C';
        public Chest(int positionX, int positionY) 
            : this(positionX, positionY, false, false, ChestMapRepresentation) { }
        public Chest(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }

        void IInteractable.Interact() { }
    }
}
