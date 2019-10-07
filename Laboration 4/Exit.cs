using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    abstract class Exit : DungeonTile, IInteractable
    {
        const char ExitMapRepresentation = 'E';
        public Exit(int positionX, int positionY) 
            : this(positionX, positionY, true, false, ExitMapRepresentation) { }

        public Exit(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }

        void IInteractable.Interact() { }
    }
    
}
