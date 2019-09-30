using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Chest:Object,IOpenable
    {
        public Chest(int X, int Y)
            : this(X,Y,'C') { }
        public Chest(int X, int Y, char Symbol) : base(X,Y,Symbol) { }
    }
}
