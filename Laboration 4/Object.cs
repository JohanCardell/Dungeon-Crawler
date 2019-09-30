using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    abstract class Object : GameAsset
    {
        protected Object(int X, int Y, char Symbol) : base(X,Y,Symbol) { } 
    }
}
