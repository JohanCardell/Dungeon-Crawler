using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Wall: GameAsset
    {
        const char WallmapRepresentation = '#';
        public Wall(uint positionX, uint positionY) 
            : this(positionX, positionY, false , false, WallmapRepresentation, Color.GREY) { }

        public Wall(uint positionX, uint positionY, bool isPassable,bool isVisible, char mapRepresentation, Color color) 
            : base(positionX, positionY, isPassable,isVisible, mapRepresentation, color) { }
        
    }
}
