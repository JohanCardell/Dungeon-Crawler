using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    abstract class DungeonTile : GameAsset
    {
        protected DungeonTile(int v, int v1, char v3) :  base(v, v1, v3) { } 
    }
}
