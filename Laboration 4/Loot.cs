using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Loot:Object
    {
        public Loot(int X, int Y)
            : this(X, Y, 'L') { }
        public Loot(int X, int Y, char Symbol) : base(X,Y,Symbol) { }
    }
}
