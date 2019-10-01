using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    abstract class GameAsset
    {
        private int positionX;
        private int positionY;
        private char mapRepresentation;

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public char MapRepresentation { get; set; }
        public bool IsPassable { get; set; }
        public bool IsVisible { get; set; }

        protected GameAsset(int positionX, int positionY,bool ispassable,bool isvisible, char mapRepresentation)
        {
            PositionX = positionX;
            PositionY = positionY;
            MapRepresentation = mapRepresentation;
            IsPassable = ispassable;
            IsVisible = isvisible;
        }
    }
}
