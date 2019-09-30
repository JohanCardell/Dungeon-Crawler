using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Door : DungeonTile, IOpenable
    {
        public Door(int X, int Y)
            : this(X,Y,'D') { }
        public Door(int X, int Y, char Symbol) : base(X,Y,Symbol) { }
    }
}
