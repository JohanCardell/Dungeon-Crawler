using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    abstract class DungeonTile : GameAsset
    {
        protected DungeonTile(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            :  base(positionX, positionY,isPassable, isVisible, mapRepresentation) { } 
    }
}
