using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Boundary : GameAsset
    {
        public const char mapRepresentation = 'X';
        public Boundary(int positionX, int positionY)
            : this(positionX, positionY, false, true, mapRepresentation, Color.NONE) { }
        public Boundary(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
    }
}
