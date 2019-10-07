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
        private bool ispassable;
        private bool isvisible;
        public int PositionX
        {
            get => positionX;
            set => positionX = value;
        }
        public int PositionY
        {
            get => positionY;
            set => positionY = value;
        }
        public char MapRepresentation
        {
            get => mapRepresentation;
            set => mapRepresentation = value;
        }
        public bool IsPassable
        {
            get => ispassable;
            set => ispassable = value;
        }
        public bool IsVisible
        {
            get => isvisible;
            set => isvisible = value;
        }
        protected GameAsset(int positionX, int positionY,bool ispassable,bool isvisible, char mapRepresentation)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.mapRepresentation = mapRepresentation;
            this.ispassable = ispassable;
            this. isvisible = isvisible;
        }
    }
}
