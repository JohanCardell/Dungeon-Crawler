using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Player : GameAsset, IMoveabel
    {
        public Player(int X, int Y)
            : this(X, Y, 'P') { }
        public Player(int X, int Y, char Symbol) : base(X, Y, Symbol) { }
    }
}
