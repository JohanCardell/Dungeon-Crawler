using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class Player : GameAsset
    {
        const char PlayerMapRepresentation = 'P';
        public Player(int positionX, int positionY) 
            : this(positionX, positionY, true, true, PlayerMapRepresentation) { }

        public Player(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation) 
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation) { }
    }
}
