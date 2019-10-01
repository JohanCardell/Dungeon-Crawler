using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Chest:GameObject, Iinteractable
    {
        public Chest(int positionX, int positionY, bool isPassable, bool isVisible) 
            : this(positionX, positionY, isPassable, isVisible, 'C') { }
        public Chest(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }
    }
}
