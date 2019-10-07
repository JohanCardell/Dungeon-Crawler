using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Wall:DungeonTile
    {
        const char WallmapRepresentation = '#';
        public Wall(int positionX, int positionY) 
            : this(positionX, positionY, false , false, WallmapRepresentation) { }

        public Wall(int positionX, int positionY, bool isPassable,bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable,isVisible, mapRepresentation) { }
        
    }
}
