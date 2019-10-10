using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Exit : DungeonTile, IInteractable
    {
        public Exit(uint positionX, uint positionY) 
            : this(positionX, positionY, true, true, 'E') { }
        public Exit(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }

        public void Interact(Player player) { }
    }
    
}
