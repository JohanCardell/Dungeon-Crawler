using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    abstract class Exit : DungeonTile, Iinteractable
    {
        public Exit(int positionX, int positionY, bool isPassable, bool isVisible) 
            : this(positionX, positionY, isPassable, isVisible, 'E') { }
        public Exit(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }
    }
    
}
