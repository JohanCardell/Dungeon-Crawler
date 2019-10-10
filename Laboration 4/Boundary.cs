using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Boundary : DungeonTile
    {
        public const char mapRepresentation = 'X';
        public Boundary(uint positionX, uint positionY)
            : this(positionX, positionY, false, true, mapRepresentation) { }
        public Boundary(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }
    }
}
