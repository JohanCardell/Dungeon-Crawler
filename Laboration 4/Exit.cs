using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Exit : GameAsset, IInteractable
    {
        public Exit(uint positionX, uint positionY) 
            : this(positionX, positionY, true, false, 'E', Color.NONE) { }
        public Exit(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }

        public void Interact(Player player) { }
    }
    
}
