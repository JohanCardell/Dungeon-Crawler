using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Boundary : DungeonTile
    {
        public const char  BoundaryMapRepresentation = 'X';
        public Boundary(int X, int Y)
            : this(X, Y, false, true,  BoundaryMapRepresentation) { }
        public Boundary(int X, int Y, bool isPassable, bool isVisible, char mapRepresentation) : base(X, Y, isPassable, isVisible, mapRepresentation ) { }
    }
}
