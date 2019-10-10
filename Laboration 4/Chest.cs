using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Chest:GameObject, IInteractable
    {
        public Chest(uint positionX, uint positionY,Color color) 
            : this(positionX, positionY, false, false, 'C', color)
        {
            Color = color;
        }
        public Chest(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }

        public void Interact() { }
    }
}
