using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Door : DungeonTile, Iinteractable
    {
        public Door(int positionX, int positionY, bool isPassable, bool isVisible) 
            : this(positionX, positionY, isPassable, isVisible, 'D') { }

        public Door(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }
    }
}
