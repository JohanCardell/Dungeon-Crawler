using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Boundary : DungeonTile
    {
        public const char BoundaryMapSymbol = 'X';
        public Boundary(int X, int Y)
            : this(X, Y, BoundaryMapSymbol) { }
        public Boundary(int X, int Y, char symbol) : base(X, Y, symbol) { }
    }
}
