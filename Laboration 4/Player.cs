using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Player : GameAsset
    {
        public Player(int positionX, int positionY, bool isPassable, bool isVisible) 
            : this(positionX, positionY, isPassable, isVisible, 'P') { }

        public Player(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }
    }
}
