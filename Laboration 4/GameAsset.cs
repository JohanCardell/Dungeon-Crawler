using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public abstract class GameAsset
    {
        private uint positionX;
        private uint positionY;
        private char mapRepresentation;
        private bool isPassable;
        private bool isVisible;
        public uint PositionX
        {
            get => positionX;
            set => positionX = value;
        }
        public uint PositionY
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
            get => isPassable;
            set => isPassable = value;
        }
        public bool IsVisible
        {
            get => isVisible;
            set => isVisible = value;
        }
        protected GameAsset(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.isPassable = isPassable;
            this. isVisible = isVisible;
            this.mapRepresentation = mapRepresentation;
        }
    }
}
