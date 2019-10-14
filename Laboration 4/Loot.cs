using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class Loot:GameObject
    {
        public Loot(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }

    }
}
