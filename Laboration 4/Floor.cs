using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Floor : GameAsset
    {
        public Floor(int positionX, int positionY) 
            :this(positionX, positionY, true, false, ' ', Color.NONE) {}
        public Floor(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
    }
}
