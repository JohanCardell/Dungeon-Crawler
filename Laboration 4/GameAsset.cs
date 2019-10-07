using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public abstract class GameAsset
    {
        private int positionX;
        private int positionY;
        private char mapRepresentation;
        private bool ispassable;
        private bool isVisible;
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
            get => isPassable;
            set => isPassable = value;
        }
        public bool IsVisible
        {
            get => isVisible;
            set => isVisible = value;
        }
        protected GameAsset(int positionX, int positionY,bool isPassable,bool isVisible, char mapRepresentation)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.mapRepresentation = mapRepresentation;
            this.ispassable = isPassable;
            this. isVisible = isVisible;
        }
    }
}
