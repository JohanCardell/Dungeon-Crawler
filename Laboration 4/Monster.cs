using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Monster:Object
    {
        public Monster(int X, int Y)
            : this(X, Y, 'M') { }
        public Monster(int X, int Y, char Symbol) : base(X, Y, Symbol) { }
    }
}
