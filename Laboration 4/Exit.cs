using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    abstract class Exit : DungeonTile, ILeaveable
    {
        public Exit(int X, int Y)
        : this(X, Y, 'E') { }
        public Exit(int X, int Y, char Symbol) : base(X, Y, Symbol) { }
    }
    
}
